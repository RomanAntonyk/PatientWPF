using Lab_2.Model;
using Lab_2.ViewModel;

namespace Lab_2.Commands
{
    public class DeletePatientCommand : CommandBase
    {
        private readonly Hospital _hospital;
        private readonly PatientListingViewModel _patientListingViewModel;

        public DeletePatientCommand(Hospital hospital, PatientListingViewModel patientListingView)
        {
            _hospital = hospital;
            _patientListingViewModel = patientListingView;
        }

        public override void Execute(object? parameter)
        {
            var _patientViewModel = _patientListingViewModel.SelectedPatient;
            _patientListingViewModel.Patients.Remove(_patientViewModel);

            _hospital.DeletePatientByFirstAndLastName(_patientViewModel.FirstName, _patientViewModel.LastName);
        }
    }
}
