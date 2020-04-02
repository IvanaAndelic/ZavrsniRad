using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsniRad
{
    class VarijablaExpression : Expression
    {
        String varijabla;

        public VarijablaExpression(String varijabla)
        {
            this.varijabla = varijabla;
        }

        public double Interpret()
        {
            //hmmm
            //
            return 0;
        }
    }
}
