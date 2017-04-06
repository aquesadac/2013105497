using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013105497
{
    class Asiento
    {
        cinturon _cinturon;
        public String NumSerie { get; set; }

        public Asiento(String _numSerie)
        {
            _cinturon = new cinturon();
            NumSerie = _numSerie;
        }
    }
    }




