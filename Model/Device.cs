using ElectricalDevicesEF.Model;
using ElectricalShopEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalDevicesEF
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ManufactureDate { get; set; }
        public bool isDefected { get; set; }
        public ModelDevice ModelDevice { get; set; }
        public Order Order { get; set; }
        public Basket Basket { get; set; }

    }
}
