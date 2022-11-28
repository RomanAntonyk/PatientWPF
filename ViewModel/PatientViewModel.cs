using Lab_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.ViewModel
{
    public class PatientViewModel : ViewModelBase
    {
        private readonly Patient _patient;
        public string FirstName => _patient.FirstName;
        public string LastName  => _patient.LastName;
        public string Birthday => _patient.Birthday.ToString("d");
        public string Diagnoses => string.Join(' ', _patient.Diagnoses);

        public PatientViewModel(Patient patient)
        {
            _patient = patient;
        }
    }
}
