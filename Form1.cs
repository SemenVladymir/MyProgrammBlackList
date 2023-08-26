using Numismatics.Connection;
using User = MyProgrammBlackList.Models.User;

namespace MyProgrammBlackList
{
    public partial class Form1 : Form
    {
        int myId = -1;
        public List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectClients();

        }

        public void SelectClients()
        {
            users = new List<User>();
            using (MyContext context = new MyContext())
            {
                users = context.Users.ToList();
            }
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            foreach (var u in users)
            {
                if (u.Login.Equals(Login.Text) && u.Password.Equals(Password.Text))
                    myId = u.Id;
            }
            if (myId == 1 || myId == 2)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.UserId = myId;
                form2.Show();
            }
            else if (myId == 3)
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
                MessageBox.Show("Client with this Login and Password haven`t find!");
        }
    }
}