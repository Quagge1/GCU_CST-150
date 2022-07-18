namespace Milestone
{
    partial class Form3Orders
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cart
            // 
            this.Cart.FormattingEnabled = true;
            this.Cart.ItemHeight = 15;
            this.Cart.Location = new System.Drawing.Point(72, 98);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(328, 169);
            this.Cart.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Place Order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form3Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cart);
            this.Name = "Form3Orders";
            this.Text = "Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox Cart;
        private Button button1;
        private Button button2;
    }
}