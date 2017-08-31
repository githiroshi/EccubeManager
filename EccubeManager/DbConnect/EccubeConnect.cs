using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;
using Dapper;
using System.Configuration;
using EccubeManager.Model;

namespace EccubeManager
{
    public class EccubeConnect : IDisposable
    {
        #region property

        ///<summary>
        ///データベース接続
        ///</summary>
        private IDbConnection Connection { get; set; }

        /// <summary>
        /// トランザクション
        /// </summary>
        private IDbTransaction Transaction { get; set; }

        /// <summary>
        /// 接続状態
        /// </summary>
        public Boolean IsConnected
        {
            get
            {
                return (Connection.State == ConnectionState.Open);
            }
        }

        #endregion

        #region constructor
        ///<summary>
        /// コンストラクタ
        ///</summary>
        public EccubeConnect()
        {
            var dbFactory = new DataBaseFactory();

            //接続先を設定
            var DbString = "MySQL";
            if (Properties.Settings.Default.IsPostgres == true)
            {
                DbString = "Postgres";
            }       
             //DB接続
            Connection = dbFactory.DbFactory(DbString);
        }
        #endregion

        #region method
        /// <summary>
        /// コネクションオープン
        /// </summary>
        public void ConnectionOpen()
        {
            if (!IsConnected)
            {
                Connection.Open();
            }
        }

        /// <summary>
        /// コネクションクローズ
        /// </summary>
        public void ConnectionClose()
        {
            if (IsConnected)
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// トランザクション開始
        /// </summary>
        public void BeginTransaction()
        {
            Transaction = Connection.BeginTransaction(IsolationLevel.Serializable);
        }

        /// <summary>
        /// コミット
        /// </summary>
        public void CommitTransaction()
        {
            if (Transaction != null && Transaction.Connection != null)
            {
                Transaction.Commit();
            }
        }

        /// <summary>
        /// ロールバック
        /// </summary>
        public void RollBackTransaction()
        {
            if (Transaction != null && Transaction.Connection != null)
            {
                Transaction.Rollback();
            }
        }

        /// <summary>
        /// データ抽出
        /// </summary>
        protected List<t> Select<t>(string query, object parameters) where t : class
        {
            return Connection.Query<t>(query, parameters).ToList();

        }

        /// <summary>
        /// データ抽出
        /// </summary>
        public List<t> Select<t>(string query) where t : class
        {
            return Connection.Query<t>(query).ToList();
        }

        /// <summary>
        /// データ抽出
        /// </summary>
        public List<t> SelectMaster<t>(string tableName) where t : class
        {
            return Connection.Query<t>(string.Format("SELECT id,name FROM mtb_{0}", tableName)).ToList();
        }

        /// <summary>
        /// SQL実行
        /// </summary>
        public void Execute(string query)
        {
            Connection.Execute(query);
        }

        /// <summary>
        /// SQL実行
        /// </summary>
        public void Execute(string query, object parameters)
        {
            Connection.Execute(query, parameters);
        }

        public void Dispose()
        {
        }
        #endregion
    }
}
