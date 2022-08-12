namespace Activity_14
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
            this.ArmorLstBx = new System.Windows.Forms.ListBox();
            this.Potion = new System.Windows.Forms.RadioButton();
            this.Elixer = new System.Windows.Forms.RadioButton();
            this.Remedy = new System.Windows.Forms.RadioButton();
            this.Sword = new System.Windows.Forms.CheckBox();
            this.Spear = new System.Windows.Forms.CheckBox();
            this.Shield = new System.Windows.Forms.CheckBox();
            this.Consumables = new System.Windows.Forms.GroupBox();
            this.Weapons = new System.Windows.Forms.GroupBox();
            this.Armor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FormLabel = new System.Windows.Forms.Label();
            this.Consumables.SuspendLayout();
            this.Weapons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArmorLstBx
            // 
            this.ArmorLstBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArmorLstBx.FormattingEnabled = true;
            this.ArmorLstBx.ItemHeight = 17;
            this.ArmorLstBx.Items.AddRange(new object[] {
            "Breast Plate",
            "Helmet",
            "Grieves"});
            this.ArmorLstBx.Location = new System.Drawing.Point(230, 63);
            this.ArmorLstBx.Name = "ArmorLstBx";
            this.ArmorLstBx.Size = new System.Drawing.Size(80, 72);
            this.ArmorLstBx.TabIndex = 0;
            // 
            // Potion
            // 
            this.Potion.AutoSize = true;
            this.Potion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Potion.Location = new System.Drawing.Point(6, 22);
            this.Potion.Name = "Potion";
            this.Potion.Size = new System.Drawing.Size(63, 21);
            this.Potion.TabIndex = 1;
            this.Potion.TabStop = true;
            this.Potion.Text = "Potion";
            this.Potion.UseVisualStyleBackColor = true;
            // 
            // Elixer
            // 
            this.Elixer.AutoSize = true;
            this.Elixer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Elixer.Location = new System.Drawing.Point(6, 47);
            this.Elixer.Name = "Elixer";
            this.Elixer.Size = new System.Drawing.Size(57, 21);
            this.Elixer.TabIndex = 2;
            this.Elixer.TabStop = true;
            this.Elixer.Text = "Elixer";
            this.Elixer.UseVisualStyleBackColor = true;
            // 
            // Remedy
            // 
            this.Remedy.AutoSize = true;
            this.Remedy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Remedy.Location = new System.Drawing.Point(6, 72);
            this.Remedy.Name = "Remedy";
            this.Remedy.Size = new System.Drawing.Size(73, 21);
            this.Remedy.TabIndex = 3;
            this.Remedy.TabStop = true;
            this.Remedy.Text = "Remedy";
            this.Remedy.UseVisualStyleBackColor = true;
            // 
            // Sword
            // 
            this.Sword.AutoSize = true;
            this.Sword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sword.Location = new System.Drawing.Point(6, 19);
            this.Sword.Name = "Sword";
            this.Sword.Size = new System.Drawing.Size(64, 21);
            this.Sword.TabIndex = 4;
            this.Sword.Text = "Sword";
            this.Sword.UseVisualStyleBackColor = true;
            // 
            // Spear
            // 
            this.Spear.AutoSize = true;
            this.Spear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Spear.Location = new System.Drawing.Point(6, 44);
            this.Spear.Name = "Spear";
            this.Spear.Size = new System.Drawing.Size(61, 21);
            this.Spear.TabIndex = 5;
            this.Spear.Text = "Spear";
            this.Spear.UseVisualStyleBackColor = true;
            // 
            // Shield
            // 
            this.Shield.AutoSize = true;
            this.Shield.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Shield.Location = new System.Drawing.Point(6, 72);
            this.Shield.Name = "Shield";
            this.Shield.Size = new System.Drawing.Size(62, 21);
            this.Shield.TabIndex = 6;
            this.Shield.Text = "Shield";
            this.Shield.UseVisualStyleBackColor = true;
            // 
            // Consumables
            // 
            this.Consumables.Controls.Add(this.Potion);
            this.Consumables.Controls.Add(this.Elixer);
            this.Consumables.Controls.Add(this.Remedy);
            this.Consumables.Location = new System.Drawing.Point(12, 41);
            this.Consumables.Name = "Consumables";
            this.Consumables.Size = new System.Drawing.Size(108, 100);
            this.Consumables.TabIndex = 7;
            this.Consumables.TabStop = false;
            this.Consumables.Text = "Consumables";
            // 
            // Weapons
            // 
            this.Weapons.Controls.Add(this.Spear);
            this.Weapons.Controls.Add(this.Sword);
            this.Weapons.Controls.Add(this.Shield);
            this.Weapons.Location = new System.Drawing.Point(126, 41);
            this.Weapons.Name = "Weapons";
            this.Weapons.Size = new System.Drawing.Size(98, 100);
            this.Weapons.TabIndex = 8;
            this.Weapons.TabStop = false;
            this.Weapons.Text = "Weapons";
            // 
            // Armor
            // 
            this.Armor.AutoSize = true;
            this.Armor.Location = new System.Drawing.Point(230, 41);
            this.Armor.Name = "Armor";
            this.Armor.Size = new System.Drawing.Size(41, 15);
            this.Armor.TabIndex = 9;
            this.Armor.Text = "Armor";
            this.Armor.Click += new System.EventHandler(this.Armor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Click to Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Location = new System.Drawing.Point(119, 9);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(105, 15);
            this.FormLabel.TabIndex = 11;
            this.FormLabel.Text = "Select One of Each";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 228);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Armor);
            this.Controls.Add(this.Weapons);
            this.Controls.Add(this.Consumables);
            this.Controls.Add(this.ArmorLstBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Consumables.ResumeLayout(false);
            this.Consumables.PerformLayout();
            this.Weapons.ResumeLayout(false);
            this.Weapons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ArmorLstBx;
        private RadioButton Potion;
        private RadioButton Elixer;
        private RadioButton Remedy;
        private CheckBox Sword;
        private CheckBox Spear;
        private CheckBox Shield;
        private GroupBox Consumables;
        private GroupBox Weapons;
        private Label Armor;
        private Button button1;
        private Label FormLabel;
    }
}