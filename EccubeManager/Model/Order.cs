using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccubeManager.Model
{
    public class Order
    {
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public int order_pref { get; set; }
        public int order_job { get; set; }
        public int payment_id { get; set; }
        public string message { get; set; }
        public string order_name01 { get; set; }
        public string order_name02 { get; set; }
        public string order_kana01 { get; set; }
        public string order_kana02 { get; set; }
        public string order_email { get; set; }
        public string order_tel01 { get; set; }
        public string order_tel02 { get; set; }
        public string order_tel03 { get; set; }
        public string order_zip01 { get; set; }
        public string order_zip02 { get; set; }
        public string order_addr01 { get; set; }
        public string order_addr02 { get; set; }
        public decimal subtotal { get; set; }
        public decimal discount { get; set; }
        public decimal delivery_fee_total { get; set; }
        public decimal charge { get; set; }
        public decimal tax { get; set; }
        public decimal total { get; set; }
        public decimal payment_total { get; set; }
        public string payment_method { get; set; }
        public string note { get; set; }
        public DateTime order_date { get; set; }

    }
}
