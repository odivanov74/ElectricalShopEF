using ElectricalShopEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalDevicesEF.Model
{
    public class ModelDevice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
        public int StockBalance { get; set; }
        public int Reserved { get; set; }

        //public int Saled { get; set; } //правильней считать по заказам
        public TypeModel TypeModel { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Supplier Supplier { get; set; }
    }
}
