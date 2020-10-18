namespace Beagle_Boys_Pizza
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
            if (disposing && (components != null)) {
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblOrdername = new System.Windows.Forms.Label();
            this.lblSauce = new System.Windows.Forms.Label();
            this.lblsurcharge = new System.Windows.Forms.Label();
            this.lbltoppingprice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbSauce = new System.Windows.Forms.ComboBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdoGlutenfree = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkCapsicum = new System.Windows.Forms.CheckBox();
            this.chkJalepenos = new System.Windows.Forms.CheckBox();
            this.chkFeta = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkPrawn = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.chkGroundbeef = new System.Windows.Forms.CheckBox();
            this.chkCheddar = new System.Windows.Forms.CheckBox();
            this.chkMozzarella = new System.Windows.Forms.CheckBox();
            this.btnorder = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.grpCrust.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(12, 19);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(307, 24);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Welcome to Beagle Boys Pizza!";
            // 
            // lblOrdername
            // 
            this.lblOrdername.AutoSize = true;
            this.lblOrdername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdername.Location = new System.Drawing.Point(28, 91);
            this.lblOrdername.Name = "lblOrdername";
            this.lblOrdername.Size = new System.Drawing.Size(108, 19);
            this.lblOrdername.TabIndex = 1;
            this.lblOrdername.Text = "Order name: ";
            // 
            // lblSauce
            // 
            this.lblSauce.AutoSize = true;
            this.lblSauce.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSauce.Location = new System.Drawing.Point(73, 142);
            this.lblSauce.Name = "lblSauce";
            this.lblSauce.Size = new System.Drawing.Size(63, 19);
            this.lblSauce.TabIndex = 2;
            this.lblSauce.Text = "Sauce:";
            // 
            // lblsurcharge
            // 
            this.lblsurcharge.AutoSize = true;
            this.lblsurcharge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsurcharge.Location = new System.Drawing.Point(23, 114);
            this.lblsurcharge.Name = "lblsurcharge";
            this.lblsurcharge.Size = new System.Drawing.Size(171, 19);
            this.lblsurcharge.TabIndex = 3;
            this.lblsurcharge.Text = "* Incurs $2 surcharge";
            // 
            // lbltoppingprice
            // 
            this.lbltoppingprice.AutoSize = true;
            this.lbltoppingprice.Font = new System.Drawing.Font("SimSun", 9F);
            this.lbltoppingprice.Location = new System.Drawing.Point(155, 204);
            this.lbltoppingprice.Name = "lbltoppingprice";
            this.lbltoppingprice.Size = new System.Drawing.Size(203, 24);
            this.lbltoppingprice.TabIndex = 4;
            this.lbltoppingprice.Text = "Choose your toppings.\r\nEach topping after 4 costs $1.00.";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 21);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cmbSauce
            // 
            this.cmbSauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSauce.Enabled = false;
            this.cmbSauce.FormattingEnabled = true;
            this.cmbSauce.Items.AddRange(new object[] {
            "Tomato",
            "Barbeque"});
            this.cmbSauce.Location = new System.Drawing.Point(158, 144);
            this.cmbSauce.Name = "cmbSauce";
            this.cmbSauce.Size = new System.Drawing.Size(161, 20);
            this.cmbSauce.TabIndex = 6;
            this.cmbSauce.SelectedIndexChanged += new System.EventHandler(this.cmbSauce_SelectedIndexChanged);
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdoGlutenfree);
            this.grpCrust.Controls.Add(this.rdoThick);
            this.grpCrust.Controls.Add(this.rdoThin);
            this.grpCrust.Controls.Add(this.lblsurcharge);
            this.grpCrust.Enabled = false;
            this.grpCrust.Location = new System.Drawing.Point(16, 197);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(303, 158);
            this.grpCrust.TabIndex = 7;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            // 
            // rdoGlutenfree
            // 
            this.rdoGlutenfree.AutoSize = true;
            this.rdoGlutenfree.Location = new System.Drawing.Point(25, 81);
            this.rdoGlutenfree.Name = "rdoGlutenfree";
            this.rdoGlutenfree.Size = new System.Drawing.Size(95, 16);
            this.rdoGlutenfree.TabIndex = 10;
            this.rdoGlutenfree.TabStop = true;
            this.rdoGlutenfree.Text = "Gluten free*";
            this.rdoGlutenfree.UseVisualStyleBackColor = true;
            this.rdoGlutenfree.CheckedChanged += new System.EventHandler(this.rdoCrustType_CheckedChanged);
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(25, 59);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(53, 16);
            this.rdoThick.TabIndex = 9;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            this.rdoThick.CheckedChanged += new System.EventHandler(this.rdoCrustType_CheckedChanged);
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(25, 37);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(47, 16);
            this.rdoThin.TabIndex = 8;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            this.rdoThin.CheckedChanged += new System.EventHandler(this.rdoCrustType_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkBacon);
            this.grpToppings.Controls.Add(this.chkOlives);
            this.grpToppings.Controls.Add(this.chkPineapple);
            this.grpToppings.Controls.Add(this.chkTomatoes);
            this.grpToppings.Controls.Add(this.lbltoppingprice);
            this.grpToppings.Controls.Add(this.chkCapsicum);
            this.grpToppings.Controls.Add(this.chkJalepenos);
            this.grpToppings.Controls.Add(this.chkFeta);
            this.grpToppings.Controls.Add(this.chkChicken);
            this.grpToppings.Controls.Add(this.chkMushroom);
            this.grpToppings.Controls.Add(this.chkPrawn);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Controls.Add(this.chkHam);
            this.grpToppings.Controls.Add(this.chkSpinach);
            this.grpToppings.Controls.Add(this.chkGroundbeef);
            this.grpToppings.Controls.Add(this.chkCheddar);
            this.grpToppings.Controls.Add(this.chkMozzarella);
            this.grpToppings.Enabled = false;
            this.grpToppings.Location = new System.Drawing.Point(369, 111);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(398, 244);
            this.grpToppings.TabIndex = 8;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(21, 204);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(54, 16);
            this.chkBacon.TabIndex = 23;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            this.chkBacon.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(286, 20);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(60, 16);
            this.chkOlives.TabIndex = 24;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(286, 164);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(78, 16);
            this.chkPineapple.TabIndex = 22;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(21, 20);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(72, 16);
            this.chkTomatoes.TabIndex = 9;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkCapsicum
            // 
            this.chkCapsicum.AutoSize = true;
            this.chkCapsicum.Location = new System.Drawing.Point(286, 130);
            this.chkCapsicum.Name = "chkCapsicum";
            this.chkCapsicum.Size = new System.Drawing.Size(72, 16);
            this.chkCapsicum.TabIndex = 21;
            this.chkCapsicum.Text = "Capsicum";
            this.chkCapsicum.UseVisualStyleBackColor = true;
            this.chkCapsicum.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkJalepenos
            // 
            this.chkJalepenos.AutoSize = true;
            this.chkJalepenos.Location = new System.Drawing.Point(21, 55);
            this.chkJalepenos.Name = "chkJalepenos";
            this.chkJalepenos.Size = new System.Drawing.Size(78, 16);
            this.chkJalepenos.TabIndex = 10;
            this.chkJalepenos.Text = "Jalepenos";
            this.chkJalepenos.UseVisualStyleBackColor = true;
            this.chkJalepenos.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkFeta
            // 
            this.chkFeta.AutoSize = true;
            this.chkFeta.Location = new System.Drawing.Point(286, 95);
            this.chkFeta.Name = "chkFeta";
            this.chkFeta.Size = new System.Drawing.Size(48, 16);
            this.chkFeta.TabIndex = 20;
            this.chkFeta.Text = "Feta";
            this.chkFeta.UseVisualStyleBackColor = true;
            this.chkFeta.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(21, 95);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(66, 16);
            this.chkChicken.TabIndex = 11;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            this.chkChicken.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(286, 55);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(72, 16);
            this.chkMushroom.TabIndex = 19;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkPrawn
            // 
            this.chkPrawn.AutoSize = true;
            this.chkPrawn.Location = new System.Drawing.Point(21, 130);
            this.chkPrawn.Name = "chkPrawn";
            this.chkPrawn.Size = new System.Drawing.Size(54, 16);
            this.chkPrawn.TabIndex = 12;
            this.chkPrawn.Text = "Prawn";
            this.chkPrawn.UseVisualStyleBackColor = true;
            this.chkPrawn.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(21, 164);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(78, 16);
            this.chkPepperoni.TabIndex = 13;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(157, 20);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(42, 16);
            this.chkHam.TabIndex = 14;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkSpinach
            // 
            this.chkSpinach.AutoSize = true;
            this.chkSpinach.Location = new System.Drawing.Point(157, 164);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(66, 16);
            this.chkSpinach.TabIndex = 18;
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            this.chkSpinach.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkGroundbeef
            // 
            this.chkGroundbeef.AutoSize = true;
            this.chkGroundbeef.Location = new System.Drawing.Point(157, 55);
            this.chkGroundbeef.Name = "chkGroundbeef";
            this.chkGroundbeef.Size = new System.Drawing.Size(90, 16);
            this.chkGroundbeef.TabIndex = 15;
            this.chkGroundbeef.Text = "Ground beef";
            this.chkGroundbeef.UseVisualStyleBackColor = true;
            this.chkGroundbeef.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkCheddar
            // 
            this.chkCheddar.AutoSize = true;
            this.chkCheddar.Location = new System.Drawing.Point(157, 130);
            this.chkCheddar.Name = "chkCheddar";
            this.chkCheddar.Size = new System.Drawing.Size(66, 16);
            this.chkCheddar.TabIndex = 17;
            this.chkCheddar.Text = "Cheddar";
            this.chkCheddar.UseVisualStyleBackColor = true;
            this.chkCheddar.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkMozzarella
            // 
            this.chkMozzarella.AutoSize = true;
            this.chkMozzarella.Location = new System.Drawing.Point(157, 95);
            this.chkMozzarella.Name = "chkMozzarella";
            this.chkMozzarella.Size = new System.Drawing.Size(84, 16);
            this.chkMozzarella.TabIndex = 16;
            this.chkMozzarella.Text = "Mozzarella";
            this.chkMozzarella.UseVisualStyleBackColor = true;
            this.chkMozzarella.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // btnorder
            // 
            this.btnorder.Enabled = false;
            this.btnorder.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Location = new System.Drawing.Point(369, 383);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(398, 46);
            this.btnorder.TabIndex = 9;
            this.btnorder.Text = "Place Order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(64, 395);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 23);
            this.lblPrice.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.cmbSauce);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSauce);
            this.Controls.Add(this.lblOrdername);
            this.Controls.Add(this.lbltitle);
            this.Name = "Form1";
            this.Text = "Beagle Boys Pizza";
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblOrdername;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.Label lblsurcharge;
        private System.Windows.Forms.Label lbltoppingprice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbSauce;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton rdoGlutenfree;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkJalepenos;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkCapsicum;
        private System.Windows.Forms.CheckBox chkFeta;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkPrawn;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkSpinach;
        private System.Windows.Forms.CheckBox chkGroundbeef;
        private System.Windows.Forms.CheckBox chkCheddar;
        private System.Windows.Forms.CheckBox chkMozzarella;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Label lblPrice;
    }
}

