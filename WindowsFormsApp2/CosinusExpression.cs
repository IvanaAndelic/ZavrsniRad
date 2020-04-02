using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsniRad
{
    class CosinusExpression : Expression
    {
        private Expression izraz;

        public CosinusExpression(Expression izraz)
        {
            this.izraz = izraz;
        }

        public double Interpret()
        {
            return Math.Cos(izraz.Interpret()); //cos(0.13)
        }
    }
}
