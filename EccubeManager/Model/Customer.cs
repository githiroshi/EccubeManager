using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccubeManager.Model
{
    public class Customer
    {
        [System.ComponentModel.DisplayName("顧客番号")]
        public int customer_id { get; set; }

        [System.ComponentModel.DisplayName("性別")]
        public int? sex { get; set; }

        [System.ComponentModel.DisplayName("職業")]
        public int? job { get; set; }

        [System.ComponentModel.DisplayName("都道府県")]
        public int pref { get; set; }

        [System.ComponentModel.DisplayName("氏名1")]
        public string name01 { get; set; }

        [System.ComponentModel.DisplayName("氏名2")]
        public string name02 { get; set; }

        [System.ComponentModel.DisplayName("カナ1")]
        public string kana01 { get; set; }

        [System.ComponentModel.DisplayName("カナ2")]
        public string kana02 { get; set; }

        [System.ComponentModel.DisplayName("郵便番号1")]
        public string zip01 { get; set; }

        [System.ComponentModel.DisplayName("郵便番号2")]
        public string zip02 { get; set; }

        [System.ComponentModel.DisplayName("住所1")]
        public string addr01 { get; set; }

        [System.ComponentModel.DisplayName("住所2")]
        public string addr02 { get; set; }

        [System.ComponentModel.DisplayName("メール")]
        public string email { get; set; }

        [System.ComponentModel.DisplayName("電話番号1")]
        public string tel01 { get; set; }

        [System.ComponentModel.DisplayName("電話番号2")]
        public string tel02 { get; set; }

        [System.ComponentModel.DisplayName("電話番号3")]
        public string tel03 { get; set; }
    }
}
