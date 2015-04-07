using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WPF3.ViewModel
{
    class CommandAddPerson : ICommand
    {

        public CommandAddPerson(PersonViewModel owner)
        {
            this.owner = owner;
        }

        private PersonViewModel owner;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this.owner.AddNewPerson();
        }
    }
}
