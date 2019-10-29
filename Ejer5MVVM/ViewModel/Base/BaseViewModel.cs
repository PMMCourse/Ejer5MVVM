using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.ViewModel.Base
{
        //Implementamos INotifyPropertyChanged para poder invocar el evento de PropertyChanged
        //Que nos permitirá notificar a Vista y ViewModel por igual

        //Está clase se plantea abstracta (Que no tiene instancia, ya que solo la usaremos como padre)
        public abstract class BaseViewModel : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            public void RaiseProperty([CallerMemberName] string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
}
