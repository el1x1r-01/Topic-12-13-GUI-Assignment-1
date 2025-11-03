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
            }
            else if (!radDairyFreeCheese.Checked)
            {
                totalPrice = (totalPrice - 3);
            }
        }

        private void radAmericanCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (radAmericanCheese.Checked)
            {
                Cheese();
            }
            else if (!radAmericanCheese.Checked)
            {
                totalPrice = (totalPrice - 1);
            }
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
            }
            else if (!radSmall.Checked)
            {
                totalPrice = (totalPrice - 4);
            }
        }

        private void radRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (radRegular.Checked)
            {
                Size();
            }
            else if (!radRegular.Checked)
            {
                totalPrice = (totalPrice - 6.5);
            }
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (radLarge.Checked)
            {
                Size();
            }
            else if (!radLarge.Checked)
            {
                totalPrice = (totalPrice - 8);
            }
        }

        private void radWholeWheat_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radMultiGrain_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radWhiteBread_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }

        private void radGlutenFree_CheckedChanged(object sender, EventArgs e)
        {
            if (radGlutenFree.Checked)
            {
                Bread();
            }
            else if (!radGlutenFree.Checked)
            {
                totalPrice = (totalPrice - 2);
            }
        }

        private void radCheesyBread_CheckedChanged(object sender, EventArgs e)
        {
            if (radCheesyBread.Checked)
            {
                Bread();
            }
            else if (!radCheesyBread.Checked)
            {
                totalPrice = (totalPrice - 2);
            }
        }

        private void chkHam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHam.Checked)
            {
                Toppings1();
            }
            else if (!chkHam.Checked)
            {
                totalPrice = (totalPrice - 1);
            }
        }

        private void chkTurkey_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTurkey.Checked)
            {
                Toppings1();
            }
            else if (!chkTurkey.Checked)
            {
                totalPrice = (totalPrice - 1);
            }
        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChicken.Checked)
            {
                Toppings1();
            }
            else if (!chkChicken.Checked)
            {
                totalPrice = (totalPrice - 1);
            }
        }

        private void chkBacon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBacon.Checked)
            {
                Toppings1();
            }
            else if (!chkBacon.Checked)
            {
                totalPrice = (totalPrice - 1);
            }
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOnion.Checked)
            {
                Toppings2();
            }
            else if (!chkBacon.Checked)
            {
                totalPrice = (totalPrice - 0.5);
            }
        }

        private void chkTomato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomato.Checked)
            {
                Toppings2();
            }
            else if (!chkTomato.Checked)
            {
                totalPrice = (totalPrice - 0.5);
            }
        }

        private void chkCucumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCucumber.Checked)
            {
                Toppings2();
            }
            else if (!chkCucumber.Checked)
            {
                totalPrice = (totalPrice - 0.5);
            }
        }

        private void chkLettuce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLettuce.Checked)
            {
                Toppings2();
            }
            else if (!chkLettuce.Checked)
            {
                totalPrice = (totalPrice - 0.5);
            }
        }

        private void radCheddar_CheckedChanged(object sender, EventArgs e)
        {
            if (radCheddar.Checked)
            {
                Cheese();
            }
            else if (!radCheddar.Checked)
            {
                totalPrice = (totalPrice - 1);
            }
        }

        private void radParmesan_CheckedChanged(object sender, EventArgs e)
        {
            if (radParmesan.Checked)
            {
                Cheese();
            }
            else if (!radParmesan.Checked)
            {
                totalPrice = (totalPrice - 1);
            }
        }

        private void radSwiss_CheckedChanged(object sender, EventArgs e)
        {
            if (radSwiss.Checked)
            {
                Cheese();
            }
            else if (!radSwiss.Checked)
            {
                totalPrice = (totalPrice - 1);
            }
        }

        private void radMozzarella_CheckedChanged(object sender, EventArgs e)
        {
            if (radMozzarella.Checked)
            {
                Cheese();
            }
            else if (!radMozzarella.Checked)
            {
                totalPrice = (totalPrice - 1);
            }
        }

        private void radGouda_CheckedChanged(object sender, EventArgs e)
        {
            if (radGouda.Checked)
            {
                Cheese();
            }
            else if (!radGouda.Checked)
            {
                totalPrice = (totalPrice - 1);
            }
        }

        private void radFlatbread_CheckedChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Total price = " + totalPrice.ToString("C");
        }
    }
}
