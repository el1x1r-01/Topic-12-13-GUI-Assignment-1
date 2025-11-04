namespace Topic_12_13_GUI_Assignment_1
{
    partial class FormSandwichOrder
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
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radRegular = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.grpBread = new System.Windows.Forms.GroupBox();
            this.radCheesyBread = new System.Windows.Forms.RadioButton();
            this.radGlutenFree = new System.Windows.Forms.RadioButton();
            this.radFlatbread = new System.Windows.Forms.RadioButton();
            this.radWhiteBread = new System.Windows.Forms.RadioButton();
            this.radMultiGrain = new System.Windows.Forms.RadioButton();
            this.radWholeWheat = new System.Windows.Forms.RadioButton();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkTurkey = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.chkCucumber = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTeriyaki = new System.Windows.Forms.CheckBox();
            this.chkMustard = new System.Windows.Forms.CheckBox();
            this.chkRanch = new System.Windows.Forms.CheckBox();
            this.chkMayo = new System.Windows.Forms.CheckBox();
            this.grpCheese = new System.Windows.Forms.GroupBox();
            this.radSwiss = new System.Windows.Forms.RadioButton();
            this.radParmesan = new System.Windows.Forms.RadioButton();
            this.radCheddar = new System.Windows.Forms.RadioButton();
            this.radMozzarella = new System.Windows.Forms.RadioButton();
            this.imgDecal1 = new System.Windows.Forms.PictureBox();
            this.radNoCheese = new System.Windows.Forms.RadioButton();
            this.radDairyFreeCheese = new System.Windows.Forms.RadioButton();
            this.radAmericanCheese = new System.Windows.Forms.RadioButton();
            this.radGouda = new System.Windows.Forms.RadioButton();
            this.lblToppingsSection1 = new System.Windows.Forms.Label();
            this.lblToppingsSection2 = new System.Windows.Forms.Label();
            this.lblToppingsSection3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grpSize.SuspendLayout();
            this.grpBread.SuspendLayout();
            this.grpCheese.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDecal1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.Color.Transparent;
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radRegular);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.ForeColor = System.Drawing.Color.White;
            this.grpSize.Location = new System.Drawing.Point(46, 31);
            this.grpSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSize.Size = new System.Drawing.Size(169, 141);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Sandwich Size";
            this.grpSize.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLarge.Location = new System.Drawing.Point(16, 96);
            this.radLarge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(125, 24);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large ($8.00)";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRegular.Location = new System.Drawing.Point(16, 63);
            this.radRegular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radRegular.Name = "radRegular";
            this.radRegular.Size = new System.Drawing.Size(135, 24);
            this.radRegular.TabIndex = 1;
            this.radRegular.TabStop = true;
            this.radRegular.Text = "Regular ($6.50)";
            this.radRegular.UseVisualStyleBackColor = true;
            this.radRegular.CheckedChanged += new System.EventHandler(this.radRegular_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSmall.Location = new System.Drawing.Point(16, 31);
            this.radSmall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(120, 24);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small ($4.00)";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // grpBread
            // 
            this.grpBread.BackColor = System.Drawing.Color.Transparent;
            this.grpBread.Controls.Add(this.radCheesyBread);
            this.grpBread.Controls.Add(this.radGlutenFree);
            this.grpBread.Controls.Add(this.radFlatbread);
            this.grpBread.Controls.Add(this.radWhiteBread);
            this.grpBread.Controls.Add(this.radMultiGrain);
            this.grpBread.Controls.Add(this.radWholeWheat);
            this.grpBread.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBread.ForeColor = System.Drawing.Color.White;
            this.grpBread.Location = new System.Drawing.Point(232, 31);
            this.grpBread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBread.Name = "grpBread";
            this.grpBread.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBread.Size = new System.Drawing.Size(360, 141);
            this.grpBread.TabIndex = 3;
            this.grpBread.TabStop = false;
            this.grpBread.Text = "Bread";
            // 
            // radCheesyBread
            // 
            this.radCheesyBread.AutoSize = true;
            this.radCheesyBread.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheesyBread.Location = new System.Drawing.Point(147, 96);
            this.radCheesyBread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radCheesyBread.Name = "radCheesyBread";
            this.radCheesyBread.Size = new System.Drawing.Size(187, 24);
            this.radCheesyBread.TabIndex = 5;
            this.radCheesyBread.TabStop = true;
            this.radCheesyBread.Text = "Cheesy bread (+ $2.00)";
            this.radCheesyBread.UseVisualStyleBackColor = true;
            this.radCheesyBread.CheckedChanged += new System.EventHandler(this.radCheesyBread_CheckedChanged);
            // 
            // radGlutenFree
            // 
            this.radGlutenFree.AutoSize = true;
            this.radGlutenFree.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGlutenFree.Location = new System.Drawing.Point(147, 63);
            this.radGlutenFree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radGlutenFree.Name = "radGlutenFree";
            this.radGlutenFree.Size = new System.Drawing.Size(176, 24);
            this.radGlutenFree.TabIndex = 4;
            this.radGlutenFree.TabStop = true;
            this.radGlutenFree.Text = "Gluten free (+ $2.00)";
            this.radGlutenFree.UseVisualStyleBackColor = true;
            this.radGlutenFree.CheckedChanged += new System.EventHandler(this.radGlutenFree_CheckedChanged);
            // 
            // radFlatbread
            // 
            this.radFlatbread.AutoSize = true;
            this.radFlatbread.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFlatbread.Location = new System.Drawing.Point(147, 31);
            this.radFlatbread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radFlatbread.Name = "radFlatbread";
            this.radFlatbread.Size = new System.Drawing.Size(93, 24);
            this.radFlatbread.TabIndex = 3;
            this.radFlatbread.TabStop = true;
            this.radFlatbread.Text = "Flatbread";
            this.radFlatbread.UseVisualStyleBackColor = true;
            this.radFlatbread.CheckedChanged += new System.EventHandler(this.radFlatbread_CheckedChanged);
            // 
            // radWhiteBread
            // 
            this.radWhiteBread.AutoSize = true;
            this.radWhiteBread.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWhiteBread.Location = new System.Drawing.Point(16, 96);
            this.radWhiteBread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radWhiteBread.Name = "radWhiteBread";
            this.radWhiteBread.Size = new System.Drawing.Size(65, 24);
            this.radWhiteBread.TabIndex = 2;
            this.radWhiteBread.TabStop = true;
            this.radWhiteBread.Text = "White";
            this.radWhiteBread.UseVisualStyleBackColor = true;
            this.radWhiteBread.CheckedChanged += new System.EventHandler(this.radWhiteBread_CheckedChanged);
            // 
            // radMultiGrain
            // 
            this.radMultiGrain.AutoSize = true;
            this.radMultiGrain.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiGrain.Location = new System.Drawing.Point(16, 63);
            this.radMultiGrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radMultiGrain.Name = "radMultiGrain";
            this.radMultiGrain.Size = new System.Drawing.Size(101, 24);
            this.radMultiGrain.TabIndex = 1;
            this.radMultiGrain.TabStop = true;
            this.radMultiGrain.Text = "Multi-grain";
            this.radMultiGrain.UseVisualStyleBackColor = true;
            this.radMultiGrain.CheckedChanged += new System.EventHandler(this.radMultiGrain_CheckedChanged);
            // 
            // radWholeWheat
            // 
            this.radWholeWheat.AutoSize = true;
            this.radWholeWheat.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWholeWheat.Location = new System.Drawing.Point(16, 31);
            this.radWholeWheat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radWholeWheat.Name = "radWholeWheat";
            this.radWholeWheat.Size = new System.Drawing.Size(112, 24);
            this.radWholeWheat.TabIndex = 0;
            this.radWholeWheat.TabStop = true;
            this.radWholeWheat.Text = "Whole wheat";
            this.radWholeWheat.UseVisualStyleBackColor = true;
            this.radWholeWheat.CheckedChanged += new System.EventHandler(this.radWholeWheat_CheckedChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrice.Location = new System.Drawing.Point(429, 371);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(139, 20);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total price = $0.00";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.SystemColors.Control;
            this.lblToppings.Location = new System.Drawing.Point(42, 180);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(100, 19);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "Toppings:";
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.BackColor = System.Drawing.Color.Transparent;
            this.chkHam.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.ForeColor = System.Drawing.SystemColors.Control;
            this.chkHam.Location = new System.Drawing.Point(60, 230);
            this.chkHam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(57, 23);
            this.chkHam.TabIndex = 6;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = false;
            this.chkHam.CheckedChanged += new System.EventHandler(this.chkHam_CheckedChanged);
            // 
            // chkTurkey
            // 
            this.chkTurkey.AutoSize = true;
            this.chkTurkey.BackColor = System.Drawing.Color.Transparent;
            this.chkTurkey.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTurkey.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTurkey.Location = new System.Drawing.Point(60, 258);
            this.chkTurkey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTurkey.Name = "chkTurkey";
            this.chkTurkey.Size = new System.Drawing.Size(72, 23);
            this.chkTurkey.TabIndex = 7;
            this.chkTurkey.Text = "Turkey";
            this.chkTurkey.UseVisualStyleBackColor = false;
            this.chkTurkey.CheckedChanged += new System.EventHandler(this.chkTurkey_CheckedChanged);
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.BackColor = System.Drawing.Color.Transparent;
            this.chkChicken.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChicken.ForeColor = System.Drawing.SystemColors.Control;
            this.chkChicken.Location = new System.Drawing.Point(60, 287);
            this.chkChicken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(74, 23);
            this.chkChicken.TabIndex = 8;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = false;
            this.chkChicken.CheckedChanged += new System.EventHandler(this.chkChicken_CheckedChanged);
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.BackColor = System.Drawing.Color.Transparent;
            this.chkBacon.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBacon.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBacon.Location = new System.Drawing.Point(60, 315);
            this.chkBacon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(65, 23);
            this.chkBacon.TabIndex = 9;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = false;
            this.chkBacon.CheckedChanged += new System.EventHandler(this.chkBacon_CheckedChanged);
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.BackColor = System.Drawing.Color.Transparent;
            this.chkLettuce.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLettuce.ForeColor = System.Drawing.SystemColors.Control;
            this.chkLettuce.Location = new System.Drawing.Point(169, 315);
            this.chkLettuce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(78, 23);
            this.chkLettuce.TabIndex = 13;
            this.chkLettuce.Text = "Lettuce";
            this.chkLettuce.UseVisualStyleBackColor = false;
            this.chkLettuce.CheckedChanged += new System.EventHandler(this.chkLettuce_CheckedChanged);
            // 
            // chkCucumber
            // 
            this.chkCucumber.AutoSize = true;
            this.chkCucumber.BackColor = System.Drawing.Color.Transparent;
            this.chkCucumber.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCucumber.ForeColor = System.Drawing.SystemColors.Control;
            this.chkCucumber.Location = new System.Drawing.Point(169, 287);
            this.chkCucumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCucumber.Name = "chkCucumber";
            this.chkCucumber.Size = new System.Drawing.Size(88, 23);
            this.chkCucumber.TabIndex = 12;
            this.chkCucumber.Text = "Cucumber";
            this.chkCucumber.UseVisualStyleBackColor = false;
            this.chkCucumber.CheckedChanged += new System.EventHandler(this.chkCucumber_CheckedChanged);
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.BackColor = System.Drawing.Color.Transparent;
            this.chkTomato.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomato.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTomato.Location = new System.Drawing.Point(169, 258);
            this.chkTomato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(77, 23);
            this.chkTomato.TabIndex = 11;
            this.chkTomato.Text = "Tomato";
            this.chkTomato.UseVisualStyleBackColor = false;
            this.chkTomato.CheckedChanged += new System.EventHandler(this.chkTomato_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.BackColor = System.Drawing.Color.Transparent;
            this.chkOnion.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.ForeColor = System.Drawing.SystemColors.Control;
            this.chkOnion.Location = new System.Drawing.Point(169, 230);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(62, 23);
            this.chkOnion.TabIndex = 10;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = false;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTeriyaki
            // 
            this.chkTeriyaki.AutoSize = true;
            this.chkTeriyaki.BackColor = System.Drawing.Color.Transparent;
            this.chkTeriyaki.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTeriyaki.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTeriyaki.Location = new System.Drawing.Point(284, 315);
            this.chkTeriyaki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTeriyaki.Name = "chkTeriyaki";
            this.chkTeriyaki.Size = new System.Drawing.Size(118, 23);
            this.chkTeriyaki.TabIndex = 17;
            this.chkTeriyaki.Text = "Teriyaki sauce";
            this.chkTeriyaki.UseVisualStyleBackColor = false;
            this.chkTeriyaki.CheckedChanged += new System.EventHandler(this.chkTeriyaki_CheckedChanged);
            // 
            // chkMustard
            // 
            this.chkMustard.AutoSize = true;
            this.chkMustard.BackColor = System.Drawing.Color.Transparent;
            this.chkMustard.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMustard.ForeColor = System.Drawing.SystemColors.Control;
            this.chkMustard.Location = new System.Drawing.Point(284, 287);
            this.chkMustard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMustard.Name = "chkMustard";
            this.chkMustard.Size = new System.Drawing.Size(82, 23);
            this.chkMustard.TabIndex = 16;
            this.chkMustard.Text = "Mustard";
            this.chkMustard.UseVisualStyleBackColor = false;
            this.chkMustard.CheckedChanged += new System.EventHandler(this.chkMustard_CheckedChanged);
            // 
            // chkRanch
            // 
            this.chkRanch.AutoSize = true;
            this.chkRanch.BackColor = System.Drawing.Color.Transparent;
            this.chkRanch.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRanch.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRanch.Location = new System.Drawing.Point(284, 258);
            this.chkRanch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkRanch.Name = "chkRanch";
            this.chkRanch.Size = new System.Drawing.Size(122, 23);
            this.chkRanch.TabIndex = 15;
            this.chkRanch.Text = "Ranch dressing";
            this.chkRanch.UseVisualStyleBackColor = false;
            this.chkRanch.CheckedChanged += new System.EventHandler(this.chkRanch_CheckedChanged);
            // 
            // chkMayo
            // 
            this.chkMayo.AutoSize = true;
            this.chkMayo.BackColor = System.Drawing.Color.Transparent;
            this.chkMayo.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMayo.ForeColor = System.Drawing.SystemColors.Control;
            this.chkMayo.Location = new System.Drawing.Point(284, 230);
            this.chkMayo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMayo.Name = "chkMayo";
            this.chkMayo.Size = new System.Drawing.Size(99, 23);
            this.chkMayo.TabIndex = 14;
            this.chkMayo.Text = "Mayonnaise";
            this.chkMayo.UseVisualStyleBackColor = false;
            this.chkMayo.CheckedChanged += new System.EventHandler(this.chkMayo_CheckedChanged);
            // 
            // grpCheese
            // 
            this.grpCheese.BackColor = System.Drawing.Color.Transparent;
            this.grpCheese.Controls.Add(this.radNoCheese);
            this.grpCheese.Controls.Add(this.radDairyFreeCheese);
            this.grpCheese.Controls.Add(this.radAmericanCheese);
            this.grpCheese.Controls.Add(this.radGouda);
            this.grpCheese.Controls.Add(this.radMozzarella);
            this.grpCheese.Controls.Add(this.radSwiss);
            this.grpCheese.Controls.Add(this.radParmesan);
            this.grpCheese.Controls.Add(this.radCheddar);
            this.grpCheese.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCheese.ForeColor = System.Drawing.Color.White;
            this.grpCheese.Location = new System.Drawing.Point(46, 351);
            this.grpCheese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCheese.Name = "grpCheese";
            this.grpCheese.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCheese.Size = new System.Drawing.Size(369, 164);
            this.grpCheese.TabIndex = 3;
            this.grpCheese.TabStop = false;
            this.grpCheese.Text = "Cheese";
            // 
            // radSwiss
            // 
            this.radSwiss.AutoSize = true;
            this.radSwiss.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSwiss.Location = new System.Drawing.Point(16, 92);
            this.radSwiss.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radSwiss.Name = "radSwiss";
            this.radSwiss.Size = new System.Drawing.Size(131, 24);
            this.radSwiss.TabIndex = 2;
            this.radSwiss.TabStop = true;
            this.radSwiss.Text = "Swiss (+ $1.00)";
            this.radSwiss.UseVisualStyleBackColor = true;
            this.radSwiss.CheckedChanged += new System.EventHandler(this.radSwiss_CheckedChanged);
            // 
            // radParmesan
            // 
            this.radParmesan.AutoSize = true;
            this.radParmesan.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radParmesan.Location = new System.Drawing.Point(16, 59);
            this.radParmesan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radParmesan.Name = "radParmesan";
            this.radParmesan.Size = new System.Drawing.Size(159, 24);
            this.radParmesan.TabIndex = 1;
            this.radParmesan.TabStop = true;
            this.radParmesan.Text = "Parmesan (+ $1.00)";
            this.radParmesan.UseVisualStyleBackColor = true;
            this.radParmesan.CheckedChanged += new System.EventHandler(this.radParmesan_CheckedChanged);
            // 
            // radCheddar
            // 
            this.radCheddar.AutoSize = true;
            this.radCheddar.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheddar.Location = new System.Drawing.Point(16, 27);
            this.radCheddar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radCheddar.Name = "radCheddar";
            this.radCheddar.Size = new System.Drawing.Size(150, 24);
            this.radCheddar.TabIndex = 0;
            this.radCheddar.TabStop = true;
            this.radCheddar.Text = "Cheddar (+ $1.00)";
            this.radCheddar.UseVisualStyleBackColor = true;
            this.radCheddar.CheckedChanged += new System.EventHandler(this.radCheddar_CheckedChanged);
            // 
            // radMozzarella
            // 
            this.radMozzarella.AutoSize = true;
            this.radMozzarella.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMozzarella.Location = new System.Drawing.Point(16, 125);
            this.radMozzarella.Margin = new System.Windows.Forms.Padding(2);
            this.radMozzarella.Name = "radMozzarella";
            this.radMozzarella.Size = new System.Drawing.Size(166, 24);
            this.radMozzarella.TabIndex = 3;
            this.radMozzarella.TabStop = true;
            this.radMozzarella.Text = "Mozzarella (+ $1.00)";
            this.radMozzarella.UseVisualStyleBackColor = true;
            this.radMozzarella.CheckedChanged += new System.EventHandler(this.radMozzarella_CheckedChanged);
            // 
            // imgDecal1
            // 
            this.imgDecal1.BackColor = System.Drawing.Color.Transparent;
            this.imgDecal1.Image = global::Topic_12_13_GUI_Assignment_1.Properties.Resources.Chalk_stars;
            this.imgDecal1.Location = new System.Drawing.Point(433, 194);
            this.imgDecal1.Name = "imgDecal1";
            this.imgDecal1.Size = new System.Drawing.Size(157, 151);
            this.imgDecal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDecal1.TabIndex = 18;
            this.imgDecal1.TabStop = false;
            // 
            // radNoCheese
            // 
            this.radNoCheese.AutoSize = true;
            this.radNoCheese.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNoCheese.Location = new System.Drawing.Point(197, 125);
            this.radNoCheese.Margin = new System.Windows.Forms.Padding(2);
            this.radNoCheese.Name = "radNoCheese";
            this.radNoCheese.Size = new System.Drawing.Size(59, 24);
            this.radNoCheese.TabIndex = 7;
            this.radNoCheese.TabStop = true;
            this.radNoCheese.Text = "None";
            this.radNoCheese.UseVisualStyleBackColor = true;
            this.radNoCheese.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radDairyFreeCheese
            // 
            this.radDairyFreeCheese.AutoSize = true;
            this.radDairyFreeCheese.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDairyFreeCheese.Location = new System.Drawing.Point(197, 92);
            this.radDairyFreeCheese.Margin = new System.Windows.Forms.Padding(2);
            this.radDairyFreeCheese.Name = "radDairyFreeCheese";
            this.radDairyFreeCheese.Size = new System.Drawing.Size(166, 24);
            this.radDairyFreeCheese.TabIndex = 6;
            this.radDairyFreeCheese.TabStop = true;
            this.radDairyFreeCheese.Text = "Dairy free (+ $3.00)";
            this.radDairyFreeCheese.UseVisualStyleBackColor = true;
            this.radDairyFreeCheese.CheckedChanged += new System.EventHandler(this.radDairyFreeCheese_CheckedChanged);
            // 
            // radAmericanCheese
            // 
            this.radAmericanCheese.AutoSize = true;
            this.radAmericanCheese.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAmericanCheese.Location = new System.Drawing.Point(197, 60);
            this.radAmericanCheese.Margin = new System.Windows.Forms.Padding(2);
            this.radAmericanCheese.Name = "radAmericanCheese";
            this.radAmericanCheese.Size = new System.Drawing.Size(154, 24);
            this.radAmericanCheese.TabIndex = 5;
            this.radAmericanCheese.TabStop = true;
            this.radAmericanCheese.Text = "American (+ $1.00)";
            this.radAmericanCheese.UseVisualStyleBackColor = true;
            this.radAmericanCheese.CheckedChanged += new System.EventHandler(this.radAmericanCheese_CheckedChanged);
            // 
            // radGouda
            // 
            this.radGouda.AutoSize = true;
            this.radGouda.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGouda.Location = new System.Drawing.Point(197, 29);
            this.radGouda.Margin = new System.Windows.Forms.Padding(2);
            this.radGouda.Name = "radGouda";
            this.radGouda.Size = new System.Drawing.Size(137, 24);
            this.radGouda.TabIndex = 4;
            this.radGouda.TabStop = true;
            this.radGouda.Text = "Gouda (+ $1.00)";
            this.radGouda.UseVisualStyleBackColor = true;
            this.radGouda.CheckedChanged += new System.EventHandler(this.radGouda_CheckedChanged);
            // 
            // lblToppingsSection1
            // 
            this.lblToppingsSection1.AutoSize = true;
            this.lblToppingsSection1.BackColor = System.Drawing.Color.Transparent;
            this.lblToppingsSection1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsSection1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblToppingsSection1.Location = new System.Drawing.Point(56, 203);
            this.lblToppingsSection1.Name = "lblToppingsSection1";
            this.lblToppingsSection1.Size = new System.Drawing.Size(62, 20);
            this.lblToppingsSection1.TabIndex = 19;
            this.lblToppingsSection1.Text = "+ $1.00";
            // 
            // lblToppingsSection2
            // 
            this.lblToppingsSection2.AutoSize = true;
            this.lblToppingsSection2.BackColor = System.Drawing.Color.Transparent;
            this.lblToppingsSection2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsSection2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblToppingsSection2.Location = new System.Drawing.Point(165, 203);
            this.lblToppingsSection2.Name = "lblToppingsSection2";
            this.lblToppingsSection2.Size = new System.Drawing.Size(62, 20);
            this.lblToppingsSection2.TabIndex = 20;
            this.lblToppingsSection2.Text = "+ $0.50";
            // 
            // lblToppingsSection3
            // 
            this.lblToppingsSection3.AutoSize = true;
            this.lblToppingsSection3.BackColor = System.Drawing.Color.Transparent;
            this.lblToppingsSection3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsSection3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblToppingsSection3.Location = new System.Drawing.Point(280, 203);
            this.lblToppingsSection3.Name = "lblToppingsSection3";
            this.lblToppingsSection3.Size = new System.Drawing.Size(53, 20);
            this.lblToppingsSection3.TabIndex = 21;
            this.lblToppingsSection3.Text = "FREE";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(433, 411);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(167, 38);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(433, 462);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(167, 38);
            this.btnRestart.TabIndex = 23;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // FormSandwichOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 544);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblToppingsSection3);
            this.Controls.Add(this.lblToppingsSection2);
            this.Controls.Add(this.lblToppingsSection1);
            this.Controls.Add(this.imgDecal1);
            this.Controls.Add(this.grpCheese);
            this.Controls.Add(this.chkTeriyaki);
            this.Controls.Add(this.chkMustard);
            this.Controls.Add(this.chkRanch);
            this.Controls.Add(this.chkMayo);
            this.Controls.Add(this.chkLettuce);
            this.Controls.Add(this.chkCucumber);
            this.Controls.Add(this.chkTomato);
            this.Controls.Add(this.chkOnion);
            this.Controls.Add(this.chkBacon);
            this.Controls.Add(this.chkChicken);
            this.Controls.Add(this.chkTurkey);
            this.Controls.Add(this.chkHam);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.grpBread);
            this.Controls.Add(this.grpSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSandwichOrder";
            this.Text = "Sandwich Order";
            this.Load += new System.EventHandler(this.FormSandwichOrder_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpBread.ResumeLayout(false);
            this.grpBread.PerformLayout();
            this.grpCheese.ResumeLayout(false);
            this.grpCheese.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDecal1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radRegular;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.GroupBox grpBread;
        private System.Windows.Forms.RadioButton radCheesyBread;
        private System.Windows.Forms.RadioButton radGlutenFree;
        private System.Windows.Forms.RadioButton radFlatbread;
        private System.Windows.Forms.RadioButton radWhiteBread;
        private System.Windows.Forms.RadioButton radMultiGrain;
        private System.Windows.Forms.RadioButton radWholeWheat;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkTurkey;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.CheckBox chkCucumber;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTeriyaki;
        private System.Windows.Forms.CheckBox chkMustard;
        private System.Windows.Forms.CheckBox chkRanch;
        private System.Windows.Forms.CheckBox chkMayo;
        private System.Windows.Forms.GroupBox grpCheese;
        private System.Windows.Forms.RadioButton radSwiss;
        private System.Windows.Forms.RadioButton radParmesan;
        private System.Windows.Forms.RadioButton radCheddar;
        private System.Windows.Forms.PictureBox imgDecal1;
        private System.Windows.Forms.RadioButton radMozzarella;
        private System.Windows.Forms.RadioButton radNoCheese;
        private System.Windows.Forms.RadioButton radDairyFreeCheese;
        private System.Windows.Forms.RadioButton radAmericanCheese;
        private System.Windows.Forms.RadioButton radGouda;
        private System.Windows.Forms.Label lblToppingsSection1;
        private System.Windows.Forms.Label lblToppingsSection2;
        private System.Windows.Forms.Label lblToppingsSection3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRestart;
    }
}

