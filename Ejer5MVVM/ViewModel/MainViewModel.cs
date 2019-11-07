using Ejer5MVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ejer5MVVM.ViewModel
{
   public class MainViewModel : BaseViewModel
    {
        private RelayCommand _insertarTexto;
        public ICommand InsertarTexto => _insertarTexto;

        private RelayCommand _mostrarTexto;

        //No sabía si era mejor cargar el texto automáticamente de un textBox a otro
        //o hacerlo entre 2 textBox
        public ICommand MostrarText => _mostrarTexto;

        public MainViewModel()
        {
            _insertarTexto = new RelayCommand(IntroducirTexto);
            _mostrarTexto = new RelayCommand(DevuelveCadena);


            //Así lo haría yo en una aplicación de consola
            //con el método de DevuelveCadena

            string frase, cadenaInvertida = "";
            int posicion = 0;

            frase = InsertarTexto.ToString();

            posicion = frase.Length;
            while (posicion > 0)
            {
                cadenaInvertida = cadenaInvertida + DevuelveCadena(frase, posicion - 1, 1);
                posicion = posicion - 1;

            }

            //Este MessageBox era para probar la conversión de texto

            MessageBox.Show("La frase invertida es: "+cadenaInvertida);
        }

        private void DevuelveCadena(int obj)
        {
            throw new NotImplementedException();
        }

        private void IntroducirTexto(int obj)
        {
            IntroduceText += obj.ToString();
        }       
        private static string DevuelveCadena(string parametro, int posicionPrimera, int longitud)
        {
            string resultado = parametro.Substring(posicionPrimera, longitud);
            return resultado;
        }

        private string _introduceText;
        public string IntroduceText
        {
            get => _introduceText;
            set
            {
                _introduceText = value;
                RaiseProperty();
            }
        }
    }
}
