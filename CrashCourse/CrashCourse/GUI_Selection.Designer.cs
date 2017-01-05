namespace CrashCourse
{
    partial class GUI_Selection
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
            this.bProSel = new System.Windows.Forms.Button();
            this.lbWorkers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSelected = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bProSel
            // 
            this.bProSel.BackColor = System.Drawing.Color.Black;
            this.bProSel.Location = new System.Drawing.Point(83, 139);
            this.bProSel.Name = "bProSel";
            this.bProSel.Size = new System.Drawing.Size(75, 54);
            this.bProSel.TabIndex = 0;
            this.bProSel.Text = "Pretty much do whatever you want";
            this.bProSel.UseVisualStyleBackColor = false;
            this.bProSel.Click += new System.EventHandler(this.bProSel_Click);
            // 
            // lbWorkers
            // 
            this.lbWorkers.BackColor = System.Drawing.Color.Coral;
            this.lbWorkers.ForeColor = System.Drawing.Color.Yellow;
            this.lbWorkers.FormattingEnabled = true;
            this.lbWorkers.Items.AddRange(new object[] {
            "Baca, Joshua",
            "McKee, Greg",
            "McCall, Chris",
            "Espisito, Julien"});
            this.lbWorkers.Location = new System.Drawing.Point(69, 25);
            this.lbWorkers.Name = "lbWorkers";
            this.lbWorkers.Size = new System.Drawing.Size(101, 108);
            this.lbWorkers.TabIndex = 1;
            this.lbWorkers.SelectedIndexChanged += new System.EventHandler(this.lbWorkers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please make your selection in the List Box below";
            // 
            // tbSelected
            // 
            this.tbSelected.BackColor = System.Drawing.Color.DarkKhaki;
            this.tbSelected.ForeColor = System.Drawing.Color.White;
            this.tbSelected.Location = new System.Drawing.Point(69, 199);
            this.tbSelected.Name = "tbSelected";
            this.tbSelected.ReadOnly = true;
            this.tbSelected.Size = new System.Drawing.Size(101, 20);
            this.tbSelected.TabIndex = 3;
            // 
            // GUI_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(254, 228);
            this.Controls.Add(this.tbSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbWorkers);
            this.Controls.Add(this.bProSel);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "GUI_Selection";
            this.Text = "GUI Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bProSel;
        private System.Windows.Forms.ListBox lbWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSelected;
    }
}

