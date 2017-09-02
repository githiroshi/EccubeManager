namespace EccubeManager
{
    partial class frmCustomerList
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CustomerListGridView = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kana01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kana02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.prefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zip01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tel01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel03DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.SearchButton, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 98);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(3, 75);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(107, 20);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CustomerListGridView
            // 
            this.CustomerListGridView.AllowUserToAddRows = false;
            this.CustomerListGridView.AllowUserToDeleteRows = false;
            this.CustomerListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerListGridView.AutoGenerateColumns = false;
            this.CustomerListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.name01DataGridViewTextBoxColumn,
            this.name02DataGridViewTextBoxColumn,
            this.kana01DataGridViewTextBoxColumn,
            this.kana02DataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.prefDataGridViewTextBoxColumn,
            this.zip01DataGridViewTextBoxColumn,
            this.zip02DataGridViewTextBoxColumn,
            this.addr01DataGridViewTextBoxColumn,
            this.addr02DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.tel01DataGridViewTextBoxColumn,
            this.tel02DataGridViewTextBoxColumn,
            this.tel03DataGridViewTextBoxColumn});
            this.CustomerListGridView.DataSource = this.customerBindingSource;
            this.CustomerListGridView.Location = new System.Drawing.Point(13, 116);
            this.CustomerListGridView.Name = "CustomerListGridView";
            this.CustomerListGridView.ReadOnly = true;
            this.CustomerListGridView.RowTemplate.Height = 21;
            this.CustomerListGridView.Size = new System.Drawing.Size(679, 257);
            this.CustomerListGridView.TabIndex = 1;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(EccubeManager.Model.Customer);
            // 
            // sexBindingSource
            // 
            this.sexBindingSource.DataSource = typeof(EccubeManager.Model.Master);
            // 
            // prefBindingSource
            // 
            this.prefBindingSource.DataSource = typeof(EccubeManager.Model.Master);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(EccubeManager.Model.Master);
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "顧客番号";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // name01DataGridViewTextBoxColumn
            // 
            this.name01DataGridViewTextBoxColumn.DataPropertyName = "name01";
            this.name01DataGridViewTextBoxColumn.HeaderText = "氏名1";
            this.name01DataGridViewTextBoxColumn.Name = "name01DataGridViewTextBoxColumn";
            this.name01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // name02DataGridViewTextBoxColumn
            // 
            this.name02DataGridViewTextBoxColumn.DataPropertyName = "name02";
            this.name02DataGridViewTextBoxColumn.HeaderText = "氏名2";
            this.name02DataGridViewTextBoxColumn.Name = "name02DataGridViewTextBoxColumn";
            this.name02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kana01DataGridViewTextBoxColumn
            // 
            this.kana01DataGridViewTextBoxColumn.DataPropertyName = "kana01";
            this.kana01DataGridViewTextBoxColumn.HeaderText = "カナ1";
            this.kana01DataGridViewTextBoxColumn.Name = "kana01DataGridViewTextBoxColumn";
            this.kana01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kana02DataGridViewTextBoxColumn
            // 
            this.kana02DataGridViewTextBoxColumn.DataPropertyName = "kana02";
            this.kana02DataGridViewTextBoxColumn.HeaderText = "カナ2";
            this.kana02DataGridViewTextBoxColumn.Name = "kana02DataGridViewTextBoxColumn";
            this.kana02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.DataSource = this.sexBindingSource;
            this.sexDataGridViewTextBoxColumn.DisplayMember = "name";
            this.sexDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sexDataGridViewTextBoxColumn.HeaderText = "性別";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sexDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sexDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // prefDataGridViewTextBoxColumn
            // 
            this.prefDataGridViewTextBoxColumn.DataPropertyName = "pref";
            this.prefDataGridViewTextBoxColumn.DataSource = this.prefBindingSource;
            this.prefDataGridViewTextBoxColumn.DisplayMember = "name";
            this.prefDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.prefDataGridViewTextBoxColumn.HeaderText = "都道府県";
            this.prefDataGridViewTextBoxColumn.Name = "prefDataGridViewTextBoxColumn";
            this.prefDataGridViewTextBoxColumn.ReadOnly = true;
            this.prefDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prefDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.prefDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // zip01DataGridViewTextBoxColumn
            // 
            this.zip01DataGridViewTextBoxColumn.DataPropertyName = "zip01";
            this.zip01DataGridViewTextBoxColumn.HeaderText = "郵便番号1";
            this.zip01DataGridViewTextBoxColumn.Name = "zip01DataGridViewTextBoxColumn";
            this.zip01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zip02DataGridViewTextBoxColumn
            // 
            this.zip02DataGridViewTextBoxColumn.DataPropertyName = "zip02";
            this.zip02DataGridViewTextBoxColumn.HeaderText = "郵便番号2";
            this.zip02DataGridViewTextBoxColumn.Name = "zip02DataGridViewTextBoxColumn";
            this.zip02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addr01DataGridViewTextBoxColumn
            // 
            this.addr01DataGridViewTextBoxColumn.DataPropertyName = "addr01";
            this.addr01DataGridViewTextBoxColumn.HeaderText = "住所1";
            this.addr01DataGridViewTextBoxColumn.Name = "addr01DataGridViewTextBoxColumn";
            this.addr01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addr02DataGridViewTextBoxColumn
            // 
            this.addr02DataGridViewTextBoxColumn.DataPropertyName = "addr02";
            this.addr02DataGridViewTextBoxColumn.HeaderText = "住所2";
            this.addr02DataGridViewTextBoxColumn.Name = "addr02DataGridViewTextBoxColumn";
            this.addr02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "メール";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "job";
            this.jobDataGridViewTextBoxColumn.DataSource = this.jobBindingSource;
            this.jobDataGridViewTextBoxColumn.DisplayMember = "name";
            this.jobDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.jobDataGridViewTextBoxColumn.HeaderText = "職業";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jobDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jobDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // tel01DataGridViewTextBoxColumn
            // 
            this.tel01DataGridViewTextBoxColumn.DataPropertyName = "tel01";
            this.tel01DataGridViewTextBoxColumn.HeaderText = "電話番号1";
            this.tel01DataGridViewTextBoxColumn.Name = "tel01DataGridViewTextBoxColumn";
            this.tel01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tel02DataGridViewTextBoxColumn
            // 
            this.tel02DataGridViewTextBoxColumn.DataPropertyName = "tel02";
            this.tel02DataGridViewTextBoxColumn.HeaderText = "電話番号2";
            this.tel02DataGridViewTextBoxColumn.Name = "tel02DataGridViewTextBoxColumn";
            this.tel02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tel03DataGridViewTextBoxColumn
            // 
            this.tel03DataGridViewTextBoxColumn.DataPropertyName = "tel03";
            this.tel03DataGridViewTextBoxColumn.HeaderText = "電話番号3";
            this.tel03DataGridViewTextBoxColumn.Name = "tel03DataGridViewTextBoxColumn";
            this.tel03DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.CustomerListGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCustomerList";
            this.Text = "顧客管理";
            this.Load += new System.EventHandler(this.frmCustomerList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView CustomerListGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource sexBindingSource;
        private System.Windows.Forms.BindingSource prefBindingSource;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kana01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kana02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn prefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel03DataGridViewTextBoxColumn;
    }
}

