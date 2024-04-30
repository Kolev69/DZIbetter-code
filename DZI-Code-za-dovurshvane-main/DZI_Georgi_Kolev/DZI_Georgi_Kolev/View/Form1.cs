using DZI_Georgi_Kolev.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DZI_Georgi_Kolev
{
    public partial class Form1 : Form
    {
        Bezalkoholno bezalkoholno1 = new Bezalkoholno();
        Ceni ceni1 = new Ceni();
        Kontakti kontakti1 = new Kontakti();
        ProduktiStoki produktiStoki1 = new ProduktiStoki();
        Registraciq registraciq1 = new Registraciq();
        Reservacii reservacii1 = new Reservacii();
        Uchastiq uchastiq1 = new Uchastiq();
        Uslugi uslugi1 = new Uslugi();
        Uslugi2 uslugi21 = new Uslugi2();
        Vhod vhod1 = new Vhod();
        Za_nas za_nas1 = new Za_nas();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(vhod1);
            vhod1.Location = new Point(0, 33);
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Show();
            za_nas1.Hide();
            vhod1.BringToFront();

        }
        private void заНасToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(za_nas1);
            za_nas1.Location = new Point(0, 33);
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Show();
            za_nas1.BringToFront();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                  
        }

        private void kontakti1_Load(object sender, EventArgs e)
        {

        }

        private void рожденДенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Add(uslugi1);
            uslugi1.Location = new Point(0, 33);
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Show();
            uslugi1.BringToFront();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
        }

        private void частноПартиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Add(uslugi21);
            uslugi21.Location = new Point(0, 33);
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Show();
            uslugi21.BringToFront();
            vhod1.Hide();
            za_nas1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Add(registraciq1);
            registraciq1.Location = new Point(0, 33);
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Show();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            registraciq1.BringToFront();
        }

        private void цениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ceni1);
            ceni1.Location = new Point(0, 33);
            bezalkoholno1.Hide();
            registraciq1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            ceni1.Show();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            ceni1.BringToFront();
        }


        private void контактиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Add(kontakti1);
            kontakti1.Location = new Point(0, 33);
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Show();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            kontakti1.BringToFront();
        }

        private void резервацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Add(reservacii1);
            reservacii1.Location = new Point(0, 33);
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            produktiStoki1.Hide();
            registraciq1.Hide();
            reservacii1.Show();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            reservacii1.BringToFront();
        }

        private void алкохолToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Add(produktiStoki1);
            produktiStoki1.Location = new Point(0, 33);
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            registraciq1.Hide();
            produktiStoki1.Show();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            produktiStoki1.BringToFront();
        }

        private void безалкохолноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Add(bezalkoholno1);
            bezalkoholno1.Location = new Point(0, 33);
            bezalkoholno1.Show();
            ceni1.Hide();
            kontakti1.Hide();
            registraciq1.Hide();
            produktiStoki1.Hide();
            reservacii1.Hide();
            uchastiq1.Hide();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            bezalkoholno1.BringToFront();
        }

        private void участияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Add(uchastiq1);
            uchastiq1.Location = new Point(0, 33);
            bezalkoholno1.Hide();
            ceni1.Hide();
            kontakti1.Hide();
            registraciq1.Hide();
            produktiStoki1.Hide();
            reservacii1.Hide();
            uchastiq1.Show();
            uslugi1.Hide();
            uslugi21.Hide();
            vhod1.Hide();
            za_nas1.Hide();
            uchastiq1.BringToFront();
        }
        private void продуктиСтокиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void контактиИРезервацииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}