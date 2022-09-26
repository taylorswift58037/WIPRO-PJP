namespace EmployeeManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1insert = new System.Windows.Forms.Button();
            this.btn2update = new System.Windows.Forms.Button();
            this.btn3delete = new System.Windows.Forms.Button();
            this.btn4search = new System.Windows.Forms.Button();
            this.txt1title = new System.Windows.Forms.TextBox();
            this.exit1 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.userControl11 = new EmployeeManagement.UserControl1();
            this.userControl31 = new EmployeeManagement.UserControl3();
            this.userControl21 = new EmployeeManagement.UserControl2();
            this.userControl41 = new EmployeeManagement.UserControl4();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt1title);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.exit1);
            this.panel1.Controls.Add(this.btn4search);
            this.panel1.Controls.Add(this.btn3delete);
            this.panel1.Controls.Add(this.btn2update);
            this.panel1.Controls.Add(this.btn1insert);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 519);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn1insert
            // 
            this.btn1insert.Location = new System.Drawing.Point(450, 74);
            this.btn1insert.Name = "btn1insert";
            this.btn1insert.Size = new System.Drawing.Size(158, 48);
            this.btn1insert.TabIndex = 0;
            this.btn1insert.Text = "Insert";
            this.btn1insert.UseVisualStyleBackColor = true;
            this.btn1insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2update
            // 
            this.btn2update.Location = new System.Drawing.Point(450, 156);
            this.btn2update.Name = "btn2update";
            this.btn2update.Size = new System.Drawing.Size(158, 48);
            this.btn2update.TabIndex = 1;
            this.btn2update.Text = "Update";
            this.btn2update.UseVisualStyleBackColor = true;
            this.btn2update.Click += new System.EventHandler(this.btn2update_Click);
            // 
            // btn3delete
            // 
            this.btn3delete.Location = new System.Drawing.Point(450, 329);
            this.btn3delete.Name = "btn3delete";
            this.btn3delete.Size = new System.Drawing.Size(158, 45);
            this.btn3delete.TabIndex = 2;
            this.btn3delete.Text = "Delete";
            this.btn3delete.UseVisualStyleBackColor = true;
            this.btn3delete.Click += new System.EventHandler(this.btn3delete_Click);
            // 
            // btn4search
            // 
            this.btn4search.Location = new System.Drawing.Point(450, 240);
            this.btn4search.Name = "btn4search";
            this.btn4search.Size = new System.Drawing.Size(158, 47);
            this.btn4search.TabIndex = 3;
            this.btn4search.Text = "Search";
            this.btn4search.UseVisualStyleBackColor = true;
            this.btn4search.Click += new System.EventHandler(this.btn4search_Click);
            // 
            // txt1title
            // 
            this.txt1title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1title.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1title.Location = new System.Drawing.Point(218, 15);
            this.txt1title.Multiline = true;
            this.txt1title.Name = "txt1title";
            this.txt1title.ReadOnly = true;
            this.txt1title.Size = new System.Drawing.Size(312, 39);
            this.txt1title.TabIndex = 4;
            this.txt1title.Text = "EMPLOYEE DETAILS";
            this.txt1title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exit1
            // 
            this.exit1.Location = new System.Drawing.Point(88, 411);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(91, 36);
            this.exit1.TabIndex = 5;
            this.exit1.Text = "Exit";
            this.exit1.UseVisualStyleBackColor = true;
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(114, 87);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(224, 20);
            this.textBox10.TabIndex = 6;
            this.textBox10.Text = "Enter new Employee Details";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(114, 169);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(224, 20);
            this.textBox11.TabIndex = 7;
            this.textBox11.Text = "Upade Employee Details";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(114, 340);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(224, 20);
            this.textBox12.TabIndex = 8;
            this.textBox12.Text = "Delete Employee Details";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(114, 252);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(224, 20);
            this.textBox13.TabIndex = 9;
            this.textBox13.Text = "Search Employee";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(-6, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(819, 524);
            this.userControl11.TabIndex = 10;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(12, 12);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(686, 519);
            this.userControl31.TabIndex = 11;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(12, 3);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(786, 557);
            this.userControl21.TabIndex = 10;
            // 
            // userControl41
            // 
            this.userControl41.Location = new System.Drawing.Point(12, 12);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(801, 526);
            this.userControl41.TabIndex = 12;
            this.userControl41.Load += new System.EventHandler(this.userControl41_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl41);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button exit1;
        private System.Windows.Forms.TextBox txt1title;
        private System.Windows.Forms.Button btn4search;
        private System.Windows.Forms.Button btn3delete;
        private System.Windows.Forms.Button btn2update;
        private UserControl4 userControl41;
        private UserControl3 userControl31;
        private UserControl2 userControl21;
        private UserControl1 userControl11;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn1insert;
    }
}

