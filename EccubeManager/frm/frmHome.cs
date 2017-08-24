using EccubeManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EccubeManager
{
    public partial class frmHome : Form
    {
        private frmCustomerList _CustomerForm = null;
        
        #region コンストラクタ
        public frmHome()
        {
            InitializeComponent();
        }
        #endregion

        #region イベントハンドラ
        /// <summary>
        /// ロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHome_Load(object sender, EventArgs e)
        {
            //売り上げ状況をセット
            SetSales();

        }

        /// <summary>
        /// 顧客管理ボタンをクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowCustomerForm();
        }

        #endregion

        #region インプリメンテーション

        /// <summary>
        /// 顧客管理画面を表示
        /// </summary>
        private void ShowCustomerForm()
        {
            //フォームが表示されているかの判定  
            if (this._CustomerForm == null || this._CustomerForm.IsDisposed)
                this._CustomerForm = new frmCustomerList();

            if (!this._CustomerForm.Visible)
            {
                this._CustomerForm.Show();
            }
            else
            {
                this._CustomerForm.Activate();
            }

        }

        /// <summary>
        /// 売上情報を取得表示
        /// </summary>
        private void SetSales()
        {
            using (var connection = new EccubeConnect())
            {
                //コネクションオープン
                connection.ConnectionOpen();

                // データ取得
                var order = connection.Select<Order>("SELECT * FROM public.dtb_order " +
                                                     "WHERE order_date >= now() + '-1 month' " +
                                                     "ORDER BY order_id ASC");
                // 必要な変数を宣言する
                DateTime dtNow = DateTime.Now;

                var orderMonth = order.Where(r => r.order_date.Month == dtNow.Month);
                lblAmountOfMonth.Text = orderMonth.Select(r => r.payment_total).Sum().ToString("C");
                lblCountOfMonth.Text = string.Format("{0}件", orderMonth.Count().ToString());

                var orderToday = order.Where(r => r.order_date.Day == dtNow.Day);
                lblAmountOfToday.Text = orderToday.Select(r => r.payment_total).Sum().ToString("C");
                lblCountOfToday.Text = string.Format("{0}件", orderToday.Count().ToString());

                var orderYesterday = order.Where(r => r.order_date.Day == dtNow.AddDays(-1).Day);
                lblAmountOfYesterday.Text = orderYesterday.Select(r => r.payment_total).Sum().ToString("C");
                lblCountOfYesterday.Text = string.Format("{0}件", orderYesterday.Count().ToString());
            }
        }
        #endregion
        
    }

}
