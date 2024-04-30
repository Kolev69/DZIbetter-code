using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZI_Georgi_Kolev
{
    public partial class Vhod : UserControl
    {
        public Vhod()
        {
            InitializeComponent();
        }
        //ime
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //pass
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            VleznalAdmin admin = new VleznalAdmin();
            VleznalPotrebitel potrebitel = new VleznalPotrebitel();

            if (textBox1.Text == "georgi" && textBox2.Text == "1234")
            {

                form.Hide();
                admin.Show();
            }
            else 
            {
                MessageBox.Show("Грешно име или парола!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
