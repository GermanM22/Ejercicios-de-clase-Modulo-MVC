using Ejercicio_tres.Hardwares;
using Ejercicio_tres.Perifericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_tres.Celulares
{
    internal class Celular
    { 
    private IPeriferico Periferico;

    private Hardware Ram;

    public Celular (IPeriferico periferico)
        {
            Periferico = periferico;

            this.Ram = new RAM ();
        }
    

    }
}
