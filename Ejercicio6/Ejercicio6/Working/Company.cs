using Ejercicio6.Working;
using Ejercicio6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Working
{
    internal class Company<I> : ICompany<I> where I : Entity
    {
        private List<I> Contrated { get; set; }

        public Company(): base()
        {
            Contrated = new List<I>();
        }
       
        public void Contrat(I obj)
        {
            obj.Id = "200325"; 
            Contrated.Add(obj);
        }
    }
}
