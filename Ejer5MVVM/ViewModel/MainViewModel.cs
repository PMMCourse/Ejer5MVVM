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
    class MainViewModel : BaseViewModel
    {
        private RelayCommand<String> _insertNumberCommand;
        public ICommand InsertNumberCommand => _insertNumberCommand;
        public MainViewModel()
        {
            _insertNumberCommand = new RelayCommand<String>(PerformInsertNumber);
        }

        private void PerformInsertNumber(String obj)
        {
            Double numero1, numero2;
            String[] array = null;
            if (obj.Contains("+")) {
                array = obj.Split('+');
                numero1 = Convert.ToDouble(array[0].Trim());
                numero2 = Convert.ToDouble(array[1].Trim());
                Double resultado = numero1 + numero2;
                _numbersOperate = resultado.ToString();
                MessageBox.Show(_numbersOperate);
            } else if (obj.Contains("-")) {
                array = obj.Split('-');
                numero1 = Convert.ToDouble(array[0].Trim());
                numero2 = Convert.ToDouble(array[1].Trim());
                Double resultado = numero1 - numero2;
                _numbersOperate = resultado.ToString();
                MessageBox.Show(_numbersOperate);
            }
            else if (obj.Contains("*"))
            {
                array = obj.Split('*');
                numero1 = Convert.ToDouble(array[0].Trim());
                numero2 = Convert.ToDouble(array[1].Trim());
                Double resultado = numero1 * numero2;
                _numbersOperate = resultado.ToString();
                MessageBox.Show(_numbersOperate);
            }
            else if (obj.Contains("/"))
            {
                array = obj.Split('/');
                numero1 = Convert.ToDouble(array[0].Trim());
                numero2 = Convert.ToDouble(array[1].Trim());
                Double resultado = numero1 / numero2;
                _numbersOperate = resultado.ToString();
                MessageBox.Show(_numbersOperate);
            }
        }

        private string _numbersOperate;

        public string OperationResult
        {
            get => _numbersOperate;
            set
            {
                _numbersOperate = value;
                //Cuando hacemos llamada del método RaiseProperty lanzamos la notificación de que esta 
                //propiedad se ha visto modificada, para que todos los interesados puedan consultar su valor.
                RaiseProperty();
            }
        }
    }
}
