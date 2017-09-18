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
    public partial class frmSettings : Form
    {

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSettings_Load(object sender, EventArgs e)
        {
            //ラジオボタンを初期化
            if (Properties.Settings.Default.IsPostgres)
            {
                btnPostgres.Checked = true;
            }
            else
            {
                btnMysql.Checked = true;
            }

            //接続情報を取得
            GetSettings();

        }

        /// <summary>
        /// 閉じるをクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 登録ボタンをクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegist_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("設定を保存しますがよろしいですか？" + 
                                                   Environment.NewLine + 
                                                   "変更後アプリケーションは終了します。", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //接続情報を保存
                SetSettings();

                //メッセージボックスを表示する
                result = MessageBox.Show("設定を変更しました。" + 
                                          Environment.NewLine + 
                                          "アプリケーションを再起動してください。", "設定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btnPostgres_CheckedChanged(object sender, EventArgs e)
        {
            //接続情報を取得
            GetSettings();
        }

        #region インプリメンテーション
        /// <summary>
        /// 接続情報を取得
        /// </summary>
        private void GetSettings()
        {
            if (btnPostgres.Checked)
            {
                btnPostgres.Checked = true;
                txtServer.Text = Properties.Settings.Default.PostgresServer;
                txtPort.Text = Properties.Settings.Default.PostgresPort;
                txtDatabase.Text = Properties.Settings.Default.PostgresDatabase;
                txtUserId.Text = Properties.Settings.Default.PostgresUserId;
                txtPassword.Text = Properties.Settings.Default.PostgresPassword;
            }
            else
            {
                btnMysql.Checked = true;
                txtServer.Text = Properties.Settings.Default.MysqlServer;
                txtPort.Text = Properties.Settings.Default.MysqlPort;
                txtDatabase.Text = Properties.Settings.Default.MysqlDatabase;
                txtUserId.Text = Properties.Settings.Default.MysqlUserId;
                txtPassword.Text = Properties.Settings.Default.MysqlPassword;
            }
        }

        /// <summary>
        /// 接続情報を取得
        /// </summary>
        private void SetSettings()
        {
            if (btnPostgres.Checked)
            {
                Properties.Settings.Default.IsPostgres = true;
                Properties.Settings.Default.PostgresServer = txtServer.Text;
                Properties.Settings.Default.PostgresPort = txtPort.Text;
                Properties.Settings.Default.PostgresDatabase = txtDatabase.Text;
                Properties.Settings.Default.PostgresUserId = txtUserId.Text;
                Properties.Settings.Default.PostgresPassword = txtPassword.Text;
            }
            else
            {
                Properties.Settings.Default.IsPostgres = false;
                Properties.Settings.Default.MysqlServer = txtServer.Text;
                Properties.Settings.Default.MysqlPort = txtPort.Text;
                Properties.Settings.Default.MysqlDatabase = txtDatabase.Text;
                Properties.Settings.Default.MysqlUserId = txtUserId.Text;
                Properties.Settings.Default.MysqlPassword = txtPassword.Text;
            }

            //アプリケーションの設定を保存する
            Properties.Settings.Default.Save();
        }
        #endregion


    }
}
