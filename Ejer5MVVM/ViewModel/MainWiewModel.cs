using Ejer5MVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.ViewModel
{
    public class MainWiewModel : BaseViewModel
    {
        private List<string> _terminos = new List<string>()
        {
            "Pedro", 
            "Maria", 
            "Jose", 
            "Juanki", 
            "Chema"
        };
        
        
        private string _buscarPalabras;
        public string BuscarPalabras
        {
            get => _buscarPalabras;
            set
            {
                _buscarPalabras = value;
                EncontrarPalabras = _terminos.FirstOrDefault(x => x.ToLower().Contains(_buscarPalabras.ToLower()));
                RaiseProperty();
            }
        }


        
        private string _encontrarPalabras;
        public string EncontrarPalabras
        {
            get => _encontrarPalabras;
            set 
            {
                _encontrarPalabras = value;
                RaiseProperty();
            }
        }
    }
}
