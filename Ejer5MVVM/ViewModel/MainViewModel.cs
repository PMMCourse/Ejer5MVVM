using EjerMVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EjerMVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private RelayCommand<string> _contarTextoIntroducido;
        public ICommand ContarTextoIntroducido => _contarTextoIntroducido;

        public MainViewModel()
        {
            //_contarTextoIntroducido = new RelayCommand<string> (ResultadoContador);
        }
        /*
        private void ResultadoContador(string texto)
        {
            
        }
        */
        private string _textoIntroducido;

        public string TextoIntroducido
        {
            get => _textoIntroducido;
            set
            {
                _textoIntroducido = value;
                ResultadoContador();
                RaiseProperty();
            }
        }

        private void ResultadoContador()
        {
            Contador = _textoIntroducido.Split(' ').Count();
        }

        private int _contador;

        public int Contador
        {
            get => _contador;
            set
            {
                _contador = value;
                RaiseProperty();
            }
        }

    }
}
