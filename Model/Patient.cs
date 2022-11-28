using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Model
{
    [DataContract]
    public class Patient
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
        [DataMember]
        public List<string> Diagnoses { get; set; }

        public Patient(string firstName, string lastName, DateTime birthday, List<string> diagnoses)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Diagnoses = diagnoses;
        }

        public override bool Equals(object? obj)
        {
            return obj is Patient patient &&
                   FirstName == patient.FirstName &&
                   LastName == patient.LastName &&
                   Birthday.Equals(patient.Birthday);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, Birthday);
        }
    }
}
