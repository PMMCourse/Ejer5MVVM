using Ejer5MVVM.View;
using System;
using System.Collections;
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

namespace Ejer5MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Persona> lista = new List<Persona>();

            Persona p1 = new Persona("marta", "castro");
            Persona p2 = new Persona("Victor", "Alonso");
            Persona p3 = new Persona("Marina", "cascon");
            Persona p4 = new Persona("Jose", "Rodriguez");
            Persona p5 = new Persona("Natalia", "Ruiz");
            Persona p6 = new Persona("David", "ALvarez");
            Persona p7 = new Persona("Ramon", "Salado");
            Persona p8 = new Persona("Raul", "Gonzalez");
            Persona P9 = new Persona("Franco", "Vazquez");
            Persona p10 = new Persona("manuel", "Elliott");
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);
            lista.Add(p5);
            lista.Add(p6);
            lista.Add(p7);
            lista.Add(p8);
            lista.Add(P9);
            lista.Add(p10);

        }


        private void Button_Click(List<Persona> lista, RoutedEventArgs e)
        {
            List<Persona> lista2 = new List<Persona>();
            Persona p = new Persona("", "");
            foreach (var i in lista2)
            {
                lista2.Add(p);
                lista.Remove(p);
            }

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectlistItem sli = new SelectlistItem();
         
        }
    }

    internal class SelectlistItem
    {
       
    }
}

