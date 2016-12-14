namespace ASSignments
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbSwim = new System.Windows.Forms.CheckBox();
            this.cbSnorkel = new System.Windows.Forms.CheckBox();
            this.cbDive = new System.Windows.Forms.CheckBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbExp = new System.Windows.Forms.GroupBox();
            this.ExpMod = new System.Windows.Forms.Label();
            this.rbAdv = new System.Windows.Forms.RadioButton();
            this.rbInt = new System.Windows.Forms.RadioButton();
            this.rbBeg = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbExp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 1;
            // 
            // cbSwim
            // 
            this.cbSwim.AutoSize = true;
            this.cbSwim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSwim.ForeColor = System.Drawing.Color.Yellow;
            this.cbSwim.Location = new System.Drawing.Point(16, 110);
            this.cbSwim.Name = "cbSwim";
            this.cbSwim.Size = new System.Drawing.Size(101, 24);
            this.cbSwim.TabIndex = 2;
            this.cbSwim.Text = "Swim: $25";
            this.cbSwim.UseVisualStyleBackColor = true;
            this.cbSwim.CheckedChanged += new System.EventHandler(this.Compute_CheckedChanged);
            // 
            // cbSnorkel
            // 
            this.cbSnorkel.AutoSize = true;
            this.cbSnorkel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSnorkel.ForeColor = System.Drawing.Color.Yellow;
            this.cbSnorkel.Location = new System.Drawing.Point(16, 134);
            this.cbSnorkel.Name = "cbSnorkel";
            this.cbSnorkel.Size = new System.Drawing.Size(117, 24);
            this.cbSnorkel.TabIndex = 3;
            this.cbSnorkel.Text = "Snorkel: $50";
            this.cbSnorkel.UseVisualStyleBackColor = true;
            this.cbSnorkel.CheckedChanged += new System.EventHandler(this.Compute_CheckedChanged);
            // 
            // cbDive
            // 
            this.cbDive.AutoSize = true;
            this.cbDive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDive.ForeColor = System.Drawing.Color.Yellow;
            this.cbDive.Location = new System.Drawing.Point(16, 158);
            this.cbDive.Name = "cbDive";
            this.cbDive.Size = new System.Drawing.Size(103, 24);
            this.cbDive.TabIndex = 4;
            this.cbDive.Text = "Dive: $100";
            this.cbDive.UseVisualStyleBackColor = true;
            this.cbDive.CheckedChanged += new System.EventHandler(this.Compute_CheckedChanged);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(122, 235);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(68, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total:";
            // 
            // gbExp
            // 
            this.gbExp.Controls.Add(this.ExpMod);
            this.gbExp.Controls.Add(this.rbAdv);
            this.gbExp.Controls.Add(this.rbInt);
            this.gbExp.Controls.Add(this.rbBeg);
            this.gbExp.ForeColor = System.Drawing.Color.Yellow;
            this.gbExp.Location = new System.Drawing.Point(139, 76);
            this.gbExp.Name = "gbExp";
            this.gbExp.Size = new System.Drawing.Size(141, 136);
            this.gbExp.TabIndex = 7;
            this.gbExp.TabStop = false;
            this.gbExp.Text = "Experience";
            // 
            // ExpMod
            // 
            this.ExpMod.AutoSize = true;
            this.ExpMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpMod.Location = new System.Drawing.Point(6, 89);
            this.ExpMod.MaximumSize = new System.Drawing.Size(150, 0);
            this.ExpMod.Name = "ExpMod";
            this.ExpMod.Size = new System.Drawing.Size(0, 17);
            this.ExpMod.TabIndex = 4;
            // 
            // rbAdv
            // 
            this.rbAdv.AutoSize = true;
            this.rbAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdv.Location = new System.Drawing.Point(6, 61);
            this.rbAdv.Name = "rbAdv";
            this.rbAdv.Size = new System.Drawing.Size(98, 24);
            this.rbAdv.TabIndex = 2;
            this.rbAdv.TabStop = true;
            this.rbAdv.Text = "Advanced";
            this.rbAdv.UseVisualStyleBackColor = true;
            this.rbAdv.CheckedChanged += new System.EventHandler(this.Compute_CheckedChanged);
            // 
            // rbInt
            // 
            this.rbInt.AutoSize = true;
            this.rbInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInt.Location = new System.Drawing.Point(6, 37);
            this.rbInt.Name = "rbInt";
            this.rbInt.Size = new System.Drawing.Size(117, 24);
            this.rbInt.TabIndex = 1;
            this.rbInt.TabStop = true;
            this.rbInt.Text = "Intermediate";
            this.rbInt.UseVisualStyleBackColor = true;
            this.rbInt.CheckedChanged += new System.EventHandler(this.Compute_CheckedChanged);
            // 
            // rbBeg
            // 
            this.rbBeg.AutoSize = true;
            this.rbBeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBeg.Location = new System.Drawing.Point(6, 14);
            this.rbBeg.Name = "rbBeg";
            this.rbBeg.Size = new System.Drawing.Size(91, 24);
            this.rbBeg.TabIndex = 0;
            this.rbBeg.TabStop = true;
            this.rbBeg.Text = "Beginner";
            this.rbBeg.UseVisualStyleBackColor = true;
            this.rbBeg.CheckedChanged += new System.EventHandler(this.Compute_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lesson Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(26, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "(check all that apply)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(296, 298);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbExp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.cbDive);
            this.Controls.Add(this.cbSnorkel);
            this.Controls.Add(this.cbSwim);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lesson";
            this.gbExp.ResumeLayout(false);
            this.gbExp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbSwim;
        private System.Windows.Forms.CheckBox cbSnorkel;
        private System.Windows.Forms.CheckBox cbDive;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbExp;
        private System.Windows.Forms.RadioButton rbAdv;
        private System.Windows.Forms.RadioButton rbInt;
        private System.Windows.Forms.RadioButton rbBeg;
        private System.Windows.Forms.Label ExpMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

