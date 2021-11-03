
namespace Calculator
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
            this.lbTinh = new System.Windows.Forms.Label();
            this.lbSoB = new System.Windows.Forms.Label();
            this.lbSoa = new System.Windows.Forms.Label();
            this.lbKq = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTinh
            // 
            this.lbTinh.AutoSize = true;
            this.lbTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinh.ForeColor = System.Drawing.Color.Blue;
            this.lbTinh.Location = new System.Drawing.Point(135, 22);
            this.lbTinh.Name = "lbTinh";
            this.lbTinh.Size = new System.Drawing.Size(108, 20);
            this.lbTinh.TabIndex = 0;
            this.lbTinh.Text = "TÍNH TOÁN";
            this.lbTinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSoB
            // 
            this.lbSoB.AutoSize = true;
            this.lbSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbSoB.Location = new System.Drawing.Point(36, 127);
            this.lbSoB.Name = "lbSoB";
            this.lbSoB.Size = new System.Drawing.Size(48, 18);
            this.lbSoB.TabIndex = 2;
            this.lbSoB.Text = "Số b:";
            // 
            // lbSoa
            // 
            this.lbSoa.AutoSize = true;
            this.lbSoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbSoa.Location = new System.Drawing.Point(36, 79);
            this.lbSoa.Name = "lbSoa";
            this.lbSoa.Size = new System.Drawing.Size(48, 18);
            this.lbSoa.TabIndex = 3;
            this.lbSoa.Text = "Số a:";
            // 
            // lbKq
            // 
            this.lbKq.AutoSize = true;
            this.lbKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbKq.Location = new System.Drawing.Point(14, 175);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(70, 18);
            this.lbKq.TabIndex = 4;
            this.lbKq.Text = "Kết quả:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 32);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 126);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 32);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 174);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 32);
            this.textBox3.TabIndex = 7;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.Location = new System.Drawing.Point(135, 232);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 41);
            this.btCong.TabIndex = 8;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.Location = new System.Drawing.Point(266, 232);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(75, 41);
            this.btTru.TabIndex = 9;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 285);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.lbSoa);
            this.Controls.Add(this.lbSoB);
            this.Controls.Add(this.lbTinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTinh;
        private System.Windows.Forms.Label lbSoB;
        private System.Windows.Forms.Label lbSoa;
        private System.Windows.Forms.Label lbKq;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
    }
}

