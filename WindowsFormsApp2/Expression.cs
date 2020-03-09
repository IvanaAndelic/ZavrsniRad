using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
   abstract class Expression
    {

        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;

            
        }
        public abstract string X();
        public abstract string Broj();
        public abstract string Zbroji();
        public abstract string Oduzmi();
        public abstract string Pomnozi();
        public abstract string Podijeli();
    }
}
