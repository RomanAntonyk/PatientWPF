using Lab_2.Commands;
using Lab_2.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Lab_2.ViewModel
{
    public class PatientListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<PatientViewModel> _patients;
        private readonly Hospital _hospital;
        public ObservableCollection<PatientViewModel> Patients => _patients;

        private PatientViewModel _selectedPatient;
        public PatientViewModel SelectedPatient
        {
            get
            {
                return _selectedPatient;
            }
            set
            {
                _selectedPatient = value;
                OnPropertyChanged(nameof(SelectedPatient));
            }
        }

        public ICommand AddPatientCommand { get; }

        public ICommand DeletePatientCommand { get;}
        public PatientListingViewModel(Hospital hospital, Services.NavigationService addPatientNavigationService)
        {
            _hospital = hospital;
            _patients = new();
            AddPatientCommand = new NavigateCommand(addPatientNavigationService);
            DeletePatientCommand = new DeletePatientCommand(_hospital, this);
            UpdatePatients();
        }

        private void UpdatePatients()
        {
            _patients.Clear();
            foreach(Patient patient in _hospital.Patients)
            {
                PatientViewModel patientViewModel = new PatientViewModel(patient);
                _patients.Add(patientViewModel);
            }
        }
    }
}
