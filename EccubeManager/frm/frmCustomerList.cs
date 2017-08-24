﻿using System.Windows.Forms;
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

namespace EccubeManager
{
    public partial class frmCustomerList : Form
    {
        #region コンストラクタ
        public frmCustomerList()
        {
            InitializeComponent();
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
            CustomerService _CustomerService = new CustomerService();

            CustomerListGridView.DataSource = _CustomerService.GetCustomer();

            SetComboBox("sex");
            SetComboBox("job");
            SetComboBox("pref");
        }

        #endregion

        #region インプリメンテーション

        private void SetComboBox(string tableName)
        {
            using (var connection = new EccubeConnect())
            {
                //コネクションオープン
                connection.ConnectionOpen();

                //DataGridViewComboBoxColumnを作成
                DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                //表示する列の名前を設定する
                column.DataPropertyName = CustomerListGridView.Columns[tableName].DataPropertyName;
                //DataGridViewComboBoxColumnのDataSourceを設定
                var master = connection.SelectMaster<Master>(tableName);

                column.DataSource = master;
                //実際の値が"id"列、表示するテキストが"name"列とする
                column.ValueMember = "id";
                column.DisplayMember = "name";
                //ReadOnlyに変更
                column.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                column.ReadOnly = true;

                //現在の列が存在している位置に挿入する
                CustomerListGridView.Columns.Insert(CustomerListGridView.Columns[tableName].Index, column);
                //今までの列を削除する
                CustomerListGridView.Columns.Remove(tableName);
                //挿入した列の名前を変更する
                column.Name = tableName;
            }
        }
        #endregion
    }
}