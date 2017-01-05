namespace Exc7
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
            this.lbBags = new System.Windows.Forms.ListBox();
            this.bClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSelected = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbBags
            // 
            this.lbBags.FormattingEnabled = true;
            this.lbBags.Items.AddRange(new object[] {
            "full decorative",
            "beaded",
            "needlepoint design",
            "fringed",
            "fringed beaded",
            "plain"});
            this.lbBags.Location = new System.Drawing.Point(12, 41);
            this.lbBags.Name = "lbBags";
            this.lbBags.Size = new System.Drawing.Size(120, 95);
            this.lbBags.TabIndex = 0;
            this.lbBags.SelectedIndexChanged += new System.EventHandler(this.lbBags_SelectedIndexChanged);
            // 
            // bClear
            // 
            this.bClear.Enabled = false;
            this.bClear.Location = new System.Drawing.Point(161, 84);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(94, 23);
            this.bClear.TabIndex = 1;
            this.bClear.Text = "Clear Selected";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Type of Bag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Bag:";
            // 
            // tbSelected
            // 
            this.tbSelected.Location = new System.Drawing.Point(158, 58);
            this.tbSelected.Name = "tbSelected";
            this.tbSelected.ReadOnly = true;
            this.tbSelected.Size = new System.Drawing.Size(100, 20);
            this.tbSelected.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.tbSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.lbBags);
            this.Name = "Form1";
            this.Text = "Bag Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBags;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.TextBox tbSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

