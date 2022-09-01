using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_dos.Entities
{
    internal class Celularsamsung: Entity
    {
        public Celularsamsung(string id, string serial) : base(id, serial)
        {
           
        }

        public void ImprimirValores()
        {
            if (string.IsNullOrEmpty(Serial))
                throw new Exception("");
            else if (string.IsNullOrEmpty(Id))
                throw new Exception("");

            Console.WriteLine($"{this.Id}{this.Serial}");
        }
    }
}
