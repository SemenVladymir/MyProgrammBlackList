using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyProgrammBlackList.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string? Password { get; set; }
        public int TypeId { get; set; }

        public User()
        {
            Id = 0;
            Login = string.Empty;
            Password = string.Empty;
            TypeId = 1;
        }

        public User(int id, string login, string password, int typeId)
        {
            Id = id;
            Login = login;
            Password = password;
            TypeId = typeId;
        }
    }
}
