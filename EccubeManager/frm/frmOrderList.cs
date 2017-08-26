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

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="orderService"></param>
        public frmOrderList(IOrderService orderService)
        {
            InitializeComponent();
            this._OrderService = orderService;
        }

        private void frmOrderList_Load(object sender, EventArgs e)
        {
            OrderListGridView.DataSource = _OrderService.GetOrder();
        }
    }
}
