namespace Activity8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FatGrams = new System.Windows.Forms.TextBox();
            this.CarbGrams = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat Grams:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carbs Grams:";
            // 
            // FatGrams
            // 
            this.FatGrams.Location = new System.Drawing.Point(200, 76);
            this.FatGrams.Name = "FatGrams";
            this.FatGrams.Size = new System.Drawing.Size(100, 23);
            this.FatGrams.TabIndex = 2;
            // 
            // CarbGrams
            // 
            this.CarbGrams.Location = new System.Drawing.Point(200, 136);
            this.CarbGrams.Name = "CarbGrams";
            this.CarbGrams.Size = new System.Drawing.Size(100, 23);
            this.CarbGrams.TabIndex = 3;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(146, 211);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 43);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate Calories";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(238, 211);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 43);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit Form";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 299);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.CarbGrams);
            this.Controls.Add(this.FatGrams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FatGrams;
        private TextBox CarbGrams;
        private Button Calculate;
        private Button Exit;
    }
}