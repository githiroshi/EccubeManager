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

            IOrderService orderService = new OrderService();
            ICustomerService customerService = new CustomerService();

            Application.Run(new frmHome(orderService, customerService));
        }
    }
}
