using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ZbrojiExpression : Expression
    {
        private Expression izraz1; //(5+2)  +    (4+3)
        private Expression izraz2;

        public ZbrojiExpression(Expression izraz1, Expression izraz2) {
            this.izraz1 = izraz1;
            this.izraz2 = izraz2;
        }

        public double Interpret()
        {
            return izraz1.Interpret() + izraz2.Interpret();
        }
    }
}
