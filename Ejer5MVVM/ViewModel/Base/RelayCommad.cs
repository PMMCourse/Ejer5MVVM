using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EjerMVVM.ViewModel.Base
{
    public class RelayCommand<T> : ICommand
    {
        private Action<T> _action;

        public RelayCommand(Action<T> action)
        {
            _action = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action?.Invoke((T)Convert.ChangeType(parameter, typeof(T)));
        }
    }
}

