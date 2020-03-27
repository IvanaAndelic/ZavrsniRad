using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class BrojExpression : Expression
    {
        double broj;

        public BrojExpression(double broj)
        {
            this.broj = broj;
        }
        public BrojExpression(String broj)
        {
            this.broj = Double.Parse(broj);
        }

        public void setBroj(double broj)
        {
            this.broj = broj;
        }

        public double getBroj()
        {
            return broj;
        }

        public double Interpret()
        {
            return broj;
        }
    }
}
