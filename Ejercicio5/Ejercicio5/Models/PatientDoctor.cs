using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    internal class PatientDoctor : Entity
    {
        public string PatientId { get; private set; } 

        public string DoctorId { get; private set; }

        
        public PatientDoctor(string id, string patientid, string doctorid) : base(id)
        {
            PatientId = patientid;
            DoctorId = doctorid;
        }

    }
}
