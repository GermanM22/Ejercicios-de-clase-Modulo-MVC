using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_cuatro.Entities
{
    internal class Dueño : Entity
    {
        public string Registro { get; private set; }

        public Dueño (int id, string registro) : base(id)
        {
            Registro = registro;
        }
    }
}
