using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //kakve sve expressione imamo
            //binarni operatori: + - * /    --imaju 2 Expressiona u sebi kao atribute, a interpret vraca rez
            // unarne operatori: cos sin exp korijen log
            // BrojExpression  -- 
            //VarijablaExpression -- "x"


            


            //parser expressiona
            //5+2
            String zbroj = "55+24+13";  //"55+22+13"   "c"

            String[] splittedZbroj = zbroj.Split('+');  //[0]="55" [1] = "24"

            double res = 0;
            BrojExpression resExpression = new BrojExpression(0);

            foreach(String broj in splittedZbroj)
            {
                ZbrojiExpression zbrojExpr = new ZbrojiExpression(resExpression, new BrojExpression(broj));
                resExpression.setBroj(zbrojExpr.Interpret());

            }


            Console.WriteLine(res);
            MessageBox.Show("res je " + resExpression.getBroj());



       /*     for (int i=0; i<zbroj.Length; i++)
            {
                if(zbroj[i] == '+')
                {
                    ZbrojiExpression zbrojExpr = new ZbrojiExpression(resExpression, new BrojExpression(zbroj[i + 1].ToString()));
                    resExpression.setBroj(zbrojExpr.Interpret());

                    res = res + Int32.Parse(zbroj[i + 1].ToString());                 

                    i++;
                }
                else
                {
                    //
                    resExpression.setBroj(Double.Parse(zbroj[i].ToString()));
                    res = Int32.Parse(zbroj[i].ToString());
                }

            }

            Console.WriteLine(res);
            MessageBox.Show("res je " + resExpression.getBroj());*/

        }
    }
}
