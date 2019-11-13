using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ejer5MVVM.VistaModelo
{
    class VistaModeloPrincipal : BaseVistaModelo
    {

        private ICommand ejecutarNumero;
        public VistaModeloPrincipal()
        {
            //instancio la accion
            ejecutarNumero = new RelayCommand(PerfomEjecutarNumero);
        }

        //Para la pantalla
        private string pantalla;
        public string Pantalla
        {
            get => pantalla;
            set
            {
                pantalla = value;
                RaiseProperty();
            }
        }
        
        //asociacion del binding y del comando privado en el view model
        public ICommand Numero => ejecutarNumero;

        private void PerfomEjecutarNumero(object sender, EventArgs e)
        {
            /*
             pillo en todo momento el atributo content del boton pulsado y
             asi conozco lo que es y lo que hace el boton
             */
            string s = (sender as System.Windows.Controls.Button).Content.ToString();
            MessageBox.Show(s,"Me gustaria que imprimiese el content");
        }
    }
}
