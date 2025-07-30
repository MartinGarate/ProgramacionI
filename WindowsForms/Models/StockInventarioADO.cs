using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Models
{
    public class StockInventarioADO
    {
        public int? _id { get; set; }
        public string nombre { get; set; }
        public int? cantidad_stock { get; set; }
        public double precio { get; set; }
        public string proveedor { get; set; }
        public string? url_imagen { get; set; }

    }
}
