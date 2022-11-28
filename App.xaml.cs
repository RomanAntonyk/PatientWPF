using Lab_2.Model;
using Lab_2.Model.Serialization;
using Lab_2.Stores;
using Lab_2.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Lab_2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly string dataPath = ".\\Data\\Hospital.xml";
        private readonly Hospital _hospital;
        private readonly NavigationStore _navigationStore;
        public App()
        {
            _hospital = LoadData();
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            _navigationStore.CurrentViewModel = CreatePatientListingViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            SaveData();
            base.OnExit(e);
        }

        private AddPatientViewModel CreatePatientViewModel()
        {
            return new AddPatientViewModel(_hospital, new Services.NavigationService(_navigationStore, CreatePatientListingViewModel));
        }

        private PatientListingViewModel CreatePatientListingViewModel()
        {
            return new PatientListingViewModel(_hospital, new Services.NavigationService(_navigationStore, CreatePatientViewModel));
        }

        private void SaveData()
        {
            HospitalSerializer.Serialize(dataPath, _hospital);
        } 

        private Hospital LoadData()
        {
            if (File.Exists(dataPath))
            {
                return HospitalSerializer.Deserialize(dataPath);
            }
            return new Hospital();
        }

    }
}
