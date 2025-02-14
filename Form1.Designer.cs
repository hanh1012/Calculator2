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
            this.btCong = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(507, 133);
            this.btCong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(84, 53);
            this.btCong.TabIndex = 0;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(292, 77);
            this.txta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(172, 34);
            this.txta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tính toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(292, 191);
            this.txtkq.Margin = new System.Windows.Forms.Padding(5);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(172, 34);
            this.txtkq.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số b:";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(292, 131);
            this.txtb.Margin = new System.Windows.Forms.Padding(5);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(172, 34);
            this.txtb.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btCong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb;
    }
}

