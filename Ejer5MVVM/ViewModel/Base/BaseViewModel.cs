using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.ViewModel.Base
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseProperty([CallerMemberName]string texto = "" )
        {
            PropertyChanged?.Invoke(this, PropertyChangedEventArgs(texto));
        }
        private PropertyChangedEventArgs PropertyChangedEventArgs(string texto)
        {
            throw new NotImplementedException();
        }
    } 
}
