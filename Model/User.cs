using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalShopEF.Model
{
    public enum UserRole
    {
        Admin,
        Manager,
        Director,
        Client
    }
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public UserRole Role { get; set; }
        public string Email { get; set; } = "oas671280@yandex.ru";
    }
}
