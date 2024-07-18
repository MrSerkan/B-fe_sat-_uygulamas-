using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Büfe_satış_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, su, çay, kola, toplam;
            mısır = Convert.ToInt16(txtmısır.Text); 
            çay = Convert.ToInt16(txtcay.Text); 
            su= Convert.ToInt16(txtsu.Text);    
            kola= Convert.ToInt16(txtkola.Text);

            toplam = mısır * 25 + çay * 7 + su * 5 + kola * 15;
            lbltoplam.Text = toplam.ToString()+ " TL";


            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString()+ " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcay.Text = " ";
            txtkola.Text = " ";
            txtmısır.Text  = " ";
            txtsu.Text = " ";
            lbltoplam.Text = " ";
            txtmısır.Focus();

        }
    }
}
