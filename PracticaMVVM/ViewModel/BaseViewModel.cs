using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PracticaMVVM.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseProperty([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //CallerMemberName -> Se usa para recibir el nombre del metodo que lo invoca.
        // [?] -> "Ignora" el valor nulo.
        //Invoke -> Acciona o utiliza lo que pasamos por parametros.

        //El metodo RaiseProperty -> Se utiliza para notificar que una propiedad ha sido modificada, y poder utilizar esto en el View.
        //Este metodo se crea para ahorrar reutilizar el codigo.
    }
}
