using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_12_13_GUI_Assignment_1
{
    public partial class FormSandwichOrder : Form
    {
        double totalPrice;
        Random generator = new Random();

        string size, bread = "invisible", cheese = "no";
        List<string> toppings = new List<string>();

        public FormSandwichOrder()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void FormSandwichOrder_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Chalkboard;

            totalPrice = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radDairyFreeCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (radDairyFreeCheese.Checked)
            {
                Cheese();
                cheese = "dairy-free";
            }
            else if (!radDairyFreeCheese.Checked)
            {
                totalPrice = (totalPrice - 3);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radAmericanCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (radAmericanCheese.Checked)
            {
                Cheese();
                cheese = "American";
            }
            else if (!radAmericanCheese.Checked)
            {
                totalPrice = (totalPrice - 1);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        public void Size()
        {
            //Size
            if (radSmall.Checked)
            {
                totalPrice = (totalPrice + 4);
            }
            else if (radRegular.Checked)
            {
                totalPrice = (totalPrice + 6.5);
            }
            else if (radLarge.Checked)
            {
                totalPrice = (totalPrice + 8);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        public void Bread()
        {
            //Bread
            if (radGlutenFree.Checked || radCheesyBread.Checked)
            {
                totalPrice = (totalPrice + 2);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        public void Toppings1()
        {
            //Toppings
            if (chkHam.Checked || chkTurkey.Checked || chkChicken.Checked || chkBacon.Checked)
            {
                totalPrice = (totalPrice + 1);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        public void Toppings2()
        {
            if (chkOnion.Checked || chkTomato.Checked || chkCucumber.Checked || chkLettuce.Checked)
            {
                totalPrice = (totalPrice + 0.5);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        public void Cheese()
        {
            //Cheese
            if (radCheddar.Checked || radParmesan.Checked || radSwiss.Checked || radMozzarella.Checked || radGouda.Checked || radAmericanCheese.Checked)
            {
                totalPrice = (totalPrice + 1);
            }
            else if (radDairyFreeCheese.Checked)
            {
                totalPrice = (totalPrice + 3);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            radSmall.Checked = true;
            radRegular.Checked = false;
            radLarge.Checked = false;

            radWholeWheat.Checked = false;
            radMultiGrain.Checked = false;
            radWhiteBread.Checked = false;
            radFlatbread.Checked = false;
            radGlutenFree.Checked = false;
            radCheesyBread.Checked = false;

            chkHam.Checked = false;
            chkTurkey.Checked = false;
            chkChicken.Checked = false;
            chkBacon.Checked = false;
            chkOnion.Checked = false;
            chkTomato.Checked = false;
            chkCucumber.Checked = false;
            chkLettuce.Checked = false;
            chkMayo.Checked = false;
            chkRanch.Checked = false;
            chkMustard.Checked = false;
            chkTeriyaki.Checked = false;

            radCheddar.Checked = false;
            radParmesan.Checked = false;
            radSwiss.Checked = false;
            radMozzarella.Checked = false;
            radGouda.Checked = false;
            radAmericanCheese.Checked = false;
            radDairyFreeCheese.Checked = false;
            radNoCheese.Checked = false;

            totalPrice = 4;
            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (radSmall.Checked)
            {
                Size();
                size = "Small";
            }
            else if (!radSmall.Checked)
            {
                totalPrice = (totalPrice - 4);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (radRegular.Checked)
            {
                Size();
                size = "Regular";
            }
            else if (!radRegular.Checked)
            {
                totalPrice = (totalPrice - 6.5);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (radLarge.Checked)
            {
                Size();
                size = "Large";
            }
            else if (!radLarge.Checked)
            {
                totalPrice = (totalPrice - 8);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radWholeWheat_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
            bread = "whole wheat";
        }

        private void radMultiGrain_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
            bread = "multi-grain";
        }

        private void radWhiteBread_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
            bread = "white";
        }

        private void radGlutenFree_CheckedChanged(object sender, EventArgs e)
        {
            if (radGlutenFree.Checked)
            {
                Bread();
                bread = "gluten free";
            }
            else if (!radGlutenFree.Checked)
            {
                totalPrice = (totalPrice - 2);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radCheesyBread_CheckedChanged(object sender, EventArgs e)
        {
            if (radCheesyBread.Checked)
            {
                Bread();
                bread = "cheesy";
            }
            else if (!radCheesyBread.Checked)
            {
                totalPrice = (totalPrice - 2);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void chkHam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHam.Checked)
            {
                Toppings1();
                toppings.Add("ham");
            }
            else if (!chkHam.Checked)
            {
                totalPrice = (totalPrice - 1);
                toppings.Remove("ham");
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void chkTurkey_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTurkey.Checked)
            {
                Toppings1();
                toppings.Add("turkey");
            }
            else if (!chkTurkey.Checked)
            {
                totalPrice = (totalPrice - 1);
                toppings.Remove("turkey");
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChicken.Checked)
            {
                Toppings1();
                toppings.Add("chicken");
            }
            else if (!chkChicken.Checked)
            {
                totalPrice = (totalPrice - 1);
                toppings.Remove("chicken");
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void chkBacon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBacon.Checked)
            {
                Toppings1();
                toppings.Add("bacon");
            }
            else if (!chkBacon.Checked)
            {
                totalPrice = (totalPrice - 1);
                toppings.Remove("bacon");
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOnion.Checked)
            {
                Toppings2();
                toppings.Add("onion");
            }
            else if (!chkBacon.Checked)
            {
                totalPrice = (totalPrice - 0.5);
                toppings.Remove("onion");
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void chkTomato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomato.Checked)
            {
                Toppings2();
                toppings.Add("tomato");
            }
            else if (!chkTomato.Checked)
            {
                totalPrice = (totalPrice - 0.5);
                toppings.Remove("tomato");
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void chkCucumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCucumber.Checked)
            {
                Toppings2();
                toppings.Add("cucumber");
            }
            else if (!chkCucumber.Checked)
            {
                totalPrice = (totalPrice - 0.5);
                toppings.Remove("cucumber");
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void chkLettuce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLettuce.Checked)
            {
                Toppings2();
                toppings.Add("lettuce");
            }
            else if (!chkLettuce.Checked)
            {
                totalPrice = (totalPrice - 0.5);

                toppings.Remove("lettuce");
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radCheddar_CheckedChanged(object sender, EventArgs e)
        {
            if (radCheddar.Checked)
            {
                Cheese();
                cheese = "cheddar";
            }
            else if (!radCheddar.Checked)
            {
                totalPrice = (totalPrice - 1);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radParmesan_CheckedChanged(object sender, EventArgs e)
        {
            if (radParmesan.Checked)
            {
                Cheese();
                cheese = "parmesan";
            }
            else if (!radParmesan.Checked)
            {
                totalPrice = (totalPrice - 1);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radSwiss_CheckedChanged(object sender, EventArgs e)
        {
            if (radSwiss.Checked)
            {
                Cheese();
                cheese = "swiss";
            }
            else if (!radSwiss.Checked)
            {
                totalPrice = (totalPrice - 1);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radMozzarella_CheckedChanged(object sender, EventArgs e)
        {
            if (radMozzarella.Checked)
            {
                Cheese();
                cheese = "mozzarella";
            }
            else if (!radMozzarella.Checked)
            {
                totalPrice = (totalPrice - 1);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radGouda_CheckedChanged(object sender, EventArgs e)
        {
            if (radGouda.Checked)
            {
                Cheese();
                cheese = "gouda";
            }
            else if (!radGouda.Checked)
            {
                totalPrice = (totalPrice - 1);
            }

            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void chkMayo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMayo.Checked)
            {
                toppings.Add("mayonnaise");
            }
            else if (!chkMayo.Checked)
            {
                toppings.Remove("mayonnaise");
            }
        }

        private void chkRanch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRanch.Checked)
            {
                toppings.Add("ranch dressing");
            }
            else if (!chkRanch.Checked)
            {
                toppings.Remove("ranch dressing");
            }
        }

        private void chkMustard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMustard.Checked)
            {
                toppings.Add("mustard");
            }
            else if (!chkMustard.Checked)
            {
                toppings.Remove("mustard");
            }
        }

        private void chkTeriyaki_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeriyaki.Checked)
            {
                toppings.Add("teriyaki sauce");
            }
            else if (!chkTeriyaki.Checked)
            {
                toppings.Remove("teriyaki sauce");
            }
        }

        private void radFlatbread_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
            bread = "flatbread";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = "Thank you for your order! Your total is: " + totalPrice.ToString("C") + "\n\n" +
                "Your order: " + size + " sandwich on " + bread + " bread with " + cheese + " cheese, " + string.Join(", ", toppings);
            string title = "Order #" + generator.Next(0, 10000);
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
