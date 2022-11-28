using Lab_2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Commands
{
    public class DeleteDiagnoseCommand : CommandBase
    {
        private readonly AddPatientViewModel _addPatientViewModel;

        public DeleteDiagnoseCommand(AddPatientViewModel addPatientViewModel)
        {
            _addPatientViewModel = addPatientViewModel;
        }

        public override void Execute(object? parameter)
        {
            _addPatientViewModel.Diagnoses.Remove(_addPatientViewModel.SelectedDiagnose);
        }
    }
}
