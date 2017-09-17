using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccubeManager.Model
{
    public class OrderDetail
    {
        [System.ComponentModel.DisplayName("受注明細番号")]
        public int order_detail_id { get; set; }

        [System.ComponentModel.DisplayName("受注番号")]
        public int order_id { get; set; }

        [System.ComponentModel.DisplayName("商品ID")]
        public int product_id { get; set; }

        [System.ComponentModel.DisplayName("商品クラスID")]
        public int product_class_id { get; set; }

        [System.ComponentModel.DisplayName("商品名")]
        public string product_name { get; set; }

        [System.ComponentModel.DisplayName("商品番号")]
        public string product_code { get; set; }

        [System.ComponentModel.DisplayName("クラス名1")]
        public string class_name1 { get; set; }

        [System.ComponentModel.DisplayName("クラス名2")]
        public string class_name2 { get; set; }

        [System.ComponentModel.DisplayName("クラスカテゴリー名1")]
        public string class_category_name1 { get; set; }

        [System.ComponentModel.DisplayName("クラスカテゴリー名2")]
        public string class_category_name2 { get; set; }

        [System.ComponentModel.DisplayName("金額")]
        public decimal price { get; set; }

        [System.ComponentModel.DisplayName("数量")]
        public decimal quantity { get; set; }

        [System.ComponentModel.DisplayName("税率")]
        public decimal tax_rate { get; set; }

        [System.ComponentModel.DisplayName("税")]
        public int tax_rule { get; set; }
    }
}
