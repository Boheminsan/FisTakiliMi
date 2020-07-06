using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Fiş_Takılı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Enabled = true;
            bool isRunningOnBattery =
      (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus ==
       PowerLineStatus.Offline);
            if (isRunningOnBattery)
            {
                if (lblTakiliMi.Text == "label1")
                {
                    lblTakiliMi.Text = "Pil";
                }
            }
            else
            {
                if (lblTakiliMi.Text == "label1")
                {
                    lblTakiliMi.Text = "Güç";
                }
            }
            i = 0;
        }
        int hareketlenme;
        private void kesinti()
        {
            bool isRunningOnBattery =
      (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus ==
       PowerLineStatus.Offline);
            if (isRunningOnBattery)
            {
                if (lblTakiliMi.Text == "Güç")
                {
                    lblTakiliMi.Text = "Pil";
                }
            }
            else
            {
                if (lblTakiliMi.Text == "Pil")
                {
                    lblTakiliMi.Text = "Güç";
                }
            }
        }
        private void listeYaz(int k)
        {
            string simdi = "";
            if (k == 0)
            {
                simdi = "Güç kesildi: " + DateTime.Now.ToString();
                i++;
            }
            else if (k == 1)
            {
                simdi = "Güç geldi: " + DateTime.Now.ToString();
            }
            lblKacKere.Text = i.ToString();
            listBox1.Items.Add(simdi);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kesinti();
        }

        private void lblTakiliMi_TextChanged(object sender, EventArgs e)
        {
            if (lblTakiliMi.Text == "Güç")
            {
                hareketlenme = 1;
                listeYaz(hareketlenme);
            }
            else if (lblTakiliMi.Text == "Pil")
            {
                hareketlenme = 0;
                listeYaz(hareketlenme);
            }
        }
    }
}
