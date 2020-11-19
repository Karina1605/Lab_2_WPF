using Lab_2.viewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lab_2.Commands
{
    class DeleteCustomerCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return (parameter!=null && parameter is CustomerViewModel);
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();
        }
    }
}
