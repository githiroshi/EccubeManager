using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccubeManager.Model
{
    public class Order
    {
        [System.ComponentModel.DisplayName("受注番号")]
        public int order_id { get; set; }
        
        [System.ComponentModel.DisplayName("受注状況")]
        public int status { get; set; }

        [System.ComponentModel.DisplayName("顧客番号")]
        public int customer_id { get; set; }

        [System.ComponentModel.DisplayName("都道府県")]
        public int order_pref { get; set; }

        [System.ComponentModel.DisplayName("職業")]
        public int order_job { get; set; }

        [System.ComponentModel.DisplayName("支払ID")]
        public int payment_id { get; set; }

        [System.ComponentModel.DisplayName("メッセージ")]
        public string message { get; set; }

        [System.ComponentModel.DisplayName("氏名1")]
        public string order_name01 { get; set; }

        [System.ComponentModel.DisplayName("氏名2")]
        public string order_name02 { get; set; }

        [System.ComponentModel.DisplayName("カナ1")]
        public string order_kana01 { get; set; }

        [System.ComponentModel.DisplayName("カナ2")]
        public string order_kana02 { get; set; }

        [System.ComponentModel.DisplayName("メール")]
        public string order_email { get; set; }

        [System.ComponentModel.DisplayName("電話番号1")]
        public string order_tel01 { get; set; }

        [System.ComponentModel.DisplayName("電話番号2")]
        public string order_tel02 { get; set; }

        [System.ComponentModel.DisplayName("電話番号3")]
        public string order_tel03 { get; set; }

        [System.ComponentModel.DisplayName("郵便番号1")]
        public string order_zip01 { get; set; }

        [System.ComponentModel.DisplayName("郵便番号2")]
        public string order_zip02 { get; set; }

        [System.ComponentModel.DisplayName("住所1")]
        public string order_addr01 { get; set; }

        [System.ComponentModel.DisplayName("住所2")]
        public string order_addr02 { get; set; }

        [System.ComponentModel.DisplayName("小計")]
        public decimal subtotal { get; set; }

        [System.ComponentModel.DisplayName("割引")]
        public decimal discount { get; set; }

        [System.ComponentModel.DisplayName("送料")]
        public decimal delivery_fee_total { get; set; }

        [System.ComponentModel.DisplayName("手数料")]
        public decimal charge { get; set; }

        [System.ComponentModel.DisplayName("消費税")]
        public decimal tax { get; set; }

        [System.ComponentModel.DisplayName("合計")]
        public decimal total { get; set; }

        [System.ComponentModel.DisplayName("支払合計")]
        public decimal payment_total { get; set; }

        [System.ComponentModel.DisplayName("支払方法")]
        public string payment_method { get; set; }

        [System.ComponentModel.DisplayName("ノート")]
        public string note { get; set; }

        [System.ComponentModel.DisplayName("更新日")]
        public DateTime update_date { get; set; }

        [System.ComponentModel.DisplayName("受注日")]
        public DateTime order_date { get; set; }

        [System.ComponentModel.DisplayName("発送日")]
        public DateTime commit_date { get; set; }

        [System.ComponentModel.DisplayName("入金日")]
        public DateTime payment_date { get; set; }

    }
}
