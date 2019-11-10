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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PracticaMVVM.ViewModel; //Importamos la carpeta donde tenemos las clases de ViewModel.

namespace PracticaMVVM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Aqui es donde vamos a conectar con el ViewModel, para ello creamos la instancia de ella, ya que es la clase donde estan los atributos
            //que nos interesa conectar:

            var vm = new MainViewModel(); //Guardamos la instancia.
            DataContext = vm; // Se la añadimos a DataConext.

        }
    }
}
