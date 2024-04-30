using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZI_Georgi_Kolev.Presenter
{
    public partial class Registraciq : UserControl
    {
        public Registraciq()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            VleznalAdmin admin = new VleznalAdmin();
            VleznalPotrebitel potrebitel = new VleznalPotrebitel();

            if (textBox1.Text == "georgi" && textBox2.Text == "1234" && textBox3.Text == "GKolev@gmail.com" && textBox4.Text == "1234")
            {

                form.Hide();
                potrebitel.Show();
            }
            else
            {
                MessageBox.Show("Въведени са грешни данни!");
            }

        }
        //meil
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //ime
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //pas2
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
