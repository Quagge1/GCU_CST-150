namespace Activity13
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
            this.buttonA1 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonB1 = new System.Windows.Forms.Button();
            this.buttonB2 = new System.Windows.Forms.Button();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.buttonC2 = new System.Windows.Forms.Button();
            this.buttonC3 = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonA1
            // 
            this.buttonA1.Location = new System.Drawing.Point(26, 24);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(100, 100);
            this.buttonA1.TabIndex = 0;
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.Click += new System.EventHandler(this.buttonA1_Click);
            // 
            // buttonA2
            // 
            this.buttonA2.Location = new System.Drawing.Point(132, 24);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(100, 100);
            this.buttonA2.TabIndex = 1;
            this.buttonA2.UseVisualStyleBackColor = true;
            this.buttonA2.Click += new System.EventHandler(this.buttonA2_Click);
            // 
            // buttonA3
            // 
            this.buttonA3.Location = new System.Drawing.Point(238, 24);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(100, 100);
            this.buttonA3.TabIndex = 2;
            this.buttonA3.UseVisualStyleBackColor = true;
            this.buttonA3.Click += new System.EventHandler(this.buttonA3_Click);
            // 
            // buttonB1
            // 
            this.buttonB1.Location = new System.Drawing.Point(26, 130);
            this.buttonB1.Name = "buttonB1";
            this.buttonB1.Size = new System.Drawing.Size(100, 100);
            this.buttonB1.TabIndex = 3;
            this.buttonB1.UseVisualStyleBackColor = true;
            this.buttonB1.Click += new System.EventHandler(this.buttonB1_Click);
            // 
            // buttonB2
            // 
            this.buttonB2.Location = new System.Drawing.Point(132, 130);
            this.buttonB2.Name = "buttonB2";
            this.buttonB2.Size = new System.Drawing.Size(100, 100);
            this.buttonB2.TabIndex = 4;
            this.buttonB2.UseVisualStyleBackColor = true;
            this.buttonB2.Click += new System.EventHandler(this.buttonB2_Click);
            // 
            // buttonB3
            // 
            this.buttonB3.Location = new System.Drawing.Point(238, 130);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(100, 100);
            this.buttonB3.TabIndex = 5;
            this.buttonB3.UseVisualStyleBackColor = true;
            this.buttonB3.Click += new System.EventHandler(this.buttonB3_Click);
            // 
            // buttonC1
            // 
            this.buttonC1.Location = new System.Drawing.Point(26, 236);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(100, 100);
            this.buttonC1.TabIndex = 6;
            this.buttonC1.UseVisualStyleBackColor = true;
            this.buttonC1.Click += new System.EventHandler(this.buttonC1_Click);
            // 
            // buttonC2
            // 
            this.buttonC2.Location = new System.Drawing.Point(132, 236);
            this.buttonC2.Name = "buttonC2";
            this.buttonC2.Size = new System.Drawing.Size(100, 100);
            this.buttonC2.TabIndex = 7;
            this.buttonC2.UseVisualStyleBackColor = true;
            this.buttonC2.Click += new System.EventHandler(this.buttonC2_Click);
            // 
            // buttonC3
            // 
            this.buttonC3.Location = new System.Drawing.Point(238, 236);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(100, 100);
            this.buttonC3.TabIndex = 8;
            this.buttonC3.UseVisualStyleBackColor = true;
            this.buttonC3.Click += new System.EventHandler(this.buttonC3_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(101, 384);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 9;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(195, 384);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 468);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.buttonC3);
            this.Controls.Add(this.buttonC2);
            this.Controls.Add(this.buttonC1);
            this.Controls.Add(this.buttonB3);
            this.Controls.Add(this.buttonB2);
            this.Controls.Add(this.buttonB1);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonA2);
            this.Controls.Add(this.buttonA1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonA1;
        private Button buttonA2;
        private Button buttonA3;
        private Button buttonB1;
        private Button buttonB2;
        private Button buttonB3;
        private Button buttonC1;
        private Button buttonC2;
        private Button buttonC3;
        private Button NewGame;
        private Button Exit;
    }
}