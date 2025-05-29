using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Models
{
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Current
        {
            public string time { get; set; }
            public int interval { get; set; }
            public double temperature_2m { get; set; }
            public int relative_humidity_2m { get; set; }
            public double apparent_temperature { get; set; }
            public int is_day { get; set; }
        }  
}
