using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    internal class Entity
    {
        public string Id { get; protected set; }

        public Entity(string id)
        {
            Id = id;
        }
    }
}
