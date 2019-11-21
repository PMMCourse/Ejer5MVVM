using Ejer5MVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ejer5MVVM.ViewModel {
    public class MainViewModel : BaseViewModel {
        private RelayCommand _abrirVentanaComando;
        public ICommand AbrirVentanaComando => _abrirVentanaComando;

        public MainViewModel() {
            _abrirVentanaComando = new RelayCommand(AbrirVentana);
        }

        private void AbrirVentana() {
            new View.ShowText(this).ShowDialog();
        }

        private string _textoPersonalizado;

        public string TextoPersonalizado {
            get => _textoPersonalizado;
            set {
                _textoPersonalizado = value;
                RaiseProperty();
            }
        }
    }
}