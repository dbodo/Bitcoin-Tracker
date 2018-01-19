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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inptBtc = new System.Windows.Forms.TextBox();
            this.comboBoxCurrency2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteCurrency = new System.Windows.Forms.Button();
            this.btnAddCurrency = new System.Windows.Forms.Button();
            this.inptCurrency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewBPI = new System.Windows.Forms.DataGridView();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.bitcoinCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotNetDataSet = new WindowsFormsApp.DotNetDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.bitcoin_CurrencyTableAdapter = new WindowsFormsApp.DotNetDataSetTableAdapters.Bitcoin_CurrencyTableAdapter();
            tabPages = new System.Windows.Forms.TabControl();
            tabPages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitcoinCurrencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotNetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            tabPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabPages.Controls.Add(this.tabPage1);
            tabPages.Location = new System.Drawing.Point(0, 1);
            tabPages.Name = "tabPages";
            tabPages.SelectedIndex = 0;
            tabPages.Size = new System.Drawing.Size(828, 462);
            tabPages.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.labelValue);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.inptBtc);
            this.tabPage1.Controls.Add(this.comboBoxCurrency2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnDeleteCurrency);
            this.tabPage1.Controls.Add(this.btnAddCurrency);
            this.tabPage1.Controls.Add(this.inptCurrency);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.dateTimeStartDate);
            this.tabPage1.Controls.Add(this.dataGridViewBPI);
            this.tabPage1.Controls.Add(this.btnShowTable);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxCurrency);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimeEndDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCalculate.Location = new System.Drawing.Point(416, 52);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(453, 31);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(12, 13);
            this.labelValue.TabIndex = 21;
            this.labelValue.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "BTC =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bitcoin Calculator";
            // 
            // inptBtc
            // 
            this.inptBtc.Location = new System.Drawing.Point(340, 26);
            this.inptBtc.Name = "inptBtc";
            this.inptBtc.Size = new System.Drawing.Size(68, 20);
            this.inptBtc.TabIndex = 17;
            // 
            // comboBoxCurrency2
            // 
            this.comboBoxCurrency2.FormattingEnabled = true;
            this.comboBoxCurrency2.Location = new System.Drawing.Point(498, 27);
            this.comboBoxCurrency2.Name = "comboBoxCurrency2";
            this.comboBoxCurrency2.Size = new System.Drawing.Size(68, 21);
            this.comboBoxCurrency2.TabIndex = 16;
            this.comboBoxCurrency2.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "End";
            // 
            // btnDeleteCurrency
            // 
            this.btnDeleteCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCurrency.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeleteCurrency.Location = new System.Drawing.Point(750, 31);
            this.btnDeleteCurrency.Name = "btnDeleteCurrency";
            this.btnDeleteCurrency.Size = new System.Drawing.Size(64, 23);
            this.btnDeleteCurrency.TabIndex = 14;
            this.btnDeleteCurrency.Text = "DELETE";
            this.btnDeleteCurrency.UseVisualStyleBackColor = true;
            this.btnDeleteCurrency.Click += new System.EventHandler(this.btnDeleteCurrency_Click);
            // 
            // btnAddCurrency
            // 
            this.btnAddCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCurrency.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddCurrency.Location = new System.Drawing.Point(681, 31);
            this.btnAddCurrency.Name = "btnAddCurrency";
            this.btnAddCurrency.Size = new System.Drawing.Size(63, 23);
            this.btnAddCurrency.TabIndex = 13;
            this.btnAddCurrency.Text = "ADD";
            this.btnAddCurrency.UseVisualStyleBackColor = true;
            this.btnAddCurrency.Click += new System.EventHandler(this.btnAddCurrency_Click);
            // 
            // inptCurrency
            // 
            this.inptCurrency.Location = new System.Drawing.Point(734, 6);
            this.inptCurrency.MaxLength = 3;
            this.inptCurrency.Name = "inptCurrency";
            this.inptCurrency.Size = new System.Drawing.Size(63, 20);
            this.inptCurrency.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add new currency:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(259, 104);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(560, 331);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimeStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStartDate.Location = new System.Drawing.Point(43, 18);
            this.dateTimeStartDate.MaxDate = new System.DateTime(2018, 1, 18, 0, 12, 41, 0);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(84, 20);
            this.dateTimeStartDate.TabIndex = 9;
            this.dateTimeStartDate.Value = new System.DateTime(2018, 1, 18, 0, 12, 41, 0);
            // 
            // dataGridViewBPI
            // 
            this.dataGridViewBPI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBPI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBPI.Location = new System.Drawing.Point(9, 104);
            this.dataGridViewBPI.Name = "dataGridViewBPI";
            this.dataGridViewBPI.Size = new System.Drawing.Size(244, 326);
            this.dataGridViewBPI.TabIndex = 8;
            // 
            // btnShowTable
            // 
            this.btnShowTable.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowTable.Location = new System.Drawing.Point(179, 70);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(74, 23);
            this.btnShowTable.TabIndex = 7;
            this.btnShowTable.Text = "Show";
            this.btnShowTable.UseVisualStyleBackColor = false;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Currency";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.DataSource = this.bitcoinCurrencyBindingSource;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(71, 70);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(56, 21);
            this.comboBoxCurrency.TabIndex = 5;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pick a date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start";
            // 
            // dateTimeEndDate
            // 
            this.dateTimeEndDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimeEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEndDate.Location = new System.Drawing.Point(43, 44);
            this.dateTimeEndDate.MaxDate = new System.DateTime(2018, 1, 18, 0, 0, 0, 0);
            this.dateTimeEndDate.Name = "dateTimeEndDate";
            this.dateTimeEndDate.Size = new System.Drawing.Size(84, 20);
            this.dateTimeEndDate.TabIndex = 1;
            this.dateTimeEndDate.Value = new System.DateTime(2018, 1, 18, 0, 0, 0, 0);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateTimeEndDate;
        public System.Windows.Forms.Button btnAddCurrency;
        public System.Windows.Forms.TextBox inptCurrency;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnDeleteCurrency;
        private DotNetDataSet dotNetDataSet;
        private System.Windows.Forms.BindingSource bitcoinCurrencyBindingSource;
        private DotNetDataSetTableAdapters.Bitcoin_CurrencyTableAdapter bitcoin_CurrencyTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inptBtc;
        private System.Windows.Forms.ComboBox comboBoxCurrency2;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button btnCalculate;
    }
}

