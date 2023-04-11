namespace dotNet
{
    partial class fAdmin
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
            this.dtgvAcount = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAcount
            // 
            this.dtgvAcount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAcount.Location = new System.Drawing.Point(165, 79);
            this.dtgvAcount.Name = "dtgvAcount";
            this.dtgvAcount.RowHeadersWidth = 51;
            this.dtgvAcount.RowTemplate.Height = 24;
            this.dtgvAcount.Size = new System.Drawing.Size(431, 313);
            this.dtgvAcount.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.dtgvAcount);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAcount;
    }
}