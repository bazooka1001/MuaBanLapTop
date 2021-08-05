namespace Demo1
{
    partial class ChitietSP
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSp = new System.Windows.Forms.TextBox();
            this.dgv_CtSp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CtSp)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // txt_MaSp
            // 
            this.txt_MaSp.Location = new System.Drawing.Point(217, 92);
            this.txt_MaSp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaSp.Name = "txt_MaSp";
            this.txt_MaSp.Size = new System.Drawing.Size(132, 22);
            this.txt_MaSp.TabIndex = 8;
            // 
            // dgv_CtSp
            // 
            this.dgv_CtSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CtSp.Location = new System.Drawing.Point(20, 156);
            this.dgv_CtSp.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_CtSp.Name = "dgv_CtSp";
            this.dgv_CtSp.RowHeadersWidth = 51;
            this.dgv_CtSp.Size = new System.Drawing.Size(825, 370);
            this.dgv_CtSp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chi tiết sản phẩm";
            // 
            // ChitietSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaSp);
            this.Controls.Add(this.dgv_CtSp);
            this.Controls.Add(this.label1);
            this.Name = "ChitietSP";
            this.Text = "ChitietSP";
            this.Load += new System.EventHandler(this.ChitietSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CtSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSp;
        private System.Windows.Forms.DataGridView dgv_CtSp;
        private System.Windows.Forms.Label label1;
    }
}