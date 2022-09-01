using Ejercicio_cuatro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_cuatro.Fabricas
{
    internal interface IFactory
    {
        public Entity BuildMascota(int id);

        public Entity BuildDueño(int id, string registro);
        
    }
}
