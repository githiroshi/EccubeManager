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
            //接続先情報をセット
            if (Properties.Settings.Default.IsPostgres)
            {
                btnPostgres.Checked = true;

                txtServer.Text = Properties.Settings.Default.PostgresServer;
                txtServer.Text = Properties.Settings.Default.PostgresPort;
                txtServer.Text = Properties.Settings.Default.PostgresDatabase;
                txtServer.Text = Properties.Settings.Default.PostgresUserId;
                txtServer.Text = Properties.Settings.Default.PostgresPassword;
            }
            else
            {
                btnMysql.Checked = true;
                txtServer.Text = Properties.Settings.Default.MysqlServer;
                txtServer.Text = Properties.Settings.Default.MysqlPort;
                txtServer.Text = Properties.Settings.Default.MysqlDatabase;
                txtServer.Text = Properties.Settings.Default.MysqlUserId;
                txtServer.Text = Properties.Settings.Default.MysqlPassword;
            }




        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
