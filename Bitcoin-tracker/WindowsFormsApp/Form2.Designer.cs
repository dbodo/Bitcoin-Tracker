namespace WindowsFormsApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.inptCurrency = new System.Windows.Forms.TextBox();
            this.btnAddCCY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input currency code";
            // 
            // inptCurrency
            // 
            this.inptCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.inptCurrency.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.inptCurrency.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inptCurrency.Location = new System.Drawing.Point(19, 46);
            this.inptCurrency.Name = "inptCurrency";
            this.inptCurrency.Size = new System.Drawing.Size(52, 24);
            this.inptCurrency.TabIndex = 1;
            this.inptCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inptCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inptCurrency_KeyPress);
            // 
            // btnAddCCY
            // 
            this.btnAddCCY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.btnAddCCY.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCCY.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddCCY.Location = new System.Drawing.Point(84, 42);
            this.btnAddCCY.Name = "btnAddCCY";
            this.btnAddCCY.Size = new System.Drawing.Size(60, 31);
            this.btnAddCCY.TabIndex = 2;
            this.btnAddCCY.Text = "Add";
            this.btnAddCCY.UseVisualStyleBackColor = false;
            this.btnAddCCY.Click += new System.EventHandler(this.btnAddCCY_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISO 4217 Standard";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 82);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCCY);
            this.Controls.Add(this.inptCurrency);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inptCurrency;
        private System.Windows.Forms.Button btnAddCCY;
        private System.Windows.Forms.Label label2;
    }
}