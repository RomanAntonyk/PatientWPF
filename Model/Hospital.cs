using Lab_2.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Model
{
    [DataContract]
    public class Hospital
    {
        [DataMember]
        public List<Patient> Patients { get; set; }

        public Hospital()
        {
            Patients = new();
        }



        public Patient GetPatientByFirstAndLastName(string firstName, string lastName)
        {
            return Patients.Where(patient => patient.FirstName == firstName && patient.LastName == lastName).First();
        }

        public void DeletePatientByFirstAndLastName(string firstName, string lastName)
        {
            Patients.Remove(GetPatientByFirstAndLastName(firstName, lastName));
        }

    }
}
