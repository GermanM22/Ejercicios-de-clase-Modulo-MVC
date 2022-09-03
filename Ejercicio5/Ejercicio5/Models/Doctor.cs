using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    internal class Doctor : Entity
    {
        public string ProCard { get; private set; }
        public List<PatientDoctor> PatientDoctors { get; private set; }
        public Doctor(string id, string proCard) : base(id)
        {
            ProCard = proCard;
            PatientDoctors = new();
        }
        public void AddPatient(string patientid)
        {
            this.PatientDoctors.Add(
                new PatientDoctor(Guid.NewGuid().ToString(),
               patientid, this.Id));
        }
    }
}
