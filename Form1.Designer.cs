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
            this.label1 = new System.Windows.Forms.Label();
            this.lbBuoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBi
            // 
            this.lbBi.AutoSize = true;
            this.lbBi.Location = new System.Drawing.Point(12, 9);
            this.lbBi.Name = "lbBi";
            this.lbBi.Size = new System.Drawing.Size(82, 13);
            this.lbBi.TabIndex = 0;
            this.lbBi.Text = "Nhập vào số bi:";
            // 
            // txtBi
            // 
            this.txtBi.Location = new System.Drawing.Point(100, 6);
            this.txtBi.Name = "txtBi";
            this.txtBi.Size = new System.Drawing.Size(100, 20);
            this.txtBi.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(217, 6);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnChay
            // 
            this.btnChay.Location = new System.Drawing.Point(298, 6);
            this.btnChay.Name = "btnChay";
            this.btnChay.Size = new System.Drawing.Size(75, 23);
            this.btnChay.TabIndex = 3;
            this.btnChay.Text = "chạy ";
            this.btnChay.UseVisualStyleBackColor = true;
            this.btnChay.Click += new System.EventHandler(this.btnChay_Click);
            // 
            // gbox
            // 
            this.gbox.Location = new System.Drawing.Point(15, 53);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(688, 284);
            this.gbox.TabIndex = 4;
            this.gbox.TabStop = false;
            this.gbox.Text = "Mô phỏng di chuyển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số bước mà bi đã hoán vị: ";
            // 
            // lbBuoc
            // 
            this.lbBuoc.AutoSize = true;
            this.lbBuoc.Location = new System.Drawing.Point(548, 16);
            this.lbBuoc.Name = "lbBuoc";
            this.lbBuoc.Size = new System.Drawing.Size(13, 13);
            this.lbBuoc.TabIndex = 6;
            this.lbBuoc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 362);
            this.Controls.Add(this.lbBuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.btnChay);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtBi);
            this.Controls.Add(this.lbBi);
            this.Name = "Form1";
            this.Text = "Trans Balls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBi;
        private System.Windows.Forms.TextBox txtBi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnChay;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBuoc;
    }
}

