using Ejer5MVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejer5MVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private string _tbDerecho;
        
        public string TbDerecho {
            get => _tbDerecho;
            set
            {
                _tbDerecho = value;
                RaiseProperty();
                ResolucionDeLaVuelta();
            }
        
        }

        private string _tbReves;
         public string TbReves {
            get => _tbReves;
            set {

                _tbReves = value;
                RaiseProperty();

            }
        }

        

        private RelayCommand _voltearCosasDeEscribir;
        public ICommand VoltearCosasDeEscribir => _voltearCosasDeEscribir;

        public MainViewModel() {
            _voltearCosasDeEscribir = new RelayCommand(ResolucionDeLaVuelta);
        }

        private void ResolucionDeLaVuelta()
        {

            int t = _tbDerecho.Length;
            for (int i = t - 1; i >= 0; i--)
            {
                TbReves = TbReves + _tbDerecho.Substring(i, 1);
            }
        }
    }
}
