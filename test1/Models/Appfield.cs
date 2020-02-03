using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1.Models
{
    public class Appfield
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public List<string> images { get; set; }
        public List<string> info { get; set; }
        public string infohead { get; set; }
    }
}
