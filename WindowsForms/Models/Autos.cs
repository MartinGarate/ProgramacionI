using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Models
{
    public class Autos
    {
        public string _id { get; set; }
        public string imagen { get; set; }
        public string marca { get; set; }
        public int anio { get; set; }
        public string modelo { get; set; }
        public double precio { get; set; }
        public bool usado { get; set; }
    }
}
