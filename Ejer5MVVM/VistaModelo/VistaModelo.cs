using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ejer5MVVM.VistaModelo
{
    class VistaModelo : BaseVistaModelo
    {
        private RelayCommand _comprobarComando;
        public ICommand comprobarComando => _comprobarComando;

        private RelayCommand<int> _insertNumberCommand;
        public ICommand InsertNumberCommand => _insertNumberCommand;

        public void MainViewModel()
        {
            _comprobarComando = new RelayCommand(PerformCheckText);
            _insertNumberCommand = new RelayCommand<int>(PerformInsertNumber);
        }

        private void PerformInsertNumber(int obj)
        {
            TextGreetings += obj.ToString();
        }
        private void PerformCheckText()
        {
            //aqui se puede hacer comprobaciones y ejecuciones
            MessageBox.Show("Has pulsado 1");
        }
        private string _textGreetings;
        public string TextGreetings
        {
            get => _textGreetings;
            set
            {
                _textGreetings = value;
                
                RaiseProperty();
            }
        }
    }
}
