using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalShopEF.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int PersonalDiscount { get; set; }
        public ICollection<Basket> Baskets { get; set; } = new List<Basket>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public User User { get; set; }

    }
}
