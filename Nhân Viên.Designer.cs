namespace btvn_buoi4
{
    partial class Form2
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
            this.lblMS = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtMaso = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnoke = new System.Windows.Forms.Button();
            this.btnskip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMS
            // 
            this.lblMS.AccessibleName = "bl";
            this.lblMS.AutoSize = true;
            this.lblMS.Location = new System.Drawing.Point(48, 49);
            this.lblMS.Name = "lblMS";
            this.lblMS.Size = new System.Drawing.Size(49, 16);
            this.lblMS.TabIndex = 0;
            this.lblMS.Text = "MSNV:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(45, 83);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(94, 16);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên nhân viên:";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(48, 116);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(91, 16);
            this.lblLuong.TabIndex = 2;
            this.lblLuong.Text = "Lương cơ bản:";
            // 
            // txtMaso
            // 
            this.txtMaso.Location = new System.Drawing.Point(165, 43);
            this.txtMaso.MaxLength = 10;
            this.txtMaso.Name = "txtMaso";
            this.txtMaso.Size = new System.Drawing.Size(169, 22);
            this.txtMaso.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(165, 77);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(248, 22);
            this.txtTen.TabIndex = 4;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(165, 110);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(169, 22);
            this.txtLuong.TabIndex = 5;
            // 
            // btnoke
            // 
            this.btnoke.Location = new System.Drawing.Point(80, 151);
            this.btnoke.Name = "btnoke";
            this.btnoke.Size = new System.Drawing.Size(75, 28);
            this.btnoke.TabIndex = 6;
            this.btnoke.Text = "Đồng ý";
            this.btnoke.UseVisualStyleBackColor = true;
            this.btnoke.Click += new System.EventHandler(this.btnoke_Click);
            // 
            // btnskip
            // 
            this.btnskip.Location = new System.Drawing.Point(272, 151);
            this.btnskip.Name = "btnskip";
            this.btnskip.Size = new System.Drawing.Size(75, 28);
            this.btnskip.TabIndex = 7;
            this.btnskip.Text = "Bỏ qua";
            this.btnskip.UseVisualStyleBackColor = true;
            this.btnskip.Click += new System.EventHandler(this.btnskip_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 222);
            this.Controls.Add(this.btnskip);
            this.Controls.Add(this.btnoke);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaso);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMS);
            this.Name = "Form2";
            this.Text = "Lương cơ bản:";
     
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMS;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.TextBox txtMaso;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnoke;
        private System.Windows.Forms.Button btnskip;
    }
}