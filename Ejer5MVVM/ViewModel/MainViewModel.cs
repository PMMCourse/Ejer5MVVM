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
        private RelayCommand _Addname;
        private RelayCommand _Delname;
        private RelayCommand _CheckIndice;
        public ICommand CheckIndice => _CheckIndice;
        public ICommand Delname => _Delname;
        public ICommand Addname
        {
            get
            {
                if (_Addname == null)
                    _Addname = new RelayCommand(new Action(AddName));
                return _Addname;
            }
        }

        private int _Indice;
        private string _Nom;
        private string _NombreSele;
        private string _Mostrarindice;

        public ObservableCollection<string> _Nombres = new ObservableCollection<string>()
        {
            "Ana",
            "Nacho",
            "Pedro",
        };

        public MainViewModel()
        {
            _CheckIndice = new RelayCommand(Checkindice);
            _Delname = new RelayCommand(DelName);
           
        }

        public string Nom
        {
            get => _Nom;
            set
            {
                _Nom = value;
                RaiseProperty();
            }
        }

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
    
        public ObservableCollection<string> Nombres
        {
            get => _Nombres;
            set
            {
                _Nombres = value;
                RaiseProperty();
            }
        }

        public string Mostrarindice
        {
            get => _Mostrarindice;
            set
            {
                _Mostrarindice = value;
                RaiseProperty();
            }
        }

        public int Indice
        {
            get => _Indice;
            set
            {
                _Indice = value;
                RaiseProperty();
            }
        }

        private void Checkindice()
        {
            for (int i = 0; i < Nombres.Count; i++)
            {
                if (_Indice == Nombres.IndexOf(Nombres[i]))
                {
                    Mostrarindice = $"{Nombres[i]}, {Nombres.IndexOf(Nombres[i])}";
                }
            }
        }

        private void AddName()
        {
            if (Nom != null && Nom != "")
            {
                Nombres.Add(Nom);
                MessageBox.Show("nombre añadido");
                Nom = "";
            }
            else
            {
                MessageBox.Show("Campo vacio");
            }

        }

        private void DelName()
        {
            if(NombreSele != null)
            {
                Nombres.Remove(NombreSele);
                MessageBox.Show("nombre eliminado");
            }
            else 
            {
                foreach(var i in Nombres)
                {
                    if(Nom == i)
                    {
                        Nombres.Remove(Nom);
                        MessageBox.Show("nombre eliminado");
                        Nom = "";
                        return;
                    }
                }
                MessageBox.Show("nombre no encontrado");
                Nom = "";
            }           
        }
    }
}
