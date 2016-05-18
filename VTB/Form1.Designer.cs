namespace VTB
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartGroupBox = new System.Windows.Forms.GroupBox();
            this.OurChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.algoGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboAction = new System.Windows.Forms.ComboBox();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.axTws1 = new AxTWSLib.AxTws();
            this.btnReconnect = new System.Windows.Forms.Button();
            this.lblExchange = new System.Windows.Forms.Label();
            this.tbExchange = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.tbSymbol = new System.Windows.Forms.TextBox();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSmaTimeFrame = new System.Windows.Forms.TextBox();
            this.ddSmaOperator = new System.Windows.Forms.ComboBox();
            this.tbValSma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmaTimeFrame = new System.Windows.Forms.TextBox();
            this.ddEmaOperator = new System.Windows.Forms.ComboBox();
            this.tbValEma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRsiTimeFrame = new System.Windows.Forms.TextBox();
            this.ddRsiOperator = new System.Windows.Forms.ComboBox();
            this.tbValRsi = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.chartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OurChart)).BeginInit();
            this.algoGroupBox.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTws1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exchangeToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // exchangeToolStripMenuItem
            // 
            this.exchangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sMARTToolStripMenuItem});
            this.exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            this.exchangeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exchangeToolStripMenuItem.Text = "Exchange";
            // 
            // sMARTToolStripMenuItem
            // 
            this.sMARTToolStripMenuItem.Checked = true;
            this.sMARTToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sMARTToolStripMenuItem.Name = "sMARTToolStripMenuItem";
            this.sMARTToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.sMARTToolStripMenuItem.Text = "SMART";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // chartGroupBox
            // 
            this.chartGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartGroupBox.Controls.Add(this.OurChart);
            this.chartGroupBox.Location = new System.Drawing.Point(13, 96);
            this.chartGroupBox.Name = "chartGroupBox";
            this.chartGroupBox.Size = new System.Drawing.Size(491, 357);
            this.chartGroupBox.TabIndex = 1;
            this.chartGroupBox.TabStop = false;
            this.chartGroupBox.Text = "Chart";
            // 
            // OurChart
            // 
            this.OurChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.OurChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.OurChart.Legends.Add(legend2);
            this.OurChart.Location = new System.Drawing.Point(7, 20);
            this.OurChart.Name = "OurChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Price";
            this.OurChart.Series.Add(series2);
            this.OurChart.Size = new System.Drawing.Size(478, 331);
            this.OurChart.TabIndex = 0;
            this.OurChart.Text = "chart1";
            // 
            // algoGroupBox
            // 
            this.algoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.algoGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.algoGroupBox.Controls.Add(this.tbQuantity);
            this.algoGroupBox.Controls.Add(this.label4);
            this.algoGroupBox.Controls.Add(this.label3);
            this.algoGroupBox.Controls.Add(this.label2);
            this.algoGroupBox.Controls.Add(this.tbOrderId);
            this.algoGroupBox.Controls.Add(this.btnSubmit);
            this.algoGroupBox.Controls.Add(this.label1);
            this.algoGroupBox.Controls.Add(this.comboAction);
            this.algoGroupBox.Location = new System.Drawing.Point(510, 96);
            this.algoGroupBox.Name = "algoGroupBox";
            this.algoGroupBox.Size = new System.Drawing.Size(448, 511);
            this.algoGroupBox.TabIndex = 2;
            this.algoGroupBox.TabStop = false;
            this.algoGroupBox.Text = "Algorithm";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(367, 471);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IF:";
            // 
            // comboAction
            // 
            this.comboAction.CausesValidation = false;
            this.comboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAction.FormattingEnabled = true;
            this.comboAction.Items.AddRange(new object[] {
            "BUY",
            "SELL"});
            this.comboAction.Location = new System.Drawing.Point(62, 20);
            this.comboAction.Name = "comboAction";
            this.comboAction.Size = new System.Drawing.Size(121, 21);
            this.comboAction.TabIndex = 0;
            // 
            // logGroupBox
            // 
            this.logGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logGroupBox.Controls.Add(this.listBox1);
            this.logGroupBox.Location = new System.Drawing.Point(13, 459);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(491, 148);
            this.logGroupBox.TabIndex = 3;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(478, 121);
            this.listBox1.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(12, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 63);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Maroon;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(93, 27);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(98, 63);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // axTws1
            // 
            this.axTws1.Enabled = true;
            this.axTws1.Location = new System.Drawing.Point(197, 27);
            this.axTws1.Name = "axTws1";
            this.axTws1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTws1.OcxState")));
            this.axTws1.Size = new System.Drawing.Size(133, 18);
            this.axTws1.TabIndex = 6;
            this.axTws1.tickPrice += new AxTWSLib._DTwsEvents_tickPriceEventHandler(this.axTws1_tickPrice);
            // 
            // btnReconnect
            // 
            this.btnReconnect.Location = new System.Drawing.Point(222, 66);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(75, 23);
            this.btnReconnect.TabIndex = 7;
            this.btnReconnect.Text = "Reconnect";
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // lblExchange
            // 
            this.lblExchange.AutoSize = true;
            this.lblExchange.Location = new System.Drawing.Point(341, 9);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(55, 13);
            this.lblExchange.TabIndex = 8;
            this.lblExchange.Text = "Exchange";
            // 
            // tbExchange
            // 
            this.tbExchange.Location = new System.Drawing.Point(398, 4);
            this.tbExchange.Name = "tbExchange";
            this.tbExchange.Size = new System.Drawing.Size(100, 20);
            this.tbExchange.TabIndex = 9;
            this.tbExchange.Text = "NASDAQ";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(569, 9);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(72, 13);
            this.lblSymbol.TabIndex = 10;
            this.lblSymbol.Text = "Stock Symbol";
            // 
            // tbSymbol
            // 
            this.tbSymbol.Location = new System.Drawing.Point(648, 6);
            this.tbSymbol.Name = "tbSymbol";
            this.tbSymbol.Size = new System.Drawing.Size(100, 20);
            this.tbSymbol.TabIndex = 11;
            this.tbSymbol.Text = "MSFT";
            // 
            // tbOrderId
            // 
            this.tbOrderId.Location = new System.Drawing.Point(261, 471);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(100, 20);
            this.tbOrderId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Order ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Action:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantity:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(62, 47);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(121, 20);
            this.tbQuantity.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "SMA";
            // 
            // tbSmaTimeFrame
            // 
            this.tbSmaTimeFrame.Location = new System.Drawing.Point(100, 28);
            this.tbSmaTimeFrame.Name = "tbSmaTimeFrame";
            this.tbSmaTimeFrame.Size = new System.Drawing.Size(50, 20);
            this.tbSmaTimeFrame.TabIndex = 24;
            // 
            // ddSmaOperator
            // 
            this.ddSmaOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSmaOperator.FormattingEnabled = true;
            this.ddSmaOperator.Items.AddRange(new object[] {
            "",
            "<",
            "<=",
            ">",
            ">="});
            this.ddSmaOperator.Location = new System.Drawing.Point(228, 28);
            this.ddSmaOperator.Name = "ddSmaOperator";
            this.ddSmaOperator.Size = new System.Drawing.Size(67, 21);
            this.ddSmaOperator.TabIndex = 25;
            // 
            // tbValSma
            // 
            this.tbValSma.Location = new System.Drawing.Point(326, 28);
            this.tbValSma.Name = "tbValSma";
            this.tbValSma.Size = new System.Drawing.Size(100, 20);
            this.tbValSma.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "EMA";
            // 
            // tbEmaTimeFrame
            // 
            this.tbEmaTimeFrame.Location = new System.Drawing.Point(100, 63);
            this.tbEmaTimeFrame.Name = "tbEmaTimeFrame";
            this.tbEmaTimeFrame.Size = new System.Drawing.Size(50, 20);
            this.tbEmaTimeFrame.TabIndex = 28;
            // 
            // ddEmaOperator
            // 
            this.ddEmaOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddEmaOperator.FormattingEnabled = true;
            this.ddEmaOperator.Items.AddRange(new object[] {
            "",
            "<",
            "<=",
            ">",
            ">="});
            this.ddEmaOperator.Location = new System.Drawing.Point(228, 63);
            this.ddEmaOperator.Name = "ddEmaOperator";
            this.ddEmaOperator.Size = new System.Drawing.Size(67, 21);
            this.ddEmaOperator.TabIndex = 29;
            // 
            // tbValEma
            // 
            this.tbValEma.Location = new System.Drawing.Point(326, 63);
            this.tbValEma.Name = "tbValEma";
            this.tbValEma.Size = new System.Drawing.Size(100, 20);
            this.tbValEma.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Indicator";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbValEma, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ddEmaOperator, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbSmaTimeFrame, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbEmaTimeFrame, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ddSmaOperator, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbValSma, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbRsiTimeFrame, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ddRsiOperator, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbValRsi, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.38462F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.61538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(436, 235);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Time Frame";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Operator";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "RSI";
            // 
            // tbRsiTimeFrame
            // 
            this.tbRsiTimeFrame.Location = new System.Drawing.Point(100, 96);
            this.tbRsiTimeFrame.Name = "tbRsiTimeFrame";
            this.tbRsiTimeFrame.Size = new System.Drawing.Size(50, 20);
            this.tbRsiTimeFrame.TabIndex = 36;
            // 
            // ddRsiOperator
            // 
            this.ddRsiOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddRsiOperator.FormattingEnabled = true;
            this.ddRsiOperator.Items.AddRange(new object[] {
            "",
            "<",
            "<=",
            ">",
            ">="});
            this.ddRsiOperator.Location = new System.Drawing.Point(228, 96);
            this.ddRsiOperator.Name = "ddRsiOperator";
            this.ddRsiOperator.Size = new System.Drawing.Size(67, 21);
            this.ddRsiOperator.TabIndex = 37;
            // 
            // tbValRsi
            // 
            this.tbValRsi.Location = new System.Drawing.Point(326, 96);
            this.tbValRsi.Name = "tbValRsi";
            this.tbValRsi.Size = new System.Drawing.Size(100, 20);
            this.tbValRsi.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 619);
            this.Controls.Add(this.tbSymbol);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.tbExchange);
            this.Controls.Add(this.lblExchange);
            this.Controls.Add(this.btnReconnect);
            this.Controls.Add(this.axTws1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.algoGroupBox);
            this.Controls.Add(this.chartGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Virtual Trading Booth";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.chartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OurChart)).EndInit();
            this.algoGroupBox.ResumeLayout(false);
            this.algoGroupBox.PerformLayout();
            this.logGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTws1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox chartGroupBox;
        private System.Windows.Forms.GroupBox algoGroupBox;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataVisualization.Charting.Chart OurChart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private AxTWSLib.AxTws axTws1;
        private System.Windows.Forms.ComboBox comboAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolStripMenuItem exchangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMARTToolStripMenuItem;
        private System.Windows.Forms.Button btnReconnect;
        private System.Windows.Forms.Label lblExchange;
        private System.Windows.Forms.TextBox tbExchange;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox tbSymbol;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.TextBox tbValSma;
        private System.Windows.Forms.ComboBox ddSmaOperator;
        private System.Windows.Forms.TextBox tbSmaTimeFrame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbValEma;
        private System.Windows.Forms.ComboBox ddEmaOperator;
        private System.Windows.Forms.TextBox tbEmaTimeFrame;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRsiTimeFrame;
        private System.Windows.Forms.ComboBox ddRsiOperator;
        private System.Windows.Forms.TextBox tbValRsi;
    }
}

