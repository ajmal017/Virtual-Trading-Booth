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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nASDAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nYSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartGroupBox = new System.Windows.Forms.GroupBox();
            this.OurChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.algoGroupBox = new System.Windows.Forms.GroupBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbAction = new System.Windows.Forms.TextBox();
            this.tbOrderType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLimitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nbTimeFrame = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboStrategy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbBars = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.chtStocks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axTws1 = new AxTWSLib.AxTws();
            this.btnReconnect = new System.Windows.Forms.Button();
            this.lblExchange = new System.Windows.Forms.Label();
            this.tbPrimaryExchange = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.tbSymbol = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.chartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OurChart)).BeginInit();
            this.algoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbTimeFrame)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtStocks)).BeginInit();
            this.logGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTws1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.sMARTToolStripMenuItem,
            this.nASDAQToolStripMenuItem,
            this.nYSEToolStripMenuItem});
            this.exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            this.exchangeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exchangeToolStripMenuItem.Text = "Exchange";
            // 
            // sMARTToolStripMenuItem
            // 
            this.sMARTToolStripMenuItem.Checked = true;
            this.sMARTToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sMARTToolStripMenuItem.Name = "sMARTToolStripMenuItem";
            this.sMARTToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sMARTToolStripMenuItem.Text = "SMART";
            // 
            // nASDAQToolStripMenuItem
            // 
            this.nASDAQToolStripMenuItem.Name = "nASDAQToolStripMenuItem";
            this.nASDAQToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.nASDAQToolStripMenuItem.Text = "NASDAQ";
            // 
            // nYSEToolStripMenuItem
            // 
            this.nYSEToolStripMenuItem.Name = "nYSEToolStripMenuItem";
            this.nYSEToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.nYSEToolStripMenuItem.Text = "NYSE";
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
            this.chartGroupBox.Location = new System.Drawing.Point(13, 48);
            this.chartGroupBox.Name = "chartGroupBox";
            this.chartGroupBox.Size = new System.Drawing.Size(491, 405);
            this.chartGroupBox.TabIndex = 1;
            this.chartGroupBox.TabStop = false;
            this.chartGroupBox.Text = "Chart";
            // 
            // OurChart
            // 
            this.OurChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.OurChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.OurChart.Legends.Add(legend5);
            this.OurChart.Location = new System.Drawing.Point(7, 20);
            this.OurChart.Name = "OurChart";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Price";
            series10.BorderColor = System.Drawing.Color.Red;
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.Name = "SMA-20 D";
            series11.BorderColor = System.Drawing.Color.Black;
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Black;
            series11.Legend = "Legend1";
            series11.Name = "EMA-20 D";
            this.OurChart.Series.Add(series9);
            this.OurChart.Series.Add(series10);
            this.OurChart.Series.Add(series11);
            this.OurChart.Size = new System.Drawing.Size(478, 379);
            this.OurChart.TabIndex = 0;
            this.OurChart.Text = "chart1";
            this.OurChart.Click += new System.EventHandler(this.OurChart_Click);
            // 
            // algoGroupBox
            // 
            this.algoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.algoGroupBox.Controls.Add(this.tbQuantity);
            this.algoGroupBox.Controls.Add(this.tbAction);
            this.algoGroupBox.Controls.Add(this.tbOrderType);
            this.algoGroupBox.Controls.Add(this.label7);
            this.algoGroupBox.Controls.Add(this.tbLimitPrice);
            this.algoGroupBox.Controls.Add(this.label6);
            this.algoGroupBox.Controls.Add(this.label5);
            this.algoGroupBox.Controls.Add(this.tbOrderId);
            this.algoGroupBox.Controls.Add(this.label4);
            this.algoGroupBox.Controls.Add(this.label2);
            this.algoGroupBox.Controls.Add(this.nbTimeFrame);
            this.algoGroupBox.Controls.Add(this.groupBox1);
            this.algoGroupBox.Controls.Add(this.btnSubmit);
            this.algoGroupBox.Controls.Add(this.label1);
            this.algoGroupBox.Controls.Add(this.comboStrategy);
            this.algoGroupBox.Controls.Add(this.label3);
            this.algoGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.algoGroupBox.Location = new System.Drawing.Point(510, 319);
            this.algoGroupBox.Name = "algoGroupBox";
            this.algoGroupBox.Size = new System.Drawing.Size(448, 288);
            this.algoGroupBox.TabIndex = 2;
            this.algoGroupBox.TabStop = false;
            this.algoGroupBox.Text = "Algorithm";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(292, 20);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(120, 20);
            this.tbQuantity.TabIndex = 40;
            this.tbQuantity.Click += new System.EventHandler(this.tbQuantity_Click);
            // 
            // tbAction
            // 
            this.tbAction.Location = new System.Drawing.Point(292, 73);
            this.tbAction.Name = "tbAction";
            this.tbAction.Size = new System.Drawing.Size(120, 20);
            this.tbAction.TabIndex = 39;
            this.tbAction.Text = "BUY";
            this.tbAction.Click += new System.EventHandler(this.tbAction_Click);
            // 
            // tbOrderType
            // 
            this.tbOrderType.Location = new System.Drawing.Point(293, 126);
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.Size = new System.Drawing.Size(119, 20);
            this.tbOrderType.TabIndex = 38;
            this.tbOrderType.Click += new System.EventHandler(this.tbOrderType_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Order Type";
            // 
            // tbLimitPrice
            // 
            this.tbLimitPrice.Location = new System.Drawing.Point(292, 99);
            this.tbLimitPrice.Name = "tbLimitPrice";
            this.tbLimitPrice.Size = new System.Drawing.Size(120, 20);
            this.tbLimitPrice.TabIndex = 35;
            this.tbLimitPrice.Click += new System.EventHandler(this.tbLimitPrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Limit Price*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Action";
            // 
            // tbOrderId
            // 
            this.tbOrderId.Location = new System.Drawing.Point(292, 46);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.Size = new System.Drawing.Size(120, 20);
            this.tbOrderId.TabIndex = 31;
            this.tbOrderId.Click += new System.EventHandler(this.tbOrderId_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantity";
            // 
            // nbTimeFrame
            // 
            this.nbTimeFrame.Location = new System.Drawing.Point(78, 50);
            this.nbTimeFrame.Name = "nbTimeFrame";
            this.nbTimeFrame.Size = new System.Drawing.Size(133, 20);
            this.nbTimeFrame.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Location = new System.Drawing.Point(6, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 84);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(6, 19);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(424, 59);
            this.tbDescription.TabIndex = 0;
            this.tbDescription.Text = "Summary of strategy will appear here once selected.";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(332, 152);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Time Frame";
            // 
            // comboStrategy
            // 
            this.comboStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStrategy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStrategy.FormattingEnabled = true;
            this.comboStrategy.Items.AddRange(new object[] {
            "SMA Crossover",
            "SMA Crossunder",
            "EMA Crossover",
            "EMA Crossunder",
            "RSI Over Sold",
            "RSI Over Bought"});
            this.comboStrategy.Location = new System.Drawing.Point(78, 20);
            this.comboStrategy.Name = "comboStrategy";
            this.comboStrategy.Size = new System.Drawing.Size(133, 24);
            this.comboStrategy.TabIndex = 21;
            this.comboStrategy.SelectedIndexChanged += new System.EventHandler(this.comboStrategy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Strategy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Duration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Bars";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "End Date / Time";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(43, 18);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(51, 20);
            this.tbDuration.TabIndex = 44;
            this.tbDuration.Text = "1 M";
            // 
            // tbBars
            // 
            this.tbBars.Location = new System.Drawing.Point(176, 18);
            this.tbBars.Name = "tbBars";
            this.tbBars.Size = new System.Drawing.Size(51, 20);
            this.tbBars.TabIndex = 43;
            this.tbBars.Text = "1 Day";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(336, 18);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(88, 20);
            this.tbDate.TabIndex = 42;
            this.tbDate.Text = "20160429 16:00:00";
            // 
            // chtStocks
            // 
            chartArea6.Name = "ChartArea1";
            this.chtStocks.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chtStocks.Legends.Add(legend6);
            this.chtStocks.Location = new System.Drawing.Point(6, 44);
            this.chtStocks.Name = "chtStocks";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Closing Prices";
            this.chtStocks.Series.Add(series12);
            this.chtStocks.Size = new System.Drawing.Size(436, 207);
            this.chtStocks.TabIndex = 41;
            this.chtStocks.Text = "chart1";
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
            // axTws1
            // 
            this.axTws1.Enabled = true;
            this.axTws1.Location = new System.Drawing.Point(823, 5);
            this.axTws1.Name = "axTws1";
            this.axTws1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTws1.OcxState")));
            this.axTws1.Size = new System.Drawing.Size(135, 19);
            this.axTws1.TabIndex = 6;
            this.axTws1.tickPrice += new AxTWSLib._DTwsEvents_tickPriceEventHandler(this.axTws1_tickPrice);
            this.axTws1.historicalData += new AxTWSLib._DTwsEvents_historicalDataEventHandler(this.axTws1_historicalData);
            this.axTws1.realtimeBar += new AxTWSLib._DTwsEvents_realtimeBarEventHandler(this.axTws1_realtimeBar);
            // 
            // btnReconnect
            // 
            this.btnReconnect.Location = new System.Drawing.Point(643, 5);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(75, 20);
            this.btnReconnect.TabIndex = 7;
            this.btnReconnect.Text = "GO";
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // lblExchange
            // 
            this.lblExchange.AutoSize = true;
            this.lblExchange.Location = new System.Drawing.Point(189, 6);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(92, 13);
            this.lblExchange.TabIndex = 8;
            this.lblExchange.Text = "Primary Exchange";
            // 
            // tbPrimaryExchange
            // 
            this.tbPrimaryExchange.Location = new System.Drawing.Point(287, 3);
            this.tbPrimaryExchange.Name = "tbPrimaryExchange";
            this.tbPrimaryExchange.Size = new System.Drawing.Size(100, 20);
            this.tbPrimaryExchange.TabIndex = 9;
            this.tbPrimaryExchange.Text = "NASDAQ";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(459, 8);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(72, 13);
            this.lblSymbol.TabIndex = 10;
            this.lblSymbol.Text = "Stock Symbol";
            // 
            // tbSymbol
            // 
            this.tbSymbol.Location = new System.Drawing.Point(537, 5);
            this.tbSymbol.Name = "tbSymbol";
            this.tbSymbol.Size = new System.Drawing.Size(100, 20);
            this.tbSymbol.TabIndex = 11;
            this.tbSymbol.Text = "MSFT";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chtStocks);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbDate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbBars);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbDuration);
            this.groupBox2.Location = new System.Drawing.Point(510, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historical Chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.axTws1);
            this.Controls.Add(this.tbSymbol);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.tbPrimaryExchange);
            this.Controls.Add(this.lblExchange);
            this.Controls.Add(this.btnReconnect);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.algoGroupBox);
            this.Controls.Add(this.chartGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Virtual Trading Booth";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.chartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OurChart)).EndInit();
            this.algoGroupBox.ResumeLayout(false);
            this.algoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbTimeFrame)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtStocks)).EndInit();
            this.logGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTws1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart OurChart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private AxTWSLib.AxTws axTws1;
        private System.Windows.Forms.ToolStripMenuItem exchangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMARTToolStripMenuItem;
        private System.Windows.Forms.Button btnReconnect;
        private System.Windows.Forms.Label lblExchange;
        private System.Windows.Forms.TextBox tbPrimaryExchange;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox tbSymbol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboStrategy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nbTimeFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLimitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOrderType;
        private System.Windows.Forms.TextBox tbAction;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.ToolStripMenuItem nASDAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nYSEToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtStocks;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbBars;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

