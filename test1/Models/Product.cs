using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public List<string> images { get; set; }
        public List<string> info { get; set; }
        public List<infoTech> infotech { get; set; }
    }

    public class infoTech{

        public string dataName { get; set; }
        public string dataVal { get; set; }
    }
}
