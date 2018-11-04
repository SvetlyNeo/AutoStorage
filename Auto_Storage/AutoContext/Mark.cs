using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Storage.AutoContext
{
    public class Mark
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public ICollection<Car> Cars { get; set; }
        public Mark()
        {
            Cars = new List<Car>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
