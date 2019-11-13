using Ejer5MVVM.Services;
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

        private RelayCommand<String> _insertOperator;
        public ICommand InsertOperator => _insertOperator;

        public MainViewModel()
        {
            _insertNumberCommand = new RelayCommand<String>(PerformOperate);
            _insertOperator = new RelayCommand<String>(PerformOperator);
        }
        private void PerformOperator(String obj)
        {
            OperationResult += obj;
        }

        public void PerformOperate(String obj) {
           OperationResult=new CalcServices(OperationResult).DoCalc();
        }

        private string _numbersOperate;

        public string OperationResult
        {
            get => _numbersOperate;
            set
            {
                _numbersOperate = value;
                RaiseProperty();
            }
        }
    }
}
