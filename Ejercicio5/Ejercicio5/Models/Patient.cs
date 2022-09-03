using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    internal class Patient : Entity
    {
        public string Name { get; private set; }

        public Hospital Hospital { get; private set; }
        
        public List<PatientDoctor> PatientDoctors { get; private set; }

        public Patient(string id, string name, Hospital hospital) : base(id)
        {
            Name = name;
            Hospital = hospital;
            PatientDoctors = new ();
        }
        public void AddDoctor( string doctorid)
        {
            this.PatientDoctors.Add(
                new PatientDoctor(id: Guid.NewGuid().ToString(),
                patientid: this.Id,
                doctorid: doctorid));

        }
 
    }
}
