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

        //Cuando creamos un comando, creamos el campo privado de la implementación de ICommand, en este caso RelayCommand.
        //Y la interfaz será publica, ya que es el mínimo exponente necesario para su uso.
        private RelayCommand<string> _checkTextGreetingsCommand;
        public ICommand CheckTextGreetingsCommand => _checkTextGreetingsCommand;

        private RelayCommand<string> _insertNumberCommand;
        public ICommand InsertNumberCommand => _insertNumberCommand;

        public MainViewModel()
        {
            _checkTextGreetingsCommand = new RelayCommand<string>(ImprimeMsg);
            _insertNumberCommand = new RelayCommand<string>(PerformCheckText);
        }

        private void ImprimeMsg(string obj)
        {
            if (TextGreetings == "1" || TextGreetings == "3")
            {
                MessageBox.Show("Vaya suspenso te va a caer");
            }
            else
            {
                MessageBox.Show("Muy bien pelotilla");
            }
        }

        private void PerformCheckText(string obj)
        {
            TextGreetings += obj;

        }

        private string _textGreetings;

        public string TextGreetings
        {
            get => _textGreetings;
            set
            {
                _textGreetings = value;
                //Cuando hacemos llamada del método RaiseProperty lanzamos la notificación de que esta 
                //propiedad se ha visto modificada, para que todos los interesados puedan consultar su valor.
                RaiseProperty();
            }
        }
    }
}

