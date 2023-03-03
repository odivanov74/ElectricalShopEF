using ElectricalDevicesEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalShopEF.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime DateOfSale { get; set; }
        public Client Client { get; set; }
        public ICollection<Device> Devices { get; set; } = new List<Device>();


    }
}
