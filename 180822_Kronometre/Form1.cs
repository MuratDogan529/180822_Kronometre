using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180822_Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat = 0, dakika = 0, saniye = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            saniye++;
            if (saniye > 59)
            {
                dakika++;
                if (dakika > 59)
                {
                    saat++;
                    lblSaat.Text =saat.ToString();
                    dakika = 0;
                    
                }
                lblDakika.Text = dakika < 10 ? string.Format("0{0}",dakika): dakika.ToString();
                saniye = 0;
            }
           //tek satırda if else yazma işlemeine "Turnery If" denir.?=if tir, :ise else yerine kullanılır
            lblSaniye.Text = saniye < 10 ? string.Format("0{0}", saniye):saniye.ToString();
         /*   if (saat == dakika)
            {
                MessageBox.Show("Biri Seni Düşünüyor.");
            }
         */
            /*   if (saniye<10)
            {
                lblSaniye.Text = string.Format("0{0}", saniye);
            }
            else
            {
                lblSaniye.Text=saniye.ToString();
            }
            */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

       
    }
}
