using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsniRad
{
    class Context
    {
        private string _input; //"5"

        private int _output;  // 5



        // Constructor

        public Context(string input)

        {

            this._input = input;

        }



        // Gets or sets input

        public string Input

        {

            get { return _input; }

            set { _input = value; }

        }



        // Gets or sets output

        public int Output

        {

            get { return _output; }

            set { _output = value; }

        }
    }
}
