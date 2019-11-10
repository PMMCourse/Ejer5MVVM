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
        List<string> terminos = new List<string>
        {
            "Pedro", "Maria", "Jose", "Juanki", "Chema"
        };
        
        
        private string _buscarPalabra;
        public string buscarPalabra
        {
            get => _buscarPalabra;
            set
            {
                _buscarPalabra = value;
                encontrarPalabra = terminos.FirstOrDefault(x => x.ToLower().Contains(_buscarPalabra.ToLower()));
                RaiseProperty();
            }
        }


        
        private string _encontrarPalabra;
        public string encontrarPalabra
        {
            get => _encontrarPalabra;
            set 
            {
                _encontrarPalabra = value;
                RaiseProperty();
            }
        }
    }
}
