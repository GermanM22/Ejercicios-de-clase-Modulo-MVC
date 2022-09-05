using Ejercicio6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Working
{
    internal interface ICompany<I> where I : Entity
    {
        public void Contrat(I obj);
    }
}
