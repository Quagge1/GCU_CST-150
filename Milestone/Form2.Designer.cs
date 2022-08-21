namespace Milestone
{
    partial class Form2Cart
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
            this.Cart = new System.Windows.Forms.ListBox();
            this.pictureOfCart = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfCart)).BeginInit();
            this.SuspendLayout();
            // 
            // Cart
            // 
            this.Cart.FormattingEnabled = true;
            this.Cart.ItemHeight = 15;
            this.Cart.Location = new System.Drawing.Point(297, 135);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(189, 154);
            this.Cart.TabIndex = 0;
            // 
            // pictureOfCart
            // 
            this.pictureOfCart.Location = new System.Drawing.Point(67, 135);
            this.pictureOfCart.Name = "pictureOfCart";
            this.pictureOfCart.Size = new System.Drawing.Size(158, 136);
            this.pictureOfCart.TabIndex = 1;
            this.pictureOfCart.TabStop = false;
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(319, 372);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(75, 40);
            this.Main.TabIndex = 2;
            this.Main.Text = "Main Menu";
            this.Main.UseVisualStyleBackColor = true;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Place Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Empty Cart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.pictureOfCart);
            this.Controls.Add(this.Cart);
            this.Name = "Form2Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Form2Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox Cart;
        private PictureBox pictureOfCart;
        private Button Main;
        private Button button2;
        private Button button3;
    }
}