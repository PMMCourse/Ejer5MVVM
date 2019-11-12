using Ejer5MVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ejer5MVVM.ViewModel {
    public class MainViewModel : BaseViewModel {

        public MainViewModel() {
        }

        private string _customizedText;

        public string CustomizedText {
            get => _customizedText;
            set {
                _customizedText = value;
                RaiseProperty();
            }
        }
    }
}