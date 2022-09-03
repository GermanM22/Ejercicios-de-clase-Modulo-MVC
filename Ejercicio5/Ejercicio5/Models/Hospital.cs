using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    internal class Hospital : Entity
    {
        public string Location { get; set; }

        public List<Patient>Patients { get; set; }

        public Hospital(string id, string location): base(id)
        {
            Location = location;
            Patients = new List<Patient>();
        }
        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);  
        }
    }
}
