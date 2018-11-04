using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Storage.AutoContext
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Power { get; set; }
        public double Acceleration { get; set; }
        public double Consumption { get; set; }
        public int MaxSpeed { get; set; }
        public int Price { get; set; }

        public int? MarkId { get; set; }
        public Mark Mark { get; set; }

        public int? ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
