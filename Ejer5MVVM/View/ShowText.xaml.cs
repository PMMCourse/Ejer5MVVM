using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ejer5MVVM.View {
    public partial class ShowText : Window {
        ViewModel.MainViewModel vm;
        public ShowText(ViewModel.MainViewModel vm) {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
