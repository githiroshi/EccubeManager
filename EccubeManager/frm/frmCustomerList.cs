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
        /// フォームをロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            try
            {
                //コンボボックス用のマスターデータを取得
                sexBindingSource.DataSource = MasterTableRepository.GetMasterTable("sex");
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
        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                //データを取得
                CustomerListGridView.DataSource = _CustomerService.GetCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region インプリメンテーション

        #endregion


    }
}
