using Ejercicio6.Entities;
using Ejercicio6.Working;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Working
{
    internal class Multinational<I> : ICompany<I> where I : Entity
    {
        public void Contrat (I obj)
        {

        }
    }
}
