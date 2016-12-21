using FOCOtizaciones.Model;
using System;
using System.Windows.Input;

namespace FOCOtizaciones.ViewModel
{
    public class ParameterCommand
    {
        public ViewModelBase ViewModel { get; set; }

        public ParameterCommand(ViewModelBase _viewModel)
        {
            this.ViewModel = _viewModel;
        }

        //public event EventHandler CanExecuteChanged;
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
            //if (parameter != null)
            //{
            //    var s = parameter as String;
            //    s = s.Trim();
            //    if (String.IsNullOrEmpty(s))
            //        return false;

            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public void Execute(object parameter)
        {
            this.ViewModel.ParameterMethod(parameter as Costo);
        }
    }
}