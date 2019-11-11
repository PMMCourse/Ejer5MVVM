using Ejer5MVVM.Services;
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
        Names n = new Names();
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

        public ObservableCollection<string> _Nombres = new ObservableCollection<string>();

        public ObservableCollection<string> Nombres
        {
            get => _Nombres;
            set
            {
                _Nombres = value;
                RaiseProperty();
            }
        }

        public MainViewModel()
        {
            LoadNames();
            InitCommands();
        }
        private void InitCommands()
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
            Mostrarindice = n.Checkindice(Nombres, Indice, Mostrarindice);
        }

        private void AddName()
        {
            n.AddName(Nom, Nombres);
            Nom = "";

        }

        private void DelName()
        {
            n.DelName(NombreSele, Nombres, Nom);
            Nom = "";

        }

        private void LoadNames()
        {
            _Nombres = new ObservableCollection<string>(n.GetNames());
        }
    }
}
