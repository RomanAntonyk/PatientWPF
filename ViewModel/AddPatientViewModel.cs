
using Lab_2.Commands;
using Lab_2.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;

namespace Lab_2.ViewModel
{
    public class AddPatientViewModel : ViewModelBase
    {
		public AddPatientViewModel(Hospital hospital, Services.NavigationService navigationService)
		{
			_birthday = DateTime.Now;
			Diagnoses = new();
			AddDiagnoseCommand = new AddDiagnoseCommand(this);
			DeleteDiagnoseCommand = new DeleteDiagnoseCommand(this);
			AddCommand = new AddPatientCommand(this, hospital);
			CancelCommand = new NavigateCommand(navigationService);
		}


		private string _firstName;
		public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				_firstName = value;
				OnPropertyChanged(nameof(FirstName));
			}
		}

		private string _lastName;
		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				_lastName = value;
				OnPropertyChanged(nameof(LastName));
			}
		}

		private DateTime _birthday;

		public DateTime Birthday
		{
			get
			{
				return _birthday;
			}
			set
			{
				_birthday = value;
				OnPropertyChanged(nameof(Birthday));
			}
		}

		private string _diagnose;
		public string Diagnose
		{
			get
			{
				return _diagnose;
			}
			set
			{
				_diagnose = value;
				OnPropertyChanged(nameof(Diagnose));
			}
		}

		private string _selectedDiagnose;
		public string SelectedDiagnose
		{
			get
			{
				return _selectedDiagnose;
			}
			set
			{
				_selectedDiagnose = value;
				OnPropertyChanged(nameof(SelectedDiagnose));
			}
		}

		public ObservableCollection<string> Diagnoses { get; }

		public ICommand AddDiagnoseCommand { get; }
		
		public ICommand DeleteDiagnoseCommand { get; }
		public ICommand AddCommand { get; }

		public ICommand CancelCommand { get; }


		public void Clear()
		{
			FirstName = "";
			LastName = "";
			Birthday = DateTime.Now;
			Diagnose = "";
			Diagnoses.Clear();
		}

	}
}
