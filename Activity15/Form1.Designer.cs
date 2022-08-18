namespace Activity_15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BirthMonth = new System.Windows.Forms.Label();
            this.BirthDay = new System.Windows.Forms.Label();
            this.BirthYear = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UsrSign = new System.Windows.Forms.Label();
            this.Signtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BirthMonth
            // 
            this.BirthMonth.AutoSize = true;
            this.BirthMonth.Location = new System.Drawing.Point(46, 52);
            this.BirthMonth.Name = "BirthMonth";
            this.BirthMonth.Size = new System.Drawing.Size(131, 15);
            this.BirthMonth.TabIndex = 0;
            this.BirthMonth.Text = "Enter Your Birth Month:";
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.Location = new System.Drawing.Point(46, 87);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(115, 15);
            this.BirthDay.TabIndex = 1;
            this.BirthDay.Text = "Enter Your Birth Day:";
            // 
            // BirthYear
            // 
            this.BirthYear.AutoSize = true;
            this.BirthYear.Location = new System.Drawing.Point(46, 125);
            this.BirthYear.Name = "BirthYear";
            this.BirthYear.Size = new System.Drawing.Size(117, 15);
            this.BirthYear.TabIndex = 2;
            this.BirthYear.Text = "Enter Your Birth Year:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(205, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Find Out Your Lucky Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsrSign
            // 
            this.UsrSign.AutoSize = true;
            this.UsrSign.Location = new System.Drawing.Point(46, 162);
            this.UsrSign.Name = "UsrSign";
            this.UsrSign.Size = new System.Drawing.Size(129, 15);
            this.UsrSign.TabIndex = 3;
            this.UsrSign.Text = "Enter Your Zodiac Sign:";
            // 
            // Signtxt
            // 
            this.Signtxt.Location = new System.Drawing.Point(205, 159);
            this.Signtxt.Name = "Signtxt";
            this.Signtxt.Size = new System.Drawing.Size(100, 23);
            this.Signtxt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Signtxt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UsrSign);
            this.Controls.Add(this.BirthYear);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.BirthMonth);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BirthMonth;
        private Label BirthDay;
        private Label BirthYear;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label UsrSign;
        private TextBox Signtxt;
    }
}