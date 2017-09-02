namespace EccubeManager
{
    partial class frmHome
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
            this.SalesGroupBox = new System.Windows.Forms.GroupBox();
            this.YesterdayGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAmountOfYesterday = new System.Windows.Forms.Label();
            this.lblCountOfYesterday = new System.Windows.Forms.Label();
            this.TodayGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmountOfToday = new System.Windows.Forms.Label();
            this.lblCountOfToday = new System.Windows.Forms.Label();
            this.MonthGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmountOfMonth = new System.Windows.Forms.Label();
            this.lblCountOfMonth = new System.Windows.Forms.Label();
            this.MenuGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.OrderStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderStatusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNewOrder = new System.Windows.Forms.Label();
            this.lblPendingOrder = new System.Windows.Forms.Label();
            this.lblPaidOrder = new System.Windows.Forms.Label();
            this.lblBackOrder = new System.Windows.Forms.Label();
            this.ShopInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.SalesGroupBox.SuspendLayout();
            this.YesterdayGroupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.TodayGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.MonthGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MenuGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.OrderStatusGroupBox.SuspendLayout();
            this.OrderStatusPanel.SuspendLayout();
            this.ShopInfoGroupBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Controls.Add(this.YesterdayGroupBox);
            this.SalesGroupBox.Controls.Add(this.TodayGroupBox);
            this.SalesGroupBox.Controls.Add(this.MonthGroupBox);
            this.SalesGroupBox.Location = new System.Drawing.Point(303, 56);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Size = new System.Drawing.Size(208, 257);
            this.SalesGroupBox.TabIndex = 0;
            this.SalesGroupBox.TabStop = false;
            this.SalesGroupBox.Text = "売り上げ状況";
            // 
            // YesterdayGroupBox
            // 
            this.YesterdayGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.YesterdayGroupBox.Location = new System.Drawing.Point(10, 173);
            this.YesterdayGroupBox.Name = "YesterdayGroupBox";
            this.YesterdayGroupBox.Size = new System.Drawing.Size(184, 71);
            this.YesterdayGroupBox.TabIndex = 0;
            this.YesterdayGroupBox.TabStop = false;
            this.YesterdayGroupBox.Text = "昨日";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblAmountOfYesterday, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCountOfYesterday, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(178, 53);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "昨日の売上高：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "売上件数：";
            // 
            // lblAmountOfYesterday
            // 
            this.lblAmountOfYesterday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmountOfYesterday.AutoSize = true;
            this.lblAmountOfYesterday.Location = new System.Drawing.Point(92, 7);
            this.lblAmountOfYesterday.Name = "lblAmountOfYesterday";
            this.lblAmountOfYesterday.Size = new System.Drawing.Size(49, 12);
            this.lblAmountOfYesterday.TabIndex = 0;
            this.lblAmountOfYesterday.Text = "\\100,000";
            // 
            // lblCountOfYesterday
            // 
            this.lblCountOfYesterday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCountOfYesterday.AutoSize = true;
            this.lblCountOfYesterday.Location = new System.Drawing.Point(92, 33);
            this.lblCountOfYesterday.Name = "lblCountOfYesterday";
            this.lblCountOfYesterday.Size = new System.Drawing.Size(41, 12);
            this.lblCountOfYesterday.TabIndex = 0;
            this.lblCountOfYesterday.Text = "1000件";
            // 
            // TodayGroupBox
            // 
            this.TodayGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.TodayGroupBox.Location = new System.Drawing.Point(10, 96);
            this.TodayGroupBox.Name = "TodayGroupBox";
            this.TodayGroupBox.Size = new System.Drawing.Size(184, 71);
            this.TodayGroupBox.TabIndex = 0;
            this.TodayGroupBox.TabStop = false;
            this.TodayGroupBox.Text = "今日";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblAmountOfToday, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCountOfToday, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(178, 53);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "今日の売上高：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "売上件数：";
            // 
            // lblAmountOfToday
            // 
            this.lblAmountOfToday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmountOfToday.AutoSize = true;
            this.lblAmountOfToday.Location = new System.Drawing.Point(92, 7);
            this.lblAmountOfToday.Name = "lblAmountOfToday";
            this.lblAmountOfToday.Size = new System.Drawing.Size(49, 12);
            this.lblAmountOfToday.TabIndex = 0;
            this.lblAmountOfToday.Text = "\\100,000";
            // 
            // lblCountOfToday
            // 
            this.lblCountOfToday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCountOfToday.AutoSize = true;
            this.lblCountOfToday.Location = new System.Drawing.Point(92, 33);
            this.lblCountOfToday.Name = "lblCountOfToday";
            this.lblCountOfToday.Size = new System.Drawing.Size(41, 12);
            this.lblCountOfToday.TabIndex = 0;
            this.lblCountOfToday.Text = "1000件";
            // 
            // MonthGroupBox
            // 
            this.MonthGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.MonthGroupBox.Location = new System.Drawing.Point(10, 19);
            this.MonthGroupBox.Name = "MonthGroupBox";
            this.MonthGroupBox.Size = new System.Drawing.Size(184, 71);
            this.MonthGroupBox.TabIndex = 0;
            this.MonthGroupBox.TabStop = false;
            this.MonthGroupBox.Text = "今月";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAmountOfMonth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCountOfMonth, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(178, 53);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "今月の売上高：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "売上件数：";
            // 
            // lblAmountOfMonth
            // 
            this.lblAmountOfMonth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmountOfMonth.AutoSize = true;
            this.lblAmountOfMonth.Location = new System.Drawing.Point(92, 7);
            this.lblAmountOfMonth.Name = "lblAmountOfMonth";
            this.lblAmountOfMonth.Size = new System.Drawing.Size(49, 12);
            this.lblAmountOfMonth.TabIndex = 0;
            this.lblAmountOfMonth.Text = "\\100,000";
            // 
            // lblCountOfMonth
            // 
            this.lblCountOfMonth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCountOfMonth.AutoSize = true;
            this.lblCountOfMonth.Location = new System.Drawing.Point(92, 33);
            this.lblCountOfMonth.Name = "lblCountOfMonth";
            this.lblCountOfMonth.Size = new System.Drawing.Size(41, 12);
            this.lblCountOfMonth.TabIndex = 0;
            this.lblCountOfMonth.Text = "1000件";
            // 
            // MenuGroupBox
            // 
            this.MenuGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.MenuGroupBox.Location = new System.Drawing.Point(13, 13);
            this.MenuGroupBox.Name = "MenuGroupBox";
            this.MenuGroupBox.Size = new System.Drawing.Size(99, 121);
            this.MenuGroupBox.TabIndex = 1;
            this.MenuGroupBox.TabStop = false;
            this.MenuGroupBox.Text = "メニュー";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnCustomer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOrder, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(93, 103);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(87, 19);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "顧客管理";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.Location = new System.Drawing.Point(3, 28);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(87, 19);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "受注管理";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // OrderStatusGroupBox
            // 
            this.OrderStatusGroupBox.Controls.Add(this.OrderStatusPanel);
            this.OrderStatusGroupBox.Location = new System.Drawing.Point(130, 56);
            this.OrderStatusGroupBox.Name = "OrderStatusGroupBox";
            this.OrderStatusGroupBox.Size = new System.Drawing.Size(167, 121);
            this.OrderStatusGroupBox.TabIndex = 0;
            this.OrderStatusGroupBox.TabStop = false;
            this.OrderStatusGroupBox.Text = "受注状況";
            // 
            // OrderStatusPanel
            // 
            this.OrderStatusPanel.ColumnCount = 2;
            this.OrderStatusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderStatusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderStatusPanel.Controls.Add(this.label15, 0, 0);
            this.OrderStatusPanel.Controls.Add(this.label16, 0, 1);
            this.OrderStatusPanel.Controls.Add(this.label5, 0, 2);
            this.OrderStatusPanel.Controls.Add(this.label6, 0, 3);
            this.OrderStatusPanel.Controls.Add(this.lblNewOrder, 1, 0);
            this.OrderStatusPanel.Controls.Add(this.lblPendingOrder, 1, 1);
            this.OrderStatusPanel.Controls.Add(this.lblPaidOrder, 1, 2);
            this.OrderStatusPanel.Controls.Add(this.lblBackOrder, 1, 3);
            this.OrderStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderStatusPanel.Location = new System.Drawing.Point(3, 15);
            this.OrderStatusPanel.Name = "OrderStatusPanel";
            this.OrderStatusPanel.RowCount = 4;
            this.OrderStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.OrderStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.OrderStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.OrderStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.OrderStatusPanel.Size = new System.Drawing.Size(161, 103);
            this.OrderStatusPanel.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "新規受付：";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "入金待ち：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "入金済み：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "取り寄せ中：";
            // 
            // lblNewOrder
            // 
            this.lblNewOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNewOrder.AutoSize = true;
            this.lblNewOrder.Location = new System.Drawing.Point(83, 6);
            this.lblNewOrder.Name = "lblNewOrder";
            this.lblNewOrder.Size = new System.Drawing.Size(41, 12);
            this.lblNewOrder.TabIndex = 0;
            this.lblNewOrder.Text = "1000件";
            // 
            // lblPendingOrder
            // 
            this.lblPendingOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPendingOrder.AutoSize = true;
            this.lblPendingOrder.Location = new System.Drawing.Point(83, 31);
            this.lblPendingOrder.Name = "lblPendingOrder";
            this.lblPendingOrder.Size = new System.Drawing.Size(41, 12);
            this.lblPendingOrder.TabIndex = 0;
            this.lblPendingOrder.Text = "1000件";
            // 
            // lblPaidOrder
            // 
            this.lblPaidOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPaidOrder.AutoSize = true;
            this.lblPaidOrder.Location = new System.Drawing.Point(83, 56);
            this.lblPaidOrder.Name = "lblPaidOrder";
            this.lblPaidOrder.Size = new System.Drawing.Size(41, 12);
            this.lblPaidOrder.TabIndex = 0;
            this.lblPaidOrder.Text = "1000件";
            // 
            // lblBackOrder
            // 
            this.lblBackOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBackOrder.AutoSize = true;
            this.lblBackOrder.Location = new System.Drawing.Point(83, 83);
            this.lblBackOrder.Name = "lblBackOrder";
            this.lblBackOrder.Size = new System.Drawing.Size(41, 12);
            this.lblBackOrder.TabIndex = 0;
            this.lblBackOrder.Text = "1000件";
            // 
            // ShopInfoGroupBox
            // 
            this.ShopInfoGroupBox.Controls.Add(this.tableLayoutPanel5);
            this.ShopInfoGroupBox.Location = new System.Drawing.Point(517, 56);
            this.ShopInfoGroupBox.Name = "ShopInfoGroupBox";
            this.ShopInfoGroupBox.Size = new System.Drawing.Size(167, 53);
            this.ShopInfoGroupBox.TabIndex = 0;
            this.ShopInfoGroupBox.TabStop = false;
            this.ShopInfoGroupBox.Text = "ショップ状況";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblCustomerCount, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(161, 35);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "会員数：";
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Location = new System.Drawing.Point(83, 11);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(49, 12);
            this.lblCustomerCount.TabIndex = 0;
            this.lblCustomerCount.Text = "10,000人";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(13, 246);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "設定";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblUpdateDate, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(133, 13);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(269, 24);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "更新時刻:";
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUpdateDate.AutoSize = true;
            this.lblUpdateDate.Location = new System.Drawing.Point(111, 6);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(89, 12);
            this.lblUpdateDate.TabIndex = 1;
            this.lblUpdateDate.Text = "****年**月**日";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 406);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.MenuGroupBox);
            this.Controls.Add(this.ShopInfoGroupBox);
            this.Controls.Add(this.OrderStatusGroupBox);
            this.Controls.Add(this.SalesGroupBox);
            this.Name = "frmHome";
            this.Text = "ECCUBE管理画面";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.SalesGroupBox.ResumeLayout(false);
            this.YesterdayGroupBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.TodayGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.MonthGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MenuGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.OrderStatusGroupBox.ResumeLayout(false);
            this.OrderStatusPanel.ResumeLayout(false);
            this.OrderStatusPanel.PerformLayout();
            this.ShopInfoGroupBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SalesGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmountOfMonth;
        private System.Windows.Forms.Label lblCountOfMonth;
        private System.Windows.Forms.GroupBox MenuGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.GroupBox YesterdayGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAmountOfYesterday;
        private System.Windows.Forms.Label lblCountOfYesterday;
        private System.Windows.Forms.GroupBox TodayGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmountOfToday;
        private System.Windows.Forms.Label lblCountOfToday;
        private System.Windows.Forms.GroupBox MonthGroupBox;
        private System.Windows.Forms.GroupBox OrderStatusGroupBox;
        private System.Windows.Forms.TableLayoutPanel OrderStatusPanel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNewOrder;
        private System.Windows.Forms.Label lblPendingOrder;
        private System.Windows.Forms.Label lblPaidOrder;
        private System.Windows.Forms.Label lblBackOrder;
        private System.Windows.Forms.GroupBox ShopInfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUpdateDate;
    }
}