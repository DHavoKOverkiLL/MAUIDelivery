using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDelivery.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Header { get; set; } = string.Empty;
        public string Logo { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string DeliveryTime { get; set; } = string.Empty;
        public int Minimum { get; set; }
        public int ServiceFee { get; set; }
        public double Rating { get; set; }
    }
}
