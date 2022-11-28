using Lab_2.Model;
using Lab_2.ViewModel;
using System.Collections.Generic;

namespace Lab_2.Commands
{
    public class AddPatientCommand : CommandBase
    {
        private readonly AddPatientViewModel _addPatientViewModel;
        private readonly Hospital _hospital;

        public AddPatientCommand(AddPatientViewModel addPatientViewModel, Hospital hospital)
        {
            _addPatientViewModel = addPatientViewModel;
            _hospital = hospital;
        }

        public override void Execute(object? parameter)
        {
            var patient = new Patient(
                _addPatientViewModel.FirstName,
                _addPatientViewModel.LastName,
                _addPatientViewModel.Birthday,
                new List<string>(_addPatientViewModel.Diagnoses));

            _hospital.Patients.Add(patient);
            _addPatientViewModel.Clear();

        }
    }
}
