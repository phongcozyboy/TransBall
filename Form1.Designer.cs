namespace TransBall
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
			this.lbBi = new System.Windows.Forms.Label();
			this.txtBi = new System.Windows.Forms.TextBox();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.btnChay = new System.Windows.Forms.Button();
			this.gbox = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDatLai = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnTaobiRandom = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbBi
			// 
			this.lbBi.AutoSize = true;
			this.lbBi.Location = new System.Drawing.Point(6, 38);
			this.lbBi.Name = "lbBi";
			this.lbBi.Size = new System.Drawing.Size(82, 13);
			this.lbBi.TabIndex = 0;
			this.lbBi.Text = "Nhập vào số bi:";
			// 
			// txtBi
			// 
			this.txtBi.Location = new System.Drawing.Point(97, 35);
			this.txtBi.Name = "txtBi";
			this.txtBi.Size = new System.Drawing.Size(160, 20);
			this.txtBi.TabIndex = 1;
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.Location = new System.Drawing.Point(97, 71);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
			this.btnXacNhan.TabIndex = 2;
			this.btnXacNhan.Text = "Xác nhận";
			this.btnXacNhan.UseVisualStyleBackColor = true;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// btnChay
			// 
			this.btnChay.Location = new System.Drawing.Point(653, 89);
			this.btnChay.Name = "btnChay";
			this.btnChay.Size = new System.Drawing.Size(75, 23);
			this.btnChay.TabIndex = 3;
			this.btnChay.Text = "mô phỏng";
			this.btnChay.UseVisualStyleBackColor = true;
			this.btnChay.Click += new System.EventHandler(this.btnChay_Click);
			// 
			// gbox
			// 
			this.gbox.Location = new System.Drawing.Point(15, 127);
			this.gbox.Name = "gbox";
			this.gbox.Size = new System.Drawing.Size(713, 214);
			this.gbox.TabIndex = 4;
			this.gbox.TabStop = false;
			this.gbox.Text = "Mô phỏng di chuyển";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDatLai);
			this.groupBox1.Controls.Add(this.lbBi);
			this.groupBox1.Controls.Add(this.btnXacNhan);
			this.groupBox1.Controls.Add(this.txtBi);
			this.groupBox1.Location = new System.Drawing.Point(29, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(289, 100);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cơ bản";
			// 
			// btnDatLai
			// 
			this.btnDatLai.Location = new System.Drawing.Point(182, 71);
			this.btnDatLai.Name = "btnDatLai";
			this.btnDatLai.Size = new System.Drawing.Size(75, 23);
			this.btnDatLai.TabIndex = 3;
			this.btnDatLai.Text = "Đặt lai";
			this.btnDatLai.UseVisualStyleBackColor = true;
			this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.btnTaobiRandom);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(339, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(253, 100);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Nâng cao";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(147, 57);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Chỉnh màu";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Chỉnh màu sắc cho bi: ";
			// 
			// btnTaobiRandom
			// 
			this.btnTaobiRandom.Location = new System.Drawing.Point(147, 22);
			this.btnTaobiRandom.Name = "btnTaobiRandom";
			this.btnTaobiRandom.Size = new System.Drawing.Size(75, 23);
			this.btnTaobiRandom.TabIndex = 1;
			this.btnTaobiRandom.Text = "Tạo bi";
			this.btnTaobiRandom.UseVisualStyleBackColor = true;
			this.btnTaobiRandom.Click += new System.EventHandler(this.btnTaobiRandom_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tạo bi ngẫu nhiên: ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 362);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnChay);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbox);
			this.Name = "Form1";
			this.Text = "Trans Balls";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBi;
        private System.Windows.Forms.TextBox txtBi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnChay;
        private System.Windows.Forms.GroupBox gbox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDatLai;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnTaobiRandom;
		private System.Windows.Forms.Label label1;
	}
}

