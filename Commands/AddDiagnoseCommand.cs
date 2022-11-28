using Lab_2.Model;
using Lab_2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Commands
{
    internal class AddDiagnoseCommand : CommandBase
    {
        private readonly AddPatientViewModel _addPatientViewModel;

        public AddDiagnoseCommand(AddPatientViewModel addPatientViewModel)
        {
            _addPatientViewModel = addPatientViewModel;
        }

        public override void Execute(object? parameter)
        {
            _addPatientViewModel.Diagnoses.Add(_addPatientViewModel.Diagnose);
            _addPatientViewModel.Diagnose = "";
        }

    }
}
