using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Storage.AutoContext
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Mark> Marks { get; set; }
        public Manufacturer()
        {
            Marks = new List<Mark>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
