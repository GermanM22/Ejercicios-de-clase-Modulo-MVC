using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_tres.Hardwares
{
    internal abstract class Hardware
    {

        public void Conectar()
        {
            Console.WriteLine("Conectar board");
        }

        public abstract void Tasadetransferencia();
    }
}
