using Ejer5MVVM.View;
using Ejer5MVVM.MainVIewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejer5MVVM.MainVIewModel
{
    class mainVIewModel:BaseViewModel
    {
        private RelayCommand<string> _cambiosPalabras;
        public ICommand cambiosPalabras => _cambiosPalabras;

        private RelayCommand<string> _borrarPalabras;
        public ICommand borrarPalabras => _borrarPalabras;

        public mainVIewModel(string obj)
        {
            _cambiosPalabras = new RelayCommand<string>(cambiarpalabras);
            _borrarPalabras = new RelayCommand<string>(borradoPalabras);
        }

        private void borradoPalabras(string obj)
        {

            _borrarPalabras = new RelayCommand(obj);
            RaiseProperty();

        }

        private void cambiarpalabras(string obj)
        {
            _cambiosPalabras = new RelayCommand(obj);
            RaiseProperty();
        }

    }
}
