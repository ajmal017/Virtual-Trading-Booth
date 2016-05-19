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
            this.tbLimitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboAction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nbQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nbTimeFrame = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboStrategy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.axTws1 = new AxTWSLib.AxTws();
            this.btnReconnect = new System.Windows.Forms.Button();
            this.lblExchange = new System.Windows.Forms.Label();
            this.tbPrimaryExchange = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.tbSymbol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboOrderType = new System.Windows.Forms.ComboBox();
            this.tbOrderType = new System.Windows.Forms.TextBox();
            this.tbAction = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.nASDAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nYSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.chartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OurChart)).BeginInit();
            this.algoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTimeFrame)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTws1)).BeginInit();
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
            this.exchangeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.algoGroupBox.Controls.Add(this.tbQuantity);
            this.algoGroupBox.Controls.Add(this.tbAction);
            this.algoGroupBox.Controls.Add(this.tbOrderType);
            this.algoGroupBox.Controls.Add(this.comboOrderType);
            this.algoGroupBox.Controls.Add(this.label7);
            this.algoGroupBox.Controls.Add(this.tbLimitPrice);
            this.algoGroupBox.Controls.Add(this.label6);
            this.algoGroupBox.Controls.Add(this.comboAction);
            this.algoGroupBox.Controls.Add(this.label5);
            this.algoGroupBox.Controls.Add(this.tbOrderId);
            this.algoGroupBox.Controls.Add(this.label4);
            this.algoGroupBox.Controls.Add(this.nbQuantity);
            this.algoGroupBox.Controls.Add(this.label2);
            this.algoGroupBox.Controls.Add(this.nbTimeFrame);
            this.algoGroupBox.Controls.Add(this.groupBox1);
            this.algoGroupBox.Controls.Add(this.btnSubmit);
            this.algoGroupBox.Controls.Add(this.label1);
            this.algoGroupBox.Controls.Add(this.comboStrategy);
            this.algoGroupBox.Controls.Add(this.label3);
            this.algoGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.algoGroupBox.Location = new System.Drawing.Point(510, 96);
            this.algoGroupBox.Name = "algoGroupBox";
            this.algoGroupBox.Size = new System.Drawing.Size(448, 511);
            this.algoGroupBox.TabIndex = 2;
            this.algoGroupBox.TabStop = false;
            this.algoGroupBox.Text = "Algorithm";
            // 
            // tbLimitPrice
            // 
            this.tbLimitPrice.Location = new System.Drawing.Point(292, 99);
            this.tbLimitPrice.Name = "tbLimitPrice";
            this.tbLimitPrice.Size = new System.Drawing.Size(120, 20);
            this.tbLimitPrice.TabIndex = 35;
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
            // comboAction
            // 
            this.comboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAction.FormattingEnabled = true;
            this.comboAction.Items.AddRange(new object[] {
            "BUY",
            "SELL",
            "SSHORT"});
            this.comboAction.Location = new System.Drawing.Point(292, 241);
            this.comboAction.Name = "comboAction";
            this.comboAction.Size = new System.Drawing.Size(120, 21);
            this.comboAction.TabIndex = 33;
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
            // nbQuantity
            // 
            this.nbQuantity.Location = new System.Drawing.Point(292, 268);
            this.nbQuantity.Name = "nbQuantity";
            this.nbQuantity.Size = new System.Drawing.Size(120, 20);
            this.nbQuantity.TabIndex = 29;
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
            this.groupBox1.Location = new System.Drawing.Point(6, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 137);
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
            this.tbDescription.Size = new System.Drawing.Size(424, 112);
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
            this.axTws1.realtimeBar += new AxTWSLib._DTwsEvents_realtimeBarEventHandler(this.axTws1_realtimeBar);
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
            this.lblExchange.Location = new System.Drawing.Point(300, 7);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(92, 13);
            this.lblExchange.TabIndex = 8;
            this.lblExchange.Text = "Primary Exchange";
            // 
            // tbPrimaryExchange
            // 
            this.tbPrimaryExchange.Location = new System.Drawing.Point(398, 4);
            this.tbPrimaryExchange.Name = "tbPrimaryExchange";
            this.tbPrimaryExchange.Size = new System.Drawing.Size(100, 20);
            this.tbPrimaryExchange.TabIndex = 9;
            this.tbPrimaryExchange.Text = "NASDAQ";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(570, 9);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Order Type";
            // 
            // comboOrderType
            // 
            this.comboOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrderType.FormattingEnabled = true;
            this.comboOrderType.Items.AddRange(new object[] {
            "MKT",
            "LMT"});
            this.comboOrderType.Location = new System.Drawing.Point(292, 214);
            this.comboOrderType.Name = "comboOrderType";
            this.comboOrderType.Size = new System.Drawing.Size(120, 21);
            this.comboOrderType.TabIndex = 37;
            // 
            // tbOrderType
            // 
            this.tbOrderType.Location = new System.Drawing.Point(293, 126);
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.Size = new System.Drawing.Size(119, 20);
            this.tbOrderType.TabIndex = 38;
            // 
            // tbAction
            // 
            this.tbAction.Location = new System.Drawing.Point(292, 73);
            this.tbAction.Name = "tbAction";
            this.tbAction.Size = new System.Drawing.Size(120, 20);
            this.tbAction.TabIndex = 39;
            this.tbAction.Text = "BUY";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(292, 20);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(120, 20);
            this.tbQuantity.TabIndex = 40;
            // 
            // nASDAQToolStripMenuItem
            // 
            this.nASDAQToolStripMenuItem.Name = "nASDAQToolStripMenuItem";
            this.nASDAQToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nASDAQToolStripMenuItem.Text = "NASDAQ";
            // 
            // nYSEToolStripMenuItem
            // 
            this.nYSEToolStripMenuItem.Name = "nYSEToolStripMenuItem";
            this.nYSEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nYSEToolStripMenuItem.Text = "NYSE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 619);
            this.Controls.Add(this.tbSymbol);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.tbPrimaryExchange);
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
            ((System.ComponentModel.ISupportInitialize)(this.nbQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTimeFrame)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.logGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTws1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nbQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboAction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLimitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboOrderType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOrderType;
        private System.Windows.Forms.TextBox tbAction;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.ToolStripMenuItem nASDAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nYSEToolStripMenuItem;
    }
}

