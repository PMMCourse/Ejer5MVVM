using Ejer5MVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ejer5MVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private RelayCommand _addname;
        private RelayCommand _CheckIndice;
        public ICommand CheckIndice => _CheckIndice;
        public ICommand addname => _addname;
        private int _indice;
        public List<string> _Nombres = new List<string>()
        {
            "Ana",
            "Nacho",     
            "Pedro",
        };

        public MainViewModel()
        {
            _CheckIndice = new RelayCommand(Checkindice);
            _addname = new RelayCommand(Addname);
        }
        private string _NombreSele;
        public string NombreSele
        {
            get
            {
                return _NombreSele;
            }
            set
            {
               _NombreSele = value;
                RaiseProperty();
            }
        }

        public List<string> Nombres
        {
            get => _Nombres;
            set
            {
                _Nombres = value;
                RaiseProperty();
            }
        }
      
        private void Checkindice()
        {
            for (int i = 0; i < Nombres.Count; i++)
            {
                if (_indice == Nombres.IndexOf(Nombres[i]))
                {
                    MessageBox.Show(""+Nombres[i]+" "+ Nombres.IndexOf(Nombres[i]));
                }
            }
        }

        private void Addname()
        {
            _Nombres.Add("pepe");
            MessageBox.Show("nombre añadido");            
        }
        public int indice
        {
            get =>_indice;
            set
            {
                _indice = value;
                RaiseProperty();
            }
        }
    }
}
