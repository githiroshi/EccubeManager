using EccubeManager.Common;
using EccubeManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EccubeManager.frm
{
    public partial class frmOrderList : Form
    {
        private readonly IOrderService _OrderService;
        
        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="orderService"></param>
        public frmOrderList(IOrderService orderService)
        {
            InitializeComponent();
            this._OrderService = orderService;
        }
        #endregion
        
        #region イベントハンドラ
        /// <summary>
        /// フォームをロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrderList_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 検索ボタンをクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            OrderListGridView.DataSource = _OrderService.GetOrder();

            //一覧のコンボボックスを生成
            ComboBoxSetter.SetComboBox(OrderListGridView, "order_job");
            ComboBoxSetter.SetComboBox(OrderListGridView, "order_pref");
            ComboBoxSetter.SetComboBox(OrderListGridView, "status");
        }

        #endregion


    }
}
