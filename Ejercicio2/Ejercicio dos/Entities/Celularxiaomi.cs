using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_dos.Entities
{
    internal class Celularxiaomi: Entity
    {
        public double Tiempodecarga { get; private set; }
        public Celularxiaomi(string id, string serial, double tiempodecarga) : base(id, serial)
        {
            Tiempodecarga = tiempodecarga;
        }
    }
}
