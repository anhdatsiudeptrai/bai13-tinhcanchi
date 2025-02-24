namespace bai13_tinhcanchi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.lsbkq = new System.Windows.Forms.ListBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NĂM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "KẾT QUẢ";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(218, 115);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(175, 23);
            this.txtnam.TabIndex = 1;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(218, 156);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(175, 23);
            this.txtkq.TabIndex = 1;
            // 
            // lsbkq
            // 
            this.lsbkq.FormattingEnabled = true;
            this.lsbkq.ItemHeight = 16;
            this.lsbkq.Location = new System.Drawing.Point(606, 96);
            this.lsbkq.Name = "lsbkq";
            this.lsbkq.Size = new System.Drawing.Size(248, 356);
            this.lsbkq.TabIndex = 2;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(399, 115);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "TÍNH";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(399, 156);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lsbkq);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.ListBox lsbkq;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button btnexit;
    }
}

