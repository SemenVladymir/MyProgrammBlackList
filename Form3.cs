using Microsoft.VisualBasic.ApplicationServices;
using MyProgrammBlackList.Models;
using Numismatics.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using User = MyProgrammBlackList.Models.User;

namespace MyProgrammBlackList
{
    public partial class Form3 : Form
    {
        public List<App> apps = new List<App>();
        public List<User> users = new List<User>();
        public Form3()
        {
            InitializeComponent();

        }

        public void SelectClients()
        {
            users = new List<User>();
            using (MyContext context = new MyContext())
            {
                users = context.Users.ToList();
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


        private void Form3_Load(object sender, EventArgs e)
        {
            SelectClients();
            foreach (var u in users)
                comboBox1.Items.Add(u.Login);
            apps = SelectApps();
            foreach (App app in apps)
                listBox1.Items.Add(app.Name);
            var vs = Process.GetProcesses().OrderBy(ee => ee.ProcessName).ToList();
            List<string> str = new List<string>();
            foreach (var item in vs)
                str.Add(item.ProcessName);
            str = str.Distinct().ToList();
            foreach (var item in str)
                checkedListBox1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0 && !string.IsNullOrEmpty(textBox1.Text))
            {
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    AddNewApp(new App { Name = item.ToString(), Duration = Convert.ToInt32(textBox1.Text), StartTime = DateTime.Now, EndTime = DateTime.Now, UserId = users.FirstOrDefault(ee => ee.Login == comboBox1.SelectedItem).Id });
                }
                listBox1.Items.Clear();
                apps = SelectApps();
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
                apps = SelectApps();
                foreach (App app in apps)
                    listBox1.Items.Add(app.Name);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedItem.ToString();
            textBox1.Text = apps.FirstOrDefault(ee => ee.Name == listBox1.SelectedItem.ToString()).Duration.ToString();
            dateTimePicker1.Text = apps.FirstOrDefault(ee => ee.Name == listBox1.SelectedItem.ToString()).StartTime.ToString();
            dateTimePicker2.Text = apps.FirstOrDefault(ee => ee.Name == listBox1.SelectedItem.ToString()).EndTime.ToString();
            comboBox1.SelectedIndex = (int)apps.FirstOrDefault(ee => ee.Name == listBox1.SelectedItem.ToString()).UserId-1;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            App newApp = apps.FirstOrDefault(ee => ee.Name == listBox1.SelectedItem.ToString());
            newApp.Name = textBox2.Text;
            newApp.Duration = Convert.ToInt32(textBox1.Text);
            newApp.StartTime = dateTimePicker1.Value;
            newApp.EndTime = dateTimePicker2.Value;
            UpdateApp(newApp);
            listBox1.Items.Clear();
            apps = SelectApps();
            foreach (App app in apps)
                listBox1.Items.Add(app.Name);
        }
    }
}
