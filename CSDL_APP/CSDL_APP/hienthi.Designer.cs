
namespace CSDL_APP
{
    partial class hienthi
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
            this.dgvHienthi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKethop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHienthi
            // 
            this.dgvHienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienthi.Location = new System.Drawing.Point(12, 69);
            this.dgvHienthi.Name = "dgvHienthi";
            this.dgvHienthi.RowHeadersWidth = 51;
            this.dgvHienthi.RowTemplate.Height = 24;
            this.dgvHienthi.Size = new System.Drawing.Size(899, 346);
            this.dgvHienthi.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 24);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH PHIẾU BẢO HÀNH";
            // 
            // cbKethop
            // 
            this.cbKethop.AutoSize = true;
            this.cbKethop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKethop.Location = new System.Drawing.Point(12, 33);
            this.cbKethop.Name = "cbKethop";
            this.cbKethop.Size = new System.Drawing.Size(233, 24);
            this.cbKethop.TabIndex = 4;
            this.cbKethop.Text = "Kết hợp với bảng sản phẩm";
            this.cbKethop.UseVisualStyleBackColor = true;
            this.cbKethop.CheckedChanged += new System.EventHandler(this.cbKethop_CheckedChanged);
            // 
            // hienthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(923, 428);
            this.Controls.Add(this.cbKethop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHienthi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "hienthi";
            this.Text = "HIỂN THỊ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.hienthi_FormClosed);
            this.Load += new System.EventHandler(this.hienthi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHienthi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbKethop;
    }
}