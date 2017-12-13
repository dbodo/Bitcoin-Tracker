namespace WindowsFormsApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewBPI = new System.Windows.Forms.DataGridView();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBPI)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimeStartDate);
            this.tabPage1.Controls.Add(this.dataGridViewBPI);
            this.tabPage1.Controls.Add(this.btnShowTable);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxCurrency);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimeEndDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBPI
            // 
            this.dataGridViewBPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBPI.Location = new System.Drawing.Point(101, 42);
            this.dataGridViewBPI.Name = "dataGridViewBPI";
            this.dataGridViewBPI.Size = new System.Drawing.Size(605, 334);
            this.dataGridViewBPI.TabIndex = 8;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(12, 42);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(75, 23);
            this.btnShowTable.TabIndex = 7;
            this.btnShowTable.Text = "Show";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Currency:";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "USD",
            "HRK",
            "EUR"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(585, 10);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCurrency.TabIndex = 5;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pick a date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "from";
            // 
            // dateTimeEndDate
            // 
            this.dateTimeEndDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEndDate.Location = new System.Drawing.Point(220, 10);
            this.dateTimeEndDate.Name = "dateTimeEndDate";
            this.dateTimeEndDate.Size = new System.Drawing.Size(92, 20);
            this.dateTimeEndDate.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStartDate.Location = new System.Drawing.Point(101, 10);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(91, 20);
            this.dateTimeStartDate.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 411);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bitcoin Price Checker";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBPI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewBPI;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeEndDate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
    }
}

