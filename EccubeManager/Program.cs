using EccubeManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EccubeManager
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IOrderService orderService = null;
            ICustomerService customerService = new CustomerService();
            if (Properties.Settings.Default.IsPostgres)
            {
                orderService = new PostgresOrderService();
            }
            else
            {
                orderService = new MysqlOrderService();
            }

            Application.Run(new frmHome(orderService, customerService));
        }
    }
}
