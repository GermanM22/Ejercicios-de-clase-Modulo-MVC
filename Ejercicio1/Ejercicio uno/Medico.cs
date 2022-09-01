using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_uno
{
    internal class Medico:Entidad
    {
        public string FirstName { get; private set; }

        public Medico(string name, string firstName) :base(name)
        {
            FirstName = firstName;
        }
    }
}
