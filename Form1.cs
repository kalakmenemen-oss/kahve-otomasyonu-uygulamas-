using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Pkcs;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double toplam = 0;
        int esp = 80;
        int trkkah = 50;
        int mlkshk = 65;
        int latte = 105;
        int doubleshot = 25;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkBox1.Visible = true;


                if (checkBox1.Checked == true)

                {
                    toplam = toplam + esp + doubleshot;
                    MessageBox.Show("sayın müşterimizi toplam tutar = " + toplam);
                }

                else if (checkBox1.Checked == false)
                { MessageBox.Show("sayın müşterimiz toplam tutar = " + esp); }

            }
            if (radioButton2.Checked == true)
            {

                {

                    MessageBox.Show("sayın müşterimizi toplam tutar = " + latte);
                }
            }
            if (radioButton3.Checked == true)
            {
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;


                if (checkBox2.Checked == true)

                {

                    MessageBox.Show("sayın müşterimizi toplam tutar = " + trkkah, "alınan ürünler = " + "çay" + checkBox2.Checked);
                }
                if (checkBox3.Checked == true)

                {

                    MessageBox.Show("sayın müşterimizi toplam tutar = " + trkkah, "alınan ürünler = " + "türk kahvesi" + checkBox3.Checked);
                }

                if (checkBox4.Checked == true)

                {

                    MessageBox.Show("sayın müşterimizi toplam tutar = " + trkkah, "alınan ürünler = " + "türk kahvesi" + checkBox2.Checked);
                }

            }
            if (radioButton4.Checked == true)
            {

                {

                    MessageBox.Show("alınan ürün ve toplam tutar = " + mlkshk);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkBox1.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
            }
            else
            {
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
