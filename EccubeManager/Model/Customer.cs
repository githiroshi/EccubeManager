using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccubeManager.Model
{
    class Customer
    {
        public int customer_id { get; set; }
        public int sex { get; set; }
        public int job { get; set; }
        public int pref { get; set; }
        public string name01 { get; set; }
        public string name02 { get; set; }
        public string kana01 { get; set; }
        public string kana02 { get; set; }
        public string zip01 { get; set; }
        public string zip02 { get; set; }
        public string addr01 { get; set; }
        public string addr02 { get; set; }
        public string email { get; set; }
        public string tel01 { get; set; }
        public string tel02 { get; set; }
        public string tel03 { get; set; }
    }
}
