namespace EccubeManager.frm
{
    partial class frmOrderList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OrderListGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderprefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.orderjobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordername01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordername02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderkana01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderkana02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertel01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertel02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertel03DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderzip01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderzip02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderaddr01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderaddr02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryfeetotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commitdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderListGridView
            // 
            this.OrderListGridView.AllowUserToAddRows = false;
            this.OrderListGridView.AllowUserToDeleteRows = false;
            this.OrderListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderListGridView.AutoGenerateColumns = false;
            this.OrderListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderdateDataGridViewTextBoxColumn,
            this.orderidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.orderprefDataGridViewTextBoxColumn,
            this.orderjobDataGridViewTextBoxColumn,
            this.paymentidDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.ordername01DataGridViewTextBoxColumn,
            this.ordername02DataGridViewTextBoxColumn,
            this.orderkana01DataGridViewTextBoxColumn,
            this.orderkana02DataGridViewTextBoxColumn,
            this.orderemailDataGridViewTextBoxColumn,
            this.ordertel01DataGridViewTextBoxColumn,
            this.ordertel02DataGridViewTextBoxColumn,
            this.ordertel03DataGridViewTextBoxColumn,
            this.orderzip01DataGridViewTextBoxColumn,
            this.orderzip02DataGridViewTextBoxColumn,
            this.orderaddr01DataGridViewTextBoxColumn,
            this.orderaddr02DataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.deliveryfeetotalDataGridViewTextBoxColumn,
            this.chargeDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paymenttotalDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.updatedateDataGridViewTextBoxColumn,
            this.commitdateDataGridViewTextBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn});
            this.OrderListGridView.DataSource = this.orderBindingSource;
            this.OrderListGridView.Location = new System.Drawing.Point(12, 116);
            this.OrderListGridView.Name = "OrderListGridView";
            this.OrderListGridView.ReadOnly = true;
            this.OrderListGridView.RowTemplate.Height = 21;
            this.OrderListGridView.Size = new System.Drawing.Size(680, 280);
            this.OrderListGridView.TabIndex = 0;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 98);
            this.tableLayoutPanel1.TabIndex = 1;
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
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(EccubeManager.Model.Master);
            // 
            // prefBindingSource
            // 
            this.prefBindingSource.DataSource = typeof(EccubeManager.Model.Master);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(EccubeManager.Model.Master);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(EccubeManager.Model.Order);
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "受注日";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "受注番号";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.statusBindingSource;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "name";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "受注状況";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "顧客番号";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderprefDataGridViewTextBoxColumn
            // 
            this.orderprefDataGridViewTextBoxColumn.DataPropertyName = "order_pref";
            this.orderprefDataGridViewTextBoxColumn.DataSource = this.prefBindingSource;
            this.orderprefDataGridViewTextBoxColumn.DisplayMember = "name";
            this.orderprefDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.orderprefDataGridViewTextBoxColumn.HeaderText = "都道府県";
            this.orderprefDataGridViewTextBoxColumn.Name = "orderprefDataGridViewTextBoxColumn";
            this.orderprefDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderprefDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderprefDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderprefDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // orderjobDataGridViewTextBoxColumn
            // 
            this.orderjobDataGridViewTextBoxColumn.DataPropertyName = "order_job";
            this.orderjobDataGridViewTextBoxColumn.DataSource = this.jobBindingSource;
            this.orderjobDataGridViewTextBoxColumn.DisplayMember = "name";
            this.orderjobDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.orderjobDataGridViewTextBoxColumn.HeaderText = "職業";
            this.orderjobDataGridViewTextBoxColumn.Name = "orderjobDataGridViewTextBoxColumn";
            this.orderjobDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderjobDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderjobDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderjobDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // paymentidDataGridViewTextBoxColumn
            // 
            this.paymentidDataGridViewTextBoxColumn.DataPropertyName = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.HeaderText = "支払ID";
            this.paymentidDataGridViewTextBoxColumn.Name = "paymentidDataGridViewTextBoxColumn";
            this.paymentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "メッセージ";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordername01DataGridViewTextBoxColumn
            // 
            this.ordername01DataGridViewTextBoxColumn.DataPropertyName = "order_name01";
            this.ordername01DataGridViewTextBoxColumn.HeaderText = "氏名1";
            this.ordername01DataGridViewTextBoxColumn.Name = "ordername01DataGridViewTextBoxColumn";
            this.ordername01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordername02DataGridViewTextBoxColumn
            // 
            this.ordername02DataGridViewTextBoxColumn.DataPropertyName = "order_name02";
            this.ordername02DataGridViewTextBoxColumn.HeaderText = "氏名2";
            this.ordername02DataGridViewTextBoxColumn.Name = "ordername02DataGridViewTextBoxColumn";
            this.ordername02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderkana01DataGridViewTextBoxColumn
            // 
            this.orderkana01DataGridViewTextBoxColumn.DataPropertyName = "order_kana01";
            this.orderkana01DataGridViewTextBoxColumn.HeaderText = "氏名1(カナ)";
            this.orderkana01DataGridViewTextBoxColumn.Name = "orderkana01DataGridViewTextBoxColumn";
            this.orderkana01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderkana02DataGridViewTextBoxColumn
            // 
            this.orderkana02DataGridViewTextBoxColumn.DataPropertyName = "order_kana02";
            this.orderkana02DataGridViewTextBoxColumn.HeaderText = "氏名2(カナ)";
            this.orderkana02DataGridViewTextBoxColumn.Name = "orderkana02DataGridViewTextBoxColumn";
            this.orderkana02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderemailDataGridViewTextBoxColumn
            // 
            this.orderemailDataGridViewTextBoxColumn.DataPropertyName = "order_email";
            this.orderemailDataGridViewTextBoxColumn.HeaderText = "メール";
            this.orderemailDataGridViewTextBoxColumn.Name = "orderemailDataGridViewTextBoxColumn";
            this.orderemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordertel01DataGridViewTextBoxColumn
            // 
            this.ordertel01DataGridViewTextBoxColumn.DataPropertyName = "order_tel01";
            this.ordertel01DataGridViewTextBoxColumn.HeaderText = "電話番号1";
            this.ordertel01DataGridViewTextBoxColumn.Name = "ordertel01DataGridViewTextBoxColumn";
            this.ordertel01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordertel02DataGridViewTextBoxColumn
            // 
            this.ordertel02DataGridViewTextBoxColumn.DataPropertyName = "order_tel02";
            this.ordertel02DataGridViewTextBoxColumn.HeaderText = "電話番号2";
            this.ordertel02DataGridViewTextBoxColumn.Name = "ordertel02DataGridViewTextBoxColumn";
            this.ordertel02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordertel03DataGridViewTextBoxColumn
            // 
            this.ordertel03DataGridViewTextBoxColumn.DataPropertyName = "order_tel03";
            this.ordertel03DataGridViewTextBoxColumn.HeaderText = "電話番号3";
            this.ordertel03DataGridViewTextBoxColumn.Name = "ordertel03DataGridViewTextBoxColumn";
            this.ordertel03DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderzip01DataGridViewTextBoxColumn
            // 
            this.orderzip01DataGridViewTextBoxColumn.DataPropertyName = "order_zip01";
            this.orderzip01DataGridViewTextBoxColumn.HeaderText = "郵便番号1";
            this.orderzip01DataGridViewTextBoxColumn.Name = "orderzip01DataGridViewTextBoxColumn";
            this.orderzip01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderzip02DataGridViewTextBoxColumn
            // 
            this.orderzip02DataGridViewTextBoxColumn.DataPropertyName = "order_zip02";
            this.orderzip02DataGridViewTextBoxColumn.HeaderText = "郵便番号2";
            this.orderzip02DataGridViewTextBoxColumn.Name = "orderzip02DataGridViewTextBoxColumn";
            this.orderzip02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderaddr01DataGridViewTextBoxColumn
            // 
            this.orderaddr01DataGridViewTextBoxColumn.DataPropertyName = "order_addr01";
            this.orderaddr01DataGridViewTextBoxColumn.HeaderText = "住所1";
            this.orderaddr01DataGridViewTextBoxColumn.Name = "orderaddr01DataGridViewTextBoxColumn";
            this.orderaddr01DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderaddr02DataGridViewTextBoxColumn
            // 
            this.orderaddr02DataGridViewTextBoxColumn.DataPropertyName = "order_addr02";
            this.orderaddr02DataGridViewTextBoxColumn.HeaderText = "住所2";
            this.orderaddr02DataGridViewTextBoxColumn.Name = "orderaddr02DataGridViewTextBoxColumn";
            this.orderaddr02DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "小計";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "割引";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryfeetotalDataGridViewTextBoxColumn
            // 
            this.deliveryfeetotalDataGridViewTextBoxColumn.DataPropertyName = "delivery_fee_total";
            this.deliveryfeetotalDataGridViewTextBoxColumn.HeaderText = "送料";
            this.deliveryfeetotalDataGridViewTextBoxColumn.Name = "deliveryfeetotalDataGridViewTextBoxColumn";
            this.deliveryfeetotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chargeDataGridViewTextBoxColumn
            // 
            this.chargeDataGridViewTextBoxColumn.DataPropertyName = "charge";
            this.chargeDataGridViewTextBoxColumn.HeaderText = "手数料";
            this.chargeDataGridViewTextBoxColumn.Name = "chargeDataGridViewTextBoxColumn";
            this.chargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "消費税";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            this.taxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "合計";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymenttotalDataGridViewTextBoxColumn
            // 
            this.paymenttotalDataGridViewTextBoxColumn.DataPropertyName = "payment_total";
            this.paymenttotalDataGridViewTextBoxColumn.HeaderText = "支払合計";
            this.paymenttotalDataGridViewTextBoxColumn.Name = "paymenttotalDataGridViewTextBoxColumn";
            this.paymenttotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "支払方法";
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            this.paymentmethodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "ノート";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedateDataGridViewTextBoxColumn
            // 
            this.updatedateDataGridViewTextBoxColumn.DataPropertyName = "update_date";
            this.updatedateDataGridViewTextBoxColumn.HeaderText = "更新日";
            this.updatedateDataGridViewTextBoxColumn.Name = "updatedateDataGridViewTextBoxColumn";
            this.updatedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commitdateDataGridViewTextBoxColumn
            // 
            this.commitdateDataGridViewTextBoxColumn.DataPropertyName = "commit_date";
            this.commitdateDataGridViewTextBoxColumn.HeaderText = "発送日";
            this.commitdateDataGridViewTextBoxColumn.Name = "commitdateDataGridViewTextBoxColumn";
            this.commitdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "入金日";
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            this.paymentdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.OrderListGridView);
            this.Name = "frmOrderList";
            this.Text = "受注管理";
            this.Load += new System.EventHandler(this.frmOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderListGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.BindingSource prefBindingSource;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn orderprefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn orderjobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordername01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordername02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderkana01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderkana02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertel01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertel02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertel03DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderzip01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderzip02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderaddr01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderaddr02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryfeetotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commitdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
    }
}