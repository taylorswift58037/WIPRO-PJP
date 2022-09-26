namespace EmployeeManagement
{
    partial class UserControl4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2IN = new System.Windows.Forms.Panel();
            this.txttitle2 = new System.Windows.Forms.TextBox();
            this.btnexit2 = new System.Windows.Forms.Button();
            this.btn3back = new System.Windows.Forms.Button();
            this.btnsub2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2IN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2IN
            // 
            this.panel2IN.Controls.Add(this.txttitle2);
            this.panel2IN.Controls.Add(this.btnexit2);
            this.panel2IN.Controls.Add(this.btn3back);
            this.panel2IN.Controls.Add(this.btnsub2);
            this.panel2IN.Controls.Add(this.textBox5);
            this.panel2IN.Controls.Add(this.textBox1);
            this.panel2IN.Location = new System.Drawing.Point(26, 39);
            this.panel2IN.Name = "panel2IN";
            this.panel2IN.Size = new System.Drawing.Size(673, 428);
            this.panel2IN.TabIndex = 8;
            // 
            // txttitle2
            // 
            this.txttitle2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttitle2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle2.Location = new System.Drawing.Point(278, 13);
            this.txttitle2.Name = "txttitle2";
            this.txttitle2.ReadOnly = true;
            this.txttitle2.Size = new System.Drawing.Size(315, 31);
            this.txttitle2.TabIndex = 13;
            this.txttitle2.Text = "Delete";
            // 
            // btnexit2
            // 
            this.btnexit2.Location = new System.Drawing.Point(75, 347);
            this.btnexit2.Name = "btnexit2";
            this.btnexit2.Size = new System.Drawing.Size(94, 36);
            this.btnexit2.TabIndex = 12;
            this.btnexit2.Text = "Exit";
            this.btnexit2.UseVisualStyleBackColor = true;
            this.btnexit2.Click += new System.EventHandler(this.btnexit2_Click);
            // 
            // btn3back
            // 
            this.btn3back.Location = new System.Drawing.Point(343, 154);
            this.btn3back.Name = "btn3back";
            this.btn3back.Size = new System.Drawing.Size(87, 36);
            this.btn3back.TabIndex = 11;
            this.btn3back.Text = "Cancel";
            this.btn3back.UseVisualStyleBackColor = true;
            this.btn3back.Click += new System.EventHandler(this.btn3back_Click);
            // 
            // btnsub2
            // 
            this.btnsub2.Location = new System.Drawing.Point(191, 154);
            this.btnsub2.Name = "btnsub2";
            this.btnsub2.Size = new System.Drawing.Size(98, 36);
            this.btnsub2.TabIndex = 10;
            this.btnsub2.Text = "Delete";
            this.btnsub2.UseVisualStyleBackColor = true;
            this.btnsub2.Click += new System.EventHandler(this.btnsub2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(75, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(214, 22);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "EmployeeID";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 0;
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2IN);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(733, 526);
            this.panel2IN.ResumeLayout(false);
            this.panel2IN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2IN;
        private System.Windows.Forms.TextBox txttitle2;
        private System.Windows.Forms.Button btnexit2;
        private System.Windows.Forms.Button btn3back;
        private System.Windows.Forms.Button btnsub2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
    }
}
