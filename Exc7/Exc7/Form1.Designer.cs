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
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.rbThree = new System.Windows.Forms.RadioButton();
            this.rbOvernight = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBags
            // 
            this.lbBags.FormattingEnabled = true;
            this.lbBags.Items.AddRange(new object[] {
            "Full Decorative",
            "Beaded",
            "Needlepoint Design",
            "Fringed",
            "Fringed Beaded",
            "Plain"});
            this.lbBags.Location = new System.Drawing.Point(12, 41);
            this.lbBags.Name = "lbBags";
            this.lbBags.Size = new System.Drawing.Size(120, 82);
            this.lbBags.TabIndex = 0;
            this.lbBags.SelectedIndexChanged += new System.EventHandler(this.lbBags_SelectedIndexChanged);
            // 
            // bClear
            // 
            this.bClear.Enabled = false;
            this.bClear.Location = new System.Drawing.Point(9, 208);
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
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Bag:";
            // 
            // tbSelected
            // 
            this.tbSelected.Location = new System.Drawing.Point(15, 156);
            this.tbSelected.Name = "tbSelected";
            this.tbSelected.ReadOnly = true;
            this.tbSelected.Size = new System.Drawing.Size(148, 20);
            this.tbSelected.TabIndex = 4;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(12, 19);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(91, 17);
            this.rbStandard.TabIndex = 5;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard (%5)";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // rbThree
            // 
            this.rbThree.AutoSize = true;
            this.rbThree.Location = new System.Drawing.Point(12, 48);
            this.rbThree.Name = "rbThree";
            this.rbThree.Size = new System.Drawing.Size(98, 17);
            this.rbThree.TabIndex = 6;
            this.rbThree.TabStop = true;
            this.rbThree.Text = "Three-Day (%7)";
            this.rbThree.UseVisualStyleBackColor = true;
            // 
            // rbOvernight
            // 
            this.rbOvernight.AutoSize = true;
            this.rbOvernight.Location = new System.Drawing.Point(12, 77);
            this.rbOvernight.Name = "rbOvernight";
            this.rbOvernight.Size = new System.Drawing.Size(100, 17);
            this.rbOvernight.TabIndex = 7;
            this.rbOvernight.TabStop = true;
            this.rbOvernight.Text = "Overnight (%10)";
            this.rbOvernight.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStandard);
            this.groupBox1.Controls.Add(this.rbOvernight);
            this.groupBox1.Controls.Add(this.rbThree);
            this.groupBox1.Location = new System.Drawing.Point(167, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shippping Option";
            // 
            // bOrder
            // 
            this.bOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOrder.Location = new System.Drawing.Point(203, 199);
            this.bOrder.Name = "bOrder";
            this.bOrder.Size = new System.Drawing.Size(81, 32);
            this.bOrder.TabIndex = 9;
            this.bOrder.Text = "Order";
            this.bOrder.UseVisualStyleBackColor = true;
            this.bOrder.Click += new System.EventHandler(this.bOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(67, 182);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(36, 20);
            this.nudQuantity.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 237);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.lbBags);
            this.Name = "Form1";
            this.Text = "Bag Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBags;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.TextBox tbSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.RadioButton rbThree;
        private System.Windows.Forms.RadioButton rbOvernight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}

