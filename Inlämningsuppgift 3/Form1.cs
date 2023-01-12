using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift_3
{
    public partial class Form1 : Form
    {
        int antal = 0;
        string[] personer = new string[100];
        int[] lön = new int[100];

        public Form1()
        {
            InitializeComponent();
            tbxUtdata.Text = "Namn" + "\t" + "Lön" + "\r\n";
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            registrera(lön, personer);
        }

        void registrera( int []lönelista, string[]namnlista)
        {
            string namn = tbxNamn.Text;
            int lön = int.Parse(tbxLön.Text);
            lönelista[antal] = lön;
            namnlista[antal] = namn;
            antal++;
            tbxUtdata.AppendText(namn + "\t" + lön + "\r\n");
        }

        private void tbxLönegrans_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int lönegräns = int.Parse(tbxLönegrans.Text);
            int överlönegränsen = lg(lönegräns);
            tbxDetfinns.Text = "Det finns " + överlönegränsen + " st som tjänar mer än " + lönegräns + " kr";
            visaMedelvärde();
            
        }

        int lg( int överlönegränsen)
        {

            int detfinns = 0;
            for (int i=0; i<antal; i++)
            {
                if (lön[i] > överlönegränsen)
                {
                    detfinns++;
                }
            }
            return detfinns;
           
        }

        void visaMedelvärde()
        {
            int summa = 0;
            for (int i = 0; i < antal; i++ )
            {
                summa = summa + lön[i];
            }
            int medelvärde = summa / antal;
            tbxMedellön.Text = medelvärde.ToString();

        }

        


       
        


    }
}
