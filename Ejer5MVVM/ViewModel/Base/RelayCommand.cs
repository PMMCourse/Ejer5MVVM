using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejer5MVVM.ViewModel.Base
{
    public class RelayCommand : ICommand
    {
        private Action<int> introducirTexto;
        private Action<string> mostrarTexto;

        public RelayCommand(Action<int> introducirTexto)
        {
            this.introducirTexto = introducirTexto;
        }

        public RelayCommand(Action<string> mostrarTexto)
        {
            this.mostrarTexto = mostrarTexto;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
