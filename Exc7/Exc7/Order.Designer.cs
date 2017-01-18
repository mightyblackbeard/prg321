namespace Exc7
{
    partial class Order
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
            this.bAddToOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.bCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBags
            // 
            this.lbBags.FormattingEnabled = true;
            this.lbBags.Location = new System.Drawing.Point(12, 41);
            this.lbBags.Name = "lbBags";
            this.lbBags.Size = new System.Drawing.Size(120, 82);
            this.lbBags.TabIndex = 0;
            this.lbBags.SelectedIndexChanged += new System.EventHandler(this.lbBags_SelectedIndexChanged);
            // 
            // bClear
            // 
            this.bClear.Enabled = false;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(12, 155);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(94, 32);
            this.bClear.TabIndex = 1;
            this.bClear.Text = "Clear Item";
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
            this.label2.Location = new System.Drawing.Point(138, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Bag:";
            // 
            // tbSelected
            // 
            this.tbSelected.Location = new System.Drawing.Point(141, 66);
            this.tbSelected.Name = "tbSelected";
            this.tbSelected.ReadOnly = true;
            this.tbSelected.Size = new System.Drawing.Size(95, 20);
            this.tbSelected.TabIndex = 4;
            // 
            // bAddToOrder
            // 
            this.bAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddToOrder.Location = new System.Drawing.Point(112, 155);
            this.bAddToOrder.Name = "bAddToOrder";
            this.bAddToOrder.Size = new System.Drawing.Size(90, 32);
            this.bAddToOrder.TabIndex = 9;
            this.bAddToOrder.Text = "Add to Order";
            this.bAddToOrder.UseVisualStyleBackColor = true;
            this.bAddToOrder.Click += new System.EventHandler(this.bAddToOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(218, 96);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(36, 20);
            this.nudQuantity.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(246, 66);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(50, 20);
            this.tbPrice.TabIndex = 13;
            // 
            // bCheckout
            // 
            this.bCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCheckout.Location = new System.Drawing.Point(221, 145);
            this.bCheckout.Name = "bCheckout";
            this.bCheckout.Size = new System.Drawing.Size(75, 51);
            this.bCheckout.TabIndex = 14;
            this.bCheckout.Text = "Proceed to Checkout";
            this.bCheckout.UseVisualStyleBackColor = true;
            this.bCheckout.Click += new System.EventHandler(this.bCheckout_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 210);
            this.Controls.Add(this.bCheckout);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAddToOrder);
            this.Controls.Add(this.tbSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.lbBags);
            this.Name = "Order";
            this.Text = "Bag Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button bAddToOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button bCheckout;
    }
}

