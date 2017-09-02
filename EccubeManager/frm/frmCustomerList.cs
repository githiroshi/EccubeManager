using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;
using Dapper;
using System.Configuration;
using EccubeManager.Model;
using EccubeManager.Services;
using EccubeManager.Common;

namespace EccubeManager
{
    public partial class frmCustomerList : Form
    {
        private readonly ICustomerService _CustomerService;

        #region コンストラクタ
        public frmCustomerList(ICustomerService customerService)
        {
            InitializeComponent();
            this._CustomerService = customerService;
        }
        #endregion


        #region イベントハンドラ

        /// <summary>
        /// 検索ボタンをクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            //データを取得
            CustomerListGridView.DataSource = _CustomerService.GetCustomer();
        }

        #endregion

        #region インプリメンテーション
        
        #endregion
    }
}
