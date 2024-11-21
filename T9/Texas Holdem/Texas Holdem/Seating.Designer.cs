namespace Texas_Holdem
{
    partial class Seating
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
            this.Table1 = new System.Windows.Forms.ListBox();
            this.Table2 = new System.Windows.Forms.ListBox();
            this.Table3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Table1
            // 
            this.Table1.FormattingEnabled = true;
            this.Table1.ItemHeight = 38;
            this.Table1.Location = new System.Drawing.Point(73, 12);
            this.Table1.Name = "Table1";
            this.Table1.Size = new System.Drawing.Size(262, 308);
            this.Table1.TabIndex = 0;
            this.Table1.SelectedIndexChanged += new System.EventHandler(this.Table1_SelectedIndexChanged);
            // 
            // Table2
            // 
            this.Table2.FormattingEnabled = true;
            this.Table2.ItemHeight = 38;
            this.Table2.Location = new System.Drawing.Point(411, 12);
            this.Table2.Name = "Table2";
            this.Table2.Size = new System.Drawing.Size(262, 308);
            this.Table2.TabIndex = 1;
            // 
            // Table3
            // 
            this.Table3.FormattingEnabled = true;
            this.Table3.ItemHeight = 38;
            this.Table3.Location = new System.Drawing.Point(784, 12);
            this.Table3.Name = "Table3";
            this.Table3.Size = new System.Drawing.Size(262, 308);
            this.Table3.TabIndex = 2;
            // 
            // Seating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1284, 742);
            this.Controls.Add(this.Table3);
            this.Controls.Add(this.Table2);
            this.Controls.Add(this.Table1);
            this.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Seating";
            this.Text = "Seating";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Table1;
        private System.Windows.Forms.ListBox Table2;
        private System.Windows.Forms.ListBox Table3;
    }
}