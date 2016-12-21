using System;
using System.Windows.Input;

namespace FOCOtizaciones.ViewModel
{
    public class SimpleCommand : ICommand //After you do this, hit ctrl+space and choos implement inferace to generate all the necesary code for the interface
    {

        //This object is just one of ViewModelBase the other class created
        public ViewModelBase ViewModel { get; set; }



        public SimpleCommand(ViewModelBase viewModel)
        {
            //You asign the parameter to the object
            this.ViewModel = viewModel;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //You call the method on ViewModelBase Class
            this.ViewModel.SimpleMethod();
        }
    }
}