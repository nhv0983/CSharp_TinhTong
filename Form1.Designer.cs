namespace CSharp_TinhTong
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
            this.btnKQ = new System.Windows.Forms.Button();
            this.lblSo1 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btntinhtich = new System.Windows.Forms.Button();
            this.btntinhhieu = new System.Windows.Forms.Button();
            this.btntinhthuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(107, 263);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(75, 23);
            this.btnKQ.TabIndex = 0;
            this.btnKQ.Text = "tổng";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // lblSo1
            // 
            this.lblSo1.AutoSize = true;
            this.lblSo1.Location = new System.Drawing.Point(85, 62);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(26, 13);
            this.lblSo1.TabIndex = 1;
            this.lblSo1.Text = "So1";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(183, 62);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 2;
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(183, 115);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 4;
            // 
            // lblSo2
            // 
            this.lblSo2.AutoSize = true;
            this.lblSo2.Location = new System.Drawing.Point(85, 115);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(26, 13);
            this.lblSo2.TabIndex = 3;
            this.lblSo2.Text = "So2";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(183, 164);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 5;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(180, 215);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(44, 13);
            this.lblKQ.TabIndex = 6;
            this.lblKQ.Text = "Kết quả";
            this.lblKQ.Click += new System.EventHandler(this.label3_Click);
            // 
            // btntinhtich
            // 
            this.btntinhtich.Location = new System.Drawing.Point(327, 263);
            this.btntinhtich.Name = "btntinhtich";
            this.btntinhtich.Size = new System.Drawing.Size(75, 23);
            this.btntinhtich.TabIndex = 7;
            this.btntinhtich.Text = "tích";
            this.btntinhtich.UseVisualStyleBackColor = true;
            this.btntinhtich.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntinhhieu
            // 
            this.btntinhhieu.Location = new System.Drawing.Point(208, 263);
            this.btntinhhieu.Name = "btntinhhieu";
            this.btntinhhieu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btntinhhieu.Size = new System.Drawing.Size(75, 23);
            this.btntinhhieu.TabIndex = 8;
            this.btntinhhieu.Text = "hiệu";
            this.btntinhhieu.UseVisualStyleBackColor = true;
            this.btntinhhieu.Click += new System.EventHandler(this.btntinhhieu_Click);
            // 
            // btntinhthuong
            // 
            this.btntinhthuong.Location = new System.Drawing.Point(438, 263);
            this.btntinhthuong.Name = "btntinhthuong";
            this.btntinhthuong.Size = new System.Drawing.Size(75, 23);
            this.btntinhthuong.TabIndex = 9;
            this.btntinhthuong.Text = "thương";
            this.btntinhthuong.UseVisualStyleBackColor = true;
            this.btntinhthuong.Click += new System.EventHandler(this.btntinhthuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinhthuong);
            this.Controls.Add(this.btntinhhieu);
            this.Controls.Add(this.btntinhtich);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.lblSo2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.lblSo1);
            this.Controls.Add(this.btnKQ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btntinhtich;
        private System.Windows.Forms.Button btntinhhieu;
        private System.Windows.Forms.Button btntinhthuong;
    }
}

