namespace WindowsFormsApp
{
    public partial class Form1
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
            System.Windows.Forms.TabControl tabPages;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteCurrency = new System.Windows.Forms.Button();
            this.btnAddCurrency = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewBPI = new System.Windows.Forms.DataGridView();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.bitcoinCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotNetDataSet = new WindowsFormsApp.DotNetDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCCYCalc = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCalcVal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inptXBT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bitcoin_CurrencyTableAdapter = new WindowsFormsApp.DotNetDataSetTableAdapters.Bitcoin_CurrencyTableAdapter();
            tabPages = new System.Windows.Forms.TabControl();
            tabPages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitcoinCurrencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNetDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            tabPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabPages.Controls.Add(this.tabPage1);
            tabPages.Controls.Add(this.tabPage2);
            tabPages.Location = new System.Drawing.Point(0, 1);
            tabPages.Name = "tabPages";
            tabPages.SelectedIndex = 0;
            tabPages.Size = new System.Drawing.Size(828, 462);
            tabPages.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnDeleteCurrency);
            this.tabPage1.Controls.Add(this.btnAddCurrency);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.dateTimeStartDate);
            this.tabPage1.Controls.Add(this.dataGridViewBPI);
            this.tabPage1.Controls.Add(this.btnShowTable);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxCurrency);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimeEndDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(155, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "End date:";
            // 
            // btnDeleteCurrency
            // 
            this.btnDeleteCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCurrency.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCurrency.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteCurrency.Location = new System.Drawing.Point(688, 3);
            this.btnDeleteCurrency.Name = "btnDeleteCurrency";
            this.btnDeleteCurrency.Size = new System.Drawing.Size(126, 38);
            this.btnDeleteCurrency.TabIndex = 14;
            this.btnDeleteCurrency.Text = "Delete selected currency";
            this.btnDeleteCurrency.UseVisualStyleBackColor = false;
            this.btnDeleteCurrency.Click += new System.EventHandler(this.btnDeleteCurrency_Click);
            // 
            // btnAddCurrency
            // 
            this.btnAddCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnAddCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCurrency.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddCurrency.Location = new System.Drawing.Point(556, 3);
            this.btnAddCurrency.Name = "btnAddCurrency";
            this.btnAddCurrency.Size = new System.Drawing.Size(126, 37);
            this.btnAddCurrency.TabIndex = 13;
            this.btnAddCurrency.Text = "Add new currency";
            this.btnAddCurrency.UseVisualStyleBackColor = false;
            this.btnAddCurrency.Click += new System.EventHandler(this.btnAddCurrency_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(236, 41);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(583, 394);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeStartDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimeStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStartDate.Location = new System.Drawing.Point(69, 4);
            this.dateTimeStartDate.MaxDate = new System.DateTime(2018, 1, 27, 0, 0, 0, 0);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(84, 20);
            this.dateTimeStartDate.TabIndex = 9;
            this.dateTimeStartDate.Value = new System.DateTime(2018, 1, 27, 0, 0, 0, 0);
            // 
            // dataGridViewBPI
            // 
            this.dataGridViewBPI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewBPI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBPI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.dataGridViewBPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBPI.Location = new System.Drawing.Point(9, 41);
            this.dataGridViewBPI.Name = "dataGridViewBPI";
            this.dataGridViewBPI.RowHeadersVisible = false;
            this.dataGridViewBPI.Size = new System.Drawing.Size(221, 389);
            this.dataGridViewBPI.TabIndex = 8;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnShowTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnShowTable.Location = new System.Drawing.Point(427, 3);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(101, 23);
            this.btnShowTable.TabIndex = 7;
            this.btnShowTable.Text = "Add to table";
            this.btnShowTable.UseVisualStyleBackColor = false;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(304, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Currency:";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCurrency.DataSource = this.bitcoinCurrencyBindingSource;
            this.comboBoxCurrency.DisplayMember = "Currency";
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(365, 4);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(56, 21);
            this.comboBoxCurrency.TabIndex = 5;
            // 
            // bitcoinCurrencyBindingSource
            // 
            this.bitcoinCurrencyBindingSource.DataMember = "Bitcoin_Currency";
            this.bitcoinCurrencyBindingSource.DataSource = this.dotNetDataSet;
            // 
            // dotNetDataSet
            // 
            this.dotNetDataSet.DataSetName = "DotNetDataSet";
            this.dotNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start date:";
            // 
            // dateTimeEndDate
            // 
            this.dateTimeEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.dateTimeEndDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimeEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEndDate.Location = new System.Drawing.Point(217, 4);
            this.dateTimeEndDate.MaxDate = new System.DateTime(2018, 1, 30, 0, 0, 0, 0);
            this.dateTimeEndDate.Name = "dateTimeEndDate";
            this.dateTimeEndDate.Size = new System.Drawing.Size(84, 20);
            this.dateTimeEndDate.TabIndex = 1;
            this.dateTimeEndDate.Value = new System.DateTime(2018, 1, 29, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lblUpdateDate);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBoxCCYCalc);
            this.tabPage2.Controls.Add(this.btnCalculate);
            this.tabPage2.Controls.Add(this.lblCalcVal);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.inptXBT);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 31F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.label8.Location = new System.Drawing.Point(305, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 51);
            this.label8.TabIndex = 10;
            this.label8.Text = "CALCULATOR";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 23F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.label7.Location = new System.Drawing.Point(269, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 38);
            this.label7.TabIndex = 8;
            this.label7.Text = "VALUE =";
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdateDate.AutoSize = true;
            this.lblUpdateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUpdateDate.Location = new System.Drawing.Point(561, 408);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(137, 13);
            this.lblUpdateDate.TabIndex = 7;
            this.lblUpdateDate.Text = "THIS DATE AND TIME";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(129, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CONVERSION RATE AS PER BITCOIN PRICE INDEX, LAST UPDATED AT";
            // 
            // comboBoxCCYCalc
            // 
            this.comboBoxCCYCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCCYCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.comboBoxCCYCalc.Font = new System.Drawing.Font("Calibri", 23F);
            this.comboBoxCCYCalc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxCCYCalc.FormattingEnabled = true;
            this.comboBoxCCYCalc.Location = new System.Drawing.Point(512, 149);
            this.comboBoxCCYCalc.Name = "comboBoxCCYCalc";
            this.comboBoxCCYCalc.Size = new System.Drawing.Size(93, 46);
            this.comboBoxCCYCalc.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalculate.Location = new System.Drawing.Point(340, 260);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(181, 49);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCalcVal
            // 
            this.lblCalcVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalcVal.AutoSize = true;
            this.lblCalcVal.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.lblCalcVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.lblCalcVal.Location = new System.Drawing.Point(387, 207);
            this.lblCalcVal.Name = "lblCalcVal";
            this.lblCalcVal.Size = new System.Drawing.Size(0, 39);
            this.lblCalcVal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 23F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.label6.Location = new System.Drawing.Point(396, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 38);
            this.label6.TabIndex = 2;
            this.label6.Text = "XBT  IN";
            // 
            // inptXBT
            // 
            this.inptXBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptXBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.inptXBT.Font = new System.Drawing.Font("Calibri", 23F);
            this.inptXBT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inptXBT.Location = new System.Drawing.Point(232, 149);
            this.inptXBT.Name = "inptXBT";
            this.inptXBT.Size = new System.Drawing.Size(158, 45);
            this.inptXBT.TabIndex = 1;
            this.inptXBT.Text = "1";
            this.inptXBT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inptXBT.TextChanged += new System.EventHandler(this.inptXBT_TextChanged);
            this.inptXBT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inptXBT_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(303, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 78);
            this.label3.TabIndex = 0;
            this.label3.Text = "BITCOIN\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bitcoin_CurrencyTableAdapter
            // 
            this.bitcoin_CurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 465);
            this.Controls.Add(tabPages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bitcoin Price Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabPages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitcoinCurrencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNetDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.DateTimePicker dateTimeStartDate;
        private System.Windows.Forms.DataGridView dataGridViewBPI;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateTimeEndDate;
        public System.Windows.Forms.Button btnAddCurrency;
        public System.Windows.Forms.Button btnDeleteCurrency;
        private DotNetDataSet dotNetDataSet;
        public System.Windows.Forms.BindingSource bitcoinCurrencyBindingSource;
        private DotNetDataSetTableAdapters.Bitcoin_CurrencyTableAdapter bitcoin_CurrencyTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCalcVal;
        private System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.ComboBox comboBoxCCYCalc;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUpdateDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox inptXBT;
    }
}

