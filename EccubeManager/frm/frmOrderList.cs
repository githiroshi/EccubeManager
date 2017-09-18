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
            try
            {
                //コンボボックス用のマスターデータを取得
                statusBindingSource.DataSource = MasterTableRepository.GetMasterTable("order_status");
                prefBindingSource.DataSource = MasterTableRepository.GetMasterTable("pref");
                jobBindingSource.DataSource = MasterTableRepository.GetMasterTable("job");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 検索ボタンをクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                //受注情報を非同期で取得
                orderBindingSource.DataSource = await _OrderService.GetOrderAsync();
                OrderListGridView.DataSource = orderBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion


    }
}
