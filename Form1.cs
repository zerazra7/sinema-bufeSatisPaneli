using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace büfe
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
            int misir, bilet, su, cay, toplam;
            misir=Convert.ToInt16(txtmisir.Text);
            bilet=Convert.ToInt16(txtbilet.Text);
            su=Convert.ToInt16(txtsu.Text);
            cay=Convert.ToInt16(txtcay.Text);

            toplam = misir * 35 + bilet * 40 + cay * 5 + su * 8;
            lbltoplam.Text = toplam.ToString() + "tl";

            kasatutar += toplam;
            lblkasa.Text = kasatutar.ToString() + "tl";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbltoplam.Text = "";
            txtbilet.Text = "";
            txtcay.Text = "";
            txtmisir.Text = "";
            txtsu.Text = "";
            txtmisir.Focus();
        }

     
    }
}
