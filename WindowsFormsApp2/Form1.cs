using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = this.CreateGraphics();
            Pen MojaOlovka = new Pen(Color.Red, 3f);
           
            int x_koordinata = this.Location.X;
            int y_koordinata = this.Location.Y;
            int visina_plohe = this.Height;
            int sirina_plohe = this.Width;
            int vrh_y = sirina_plohe / 2;
            int vrh_x = visina_plohe / 2;
            graphicsObj.DrawLine(MojaOlovka, vrh_y + x_koordinata, y_koordinata, x_koordinata + vrh_y, y_koordinata + visina_plohe);

        }

        private void NacrtajButton_Click(object sender, EventArgs e)
        {
            double IntervalOd;
            IntervalOd = Convert.ToDouble(IntervalOdTxt.Text);
            double IntervalDo;
            IntervalDo = Convert.ToDouble(IntervalDoTxt.Text);
            int BrojTocaka;
            BrojTocaka =Convert.ToInt32( BrojTocakaTxt.Text);
            double Korak;
            Korak = (IntervalDo - IntervalOd) / BrojTocaka;

            //pozvati interpreter


            Point[] PoljeTocaka;

            for(double i=IntervalOd; i <= IntervalDo; i += Korak)
            {
                //punimo polje tocaka prema zadanoj funkciji
            }

            //Uvesti Graphics Object i Pen
            //metoda DrawLines kojoj cemo predat polje tocaka
                
        }
    }
}
