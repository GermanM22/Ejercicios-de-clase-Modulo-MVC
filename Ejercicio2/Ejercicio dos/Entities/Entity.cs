using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_dos.Entities
{
    internal class Entity
    {
        public string Id { get; protected set; }

        public string Serial { get; protected set; }

        protected Entity (string id, string serial)
        {
            Id = id;
            Serial = serial;
        }
    }
}
