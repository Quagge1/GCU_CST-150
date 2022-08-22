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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Cart));
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
            this.Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Cart.FormattingEnabled = true;
            this.Cart.ItemHeight = 20;
            this.Cart.Location = new System.Drawing.Point(297, 88);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(260, 124);
            this.Cart.TabIndex = 0;
            // 
            // pictureOfCart
            // 
            this.pictureOfCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pictureOfCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureOfCart.BackgroundImage")));
            this.pictureOfCart.Location = new System.Drawing.Point(31, 88);
            this.pictureOfCart.Name = "pictureOfCart";
            this.pictureOfCart.Size = new System.Drawing.Size(260, 239);
            this.pictureOfCart.TabIndex = 1;
            this.pictureOfCart.TabStop = false;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.LightCoral;
            this.Main.ForeColor = System.Drawing.Color.White;
            this.Main.Location = new System.Drawing.Point(297, 287);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(75, 40);
            this.Main.TabIndex = 2;
            this.Main.Text = "Main Menu";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(378, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Place Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(459, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Empty Cart";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(569, 406);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.pictureOfCart);
            this.Controls.Add(this.Cart);
            this.Name = "Form2Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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