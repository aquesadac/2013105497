using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013105497
{
    public class Carro
    {
    Llanta _llanta;
    Asiento _asiento;
    cinturon _cinturon;
    Parabrisas _parabrisas;
    Volante _volante;
    public string NumSerieMotor { get; set; }
    public string NumSerieChasis { get; set; }

    public Carro(string _numSerieMotor, string _numSerieChasis)
    {
        NumSerieChasis = _numSerieChasis;
        NumSerieMotor = _numSerieMotor;
        _llanta = new Llanta();
        _asiento = new asiento();
        _parabrisas = new Parabrisas();
        _volante = new Volante();


    }
   
    }
}


