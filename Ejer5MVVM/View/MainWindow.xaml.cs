using Ejer5MVVM.ViewModel;
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

namespace Ejer5MVVM.View
{
    /// <summary>
    /// Lógica de interacción para MainViewModel.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Añadimos el contexto de Datos para que Vista y ViewModel se encuentren conectados
            var vm = new MainViewModel();
            DataContext = vm;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
