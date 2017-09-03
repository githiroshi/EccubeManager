using EccubeManager.frm;
using EccubeManager.Model;
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

namespace EccubeManager
{
    public partial class frmHome : Form
    {
        private readonly IOrderService _OrderService;
        private readonly ICustomerService _CustomerService;
        private frmCustomerList _CustomerForm = null;
        private frmOrderList _OrderForm = null;
        
        #region コンストラクタ
        public frmHome(IOrderService orderService ,ICustomerService customerService)
        {
            InitializeComponent();

            timer1.Interval = 10000;
            timer1.Enabled = true; // timer.Start()と同じ

            this._OrderService = orderService;
            this._CustomerService = customerService;
        }
        #endregion

        #region イベントハンドラ
        /// <summary>
        /// ロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void frmHome_Load(object sender, EventArgs e)
        {
            //現在の状況を表示
            await SetCurrentInfo();
        }

        /// <summary>
        /// 設定ボタンをクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            //設定画面を開く
            Form frmSettings = new frmSettings();
            frmSettings.ShowDialog();
            frmSettings.Dispose();
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

        /// <summary>
        /// 受注管理ボタンをクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowOrderForm();
        }

        /// <summary>
        /// タイマー処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void timer1_Tick(object sender, EventArgs e)
        {
            await this.SetCurrentInfo();
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
            {
                ICustomerService customerService = new CustomerService();
                this._CustomerForm = new frmCustomerList(customerService);
            }
         

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
        /// 顧客管理画面を表示
        /// </summary>
        private void ShowOrderForm()
        {
            //フォームが表示されているかの判定  
            if (this._OrderForm == null || this._OrderForm.IsDisposed)
            {
                IOrderService orderService = new PostgresOrderService();
                this._OrderForm = new frmOrderList(orderService);
            }


            if (!this._OrderForm.Visible)
            {
                this._OrderForm.Show();
            }
            else
            {
                this._OrderForm.Activate();
            }

        }
        /// <summary>
        /// 受注情報を表示
        /// </summary>
        /// <param name="order"></param>
        private void SetOrderStatus(IList<Order> order)
        {
            //新規受付
            lblNewOrder.Text = order.Where(r => r.status == 1).Count().ToString("###,##0件");
            //入金待ち
            lblPendingOrder.Text = order.Where(r => r.status == 2).Count().ToString("###,##0件");
            //入金済み
            lblPaidOrder.Text = order.Where(r => r.status == 3).Count().ToString("###,##0件");
            //取り寄せ中
            lblBackOrder.Text = order.Where(r => r.status == 5).Count().ToString("###,##0件");

        }
        /// <summary>
        /// 売上情報を表示
        /// </summary>
        private void SetSales(IList<Order> order, DateTime dtNow)
        {
         　 //今月の売上を表示
            var orderMonth = order.Where(r => r.order_date.Month == dtNow.Month);
            lblAmountOfMonth.Text = orderMonth.Select(r => r.payment_total).Sum().ToString("C");
            lblCountOfMonth.Text = string.Format("{0}件", orderMonth.Count().ToString());
            //今日の売上を表示
            var orderToday = order.Where(r => r.order_date.Day == dtNow.Day);
            lblAmountOfToday.Text = orderToday.Select(r => r.payment_total).Sum().ToString("C");
            lblCountOfToday.Text = string.Format("{0}件", orderToday.Count().ToString());
            //昨日の売上を表示
            var orderYesterday = order.Where(r => r.order_date.Day == dtNow.AddDays(-1).Day);
            lblAmountOfYesterday.Text = orderYesterday.Select(r => r.payment_total).Sum().ToString("C");
            lblCountOfYesterday.Text = string.Format("{0}件", orderYesterday.Count().ToString());
        }

        /// <summary>
        /// 現在の受注、会員情報を表示
        /// </summary>
        /// <returns></returns>
        private async Task SetCurrentInfo()
        {
            //現在時刻をセット
            DateTime dtNow = DateTime.Now;

            // 受注データを取得
            var order = await _OrderService.GetOrderAsync();
            //受注状況をセット
            SetOrderStatus(order);
            //売り上げ状況をセット
            SetSales(order, dtNow);
            //会員数をセット
            var customer = _CustomerService.GetCustomer();
            lblCustomerCount.Text = customer.Count.ToString("###,##0人");

            //更新時刻を表示
            lblUpdateTime.Text = string.Format("更新時刻:{0}", dtNow.ToLongTimeString());
        }
        #endregion



    }

}
