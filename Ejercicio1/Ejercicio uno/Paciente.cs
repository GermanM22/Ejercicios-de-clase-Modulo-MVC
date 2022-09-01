using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_uno
{
    internal class Paciente : Entidad
    {
        public string Consulta { get; private set; }

        public Paciente(string name, string consulta) : base(name)
        {
            Consulta = consulta;
        }
    }
}
