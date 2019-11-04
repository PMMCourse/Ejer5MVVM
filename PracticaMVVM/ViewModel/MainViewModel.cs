using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace PracticaMVVM.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        //Clase principal para el ViewModel que hereda del BaseViewModel y poder utilizar el RaiseProperty.
        //En esta clase es donde tendremos los atributos que vamos a conectar con los textbox, botones... etc.
        //Cuando conectamos con Binding, nos estamos refiriendo, en este caso, a los atributos de esta clase.

        //Para poder "conectar" o utilzar esta clase, necesitamos crear una instancia de ella en el .cs de la ventana en cuestion,
        //en este caso, solo tenemos una por lo cual sera la principal.

        //El metodo RaiseProperty, notificara que cada atributo ha sido modificado.

        public MainViewModel()
        {
            //Constructor no usado actualmente.
        }

        private double _numeroIntroducido;
        private double _resultado10p;
        private double _resultado20p;

        public double NumeroIntroducido
        {
            get => _numeroIntroducido;
            set
            {
                _numeroIntroducido = value;
                Resultado10p = (NumeroIntroducido * 10)/100;
                Resultado20p = (NumeroIntroducido * 20)/100;
                RaiseProperty();
            }
        }
        public double Resultado10p 
        {
            get => _resultado10p;
            set 
            {
                _resultado10p = value;
                RaiseProperty();          
            } 
        }

        public double Resultado20p 
        {
            get => _resultado20p;
            set 
            {
                _resultado20p = value;
                RaiseProperty();        
            }
        }

    }
}
