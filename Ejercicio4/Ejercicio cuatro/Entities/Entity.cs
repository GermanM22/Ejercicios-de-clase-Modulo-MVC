using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_cuatro.Entities
{
    internal abstract class Entity
    {
        public int Id { get; protected set; }

        protected Entity(int id)
        {
            Id = id;
        }
    }
}
