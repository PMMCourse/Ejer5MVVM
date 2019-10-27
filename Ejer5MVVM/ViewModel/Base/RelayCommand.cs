using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.ViewModel.Base
{
        public class RelayCommand<T> : ICommand
        {
            public RelayCommand(Action<T> action)
            {
                _action = action;
            }

            private Action<T> _action;

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                _action.Invoke((T)parameter);
            }
        }
    }
