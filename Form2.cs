using Microsoft.Win32;
using MyProgrammBlackList.Models;
using Numismatics.Connection;
using System.Data;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace MyProgrammBlackList
{
    public partial class Form2 : Form
    {
        public List<App> apps = new List<App>();
        public int UserId;
        Timer _timer = new Timer();
        public Form2()
        {
            InitializeComponent();
            _timer.Interval = 1000;
            _timer.Tick += OnTimerTick;
        }

        private void OnTimerTick(object? sender, EventArgs e)
        {
            SelectApps();
            foreach (App app in apps)
            {
                var vs = Process.GetProcessesByName(app.Name);
                if (vs.Length != 0)
                {
                    if (app.Today == DateTime.Now.Date)
                    {
                        if (app.StartTime == vs[0].StartTime)
                        {
                            try
                            {
                                DateTime start = vs[0].StartTime;
                                TimeSpan timespan = (start - DateTime.Now).Duration();
                                app.TimeLastSeans = (int)timespan.TotalMinutes;
                                UpdateApp(app);
                                if (app.TimeOfWork + app.TimeLastSeans >= app.Duration)
                                {
                                    foreach (var item in vs)
                                        item.Kill();
                                }
                            }
                            catch (Exception ex) { }
                        }
                        else
                        {
                            app.TimeOfWork += app.TimeLastSeans;
                            app.TimeLastSeans = 0;
                            UpdateApp(app);
                            if (app.TimeOfWork >= app.Duration)
                            {
                                try
                                {
                                    foreach (var item in vs)
                                        item.Kill();
                                }
                                catch (Exception ez) { }
                            }
                            else
                            {
                                app.StartTime = vs[0].StartTime;
                                UpdateApp(app);
                            }
                        }

                    }
                    else
                    {
                        app.Today = DateTime.Now.Date;
                        app.TimeOfWork = 0;
                        UpdateApp(app);
                    }
                }
            }
        }

        public List<App> SelectApps()
        {
            using (MyContext context = new MyContext())
            {
                return context.Apps.ToList();
            }
        }

        public void SelectAppsByUserId(int id)
        {
            using (MyContext context = new MyContext())
            {
                apps = context.Apps.Where(ee => ee.UserId == id).ToList();
            }
        }

        public void AddNewApp(App app)
        {
            using (MyContext context = new MyContext())
            {
                context.Apps.Add(app);
                context.SaveChanges();
            }
        }

        public void RemoveAppByName(string name)
        {
            using (MyContext context = new MyContext())
            {
                context.Apps.Remove(context.Apps.FirstOrDefault(x => x.Name.Equals(name)));
                context.SaveChanges();
            }
        }

        public void UpdateApp(App newapp)
        {
            using (MyContext context = new MyContext())
            {
                context.Apps.Update(newapp);
                context.SaveChanges();
            }
        }


        private void BtnChange_Click(object sender, EventArgs e)
        {
            App newApp = apps.FirstOrDefault(ee => ee.Name == listBox1.SelectedItem.ToString());
            newApp.Name = textBox1.Text;
            newApp.Duration = Convert.ToInt32(textBox2.Text);
            newApp.StartTime = dateTimePicker1.Value;
            newApp.EndTime = dateTimePicker2.Value;
            UpdateApp(newApp);
            SelectAppsByUserId(UserId);
            listBox1.Items.Clear();
            foreach (App app in apps)
                listBox1.Items.Add(app.Name);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (UserId == 1)
            {
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                textBox4.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {
                label7.Visible = false;
                textBox3.Visible = false;
            }
            SelectAppsByUserId(UserId);
            foreach (App app in apps)
                listBox1.Items.Add(app.Name);
            _timer.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                AddNewApp(new App { Name = textBox1.Text, StartTime = DateTime.Now, EndTime = DateTime.Now, Duration = Convert.ToInt32(textBox2.Text), UserId = this.UserId });
                SelectAppsByUserId(UserId);
                listBox1.Items.Clear();
                foreach (App app in apps)
                    listBox1.Items.Add(app.Name);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to delete this string?",
            "Attention",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                List<App> myapps = SelectApps();
                RemoveAppByName(listBox1.SelectedItem.ToString());
                listBox1.Items.Clear();
                SelectAppsByUserId(UserId);
                foreach (App app in apps)
                    listBox1.Items.Add(app.Name);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
            textBox2.Text = apps.FirstOrDefault(ee => ee.Name == listBox1.SelectedItem.ToString()).Duration.ToString();
            if (UserId == 2)
            {
                dateTimePicker1.Text = apps.FirstOrDefault(ee => ee.Name == listBox1.SelectedItem.ToString()).StartTime.ToString();
                dateTimePicker2.Text = apps.FirstOrDefault(ee => ee.Name == listBox1.SelectedItem.ToString()).EndTime.ToString();
                //textBox4.Text = apps.FirstOrDefault(ee=>ee.Name== listBox1.SelectedItem.ToString()).
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    RegistryKey currentUserKey = Registry.CurrentUser;
                    RegistryKey myKey = currentUserKey.OpenSubKey("MyAppAdd");
                    string txt = textBox3.Text;
                    string key = myKey.GetValue("AppKeyCode").ToString();
                    if (txt == key)
                    {
                        label4.Enabled = true;
                        label5.Enabled = true;
                        label6.Enabled = true;
                        textBox4.Enabled = true;
                        dateTimePicker1.Enabled = true;
                        dateTimePicker2.Enabled = true;
                        label7.Visible = false;
                        textBox3.Visible = false;
                    }
                    myKey.Close();
                    currentUserKey.Close();
                }
            }
        }
    }
}
