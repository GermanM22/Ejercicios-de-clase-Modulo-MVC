using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_dos.Entities
{
    internal class Celulariphone: Entity
    {
        public double Calidaddefotos { get; private set; }
        public Celulariphone(string id, string serial, double calidaddefotos ) : base(id, serial)
        {
            Calidaddefotos=calidaddefotos;           
        }
    }
}
