namespace TaxCalc1
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
            this.tbIncome = new System.Windows.Forms.TextBox();
            this.cbTax = new System.Windows.Forms.ComboBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.bCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbIncome
            // 
            this.tbIncome.Location = new System.Drawing.Point(93, 12);
            this.tbIncome.Name = "tbIncome";
            this.tbIncome.Size = new System.Drawing.Size(98, 20);
            this.tbIncome.TabIndex = 0;
            // 
            // cbTax
            // 
            this.cbTax.FormattingEnabled = true;
            this.cbTax.Items.AddRange(new object[] {
            "3%",
            "5%",
            "7.5%",
            "8%",
            "10%",
            "12.5%",
            "15%",
            "25%"});
            this.cbTax.Location = new System.Drawing.Point(93, 40);
            this.cbTax.Name = "cbTax";
            this.cbTax.Size = new System.Drawing.Size(66, 21);
            this.cbTax.TabIndex = 1;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(93, 120);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(98, 20);
            this.tbTotal.TabIndex = 3;
            // 
            // bCalc
            // 
            this.bCalc.Location = new System.Drawing.Point(59, 81);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(75, 23);
            this.bCalc.TabIndex = 2;
            this.bCalc.Text = "Calculate";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.Calculate);
            this.bCalc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bCalc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Income:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tax Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(203, 154);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCalc);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.cbTax);
            this.Controls.Add(this.tbIncome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIncome;
        private System.Windows.Forms.ComboBox cbTax;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button bCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

