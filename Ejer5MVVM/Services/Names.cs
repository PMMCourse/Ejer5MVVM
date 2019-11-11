using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ejer5MVVM.Services
{
    public class Names 
    {
        public List<string> GetNames()
        {
            return new List<string>()
            {
                "Ana",
                "Nacho",
                "Pedro",
            };
        }

        public string Checkindice(IList<string> Nombres, int Indice, string Mostrarindice)
        {
            for (int i = 0; i < Nombres.Count; i++)
            {
                if (Indice == Nombres.IndexOf(Nombres[i]))
                {
                    Mostrarindice = $"{Nombres[i]}, {Nombres.IndexOf(Nombres[i])}";
                    return Mostrarindice;
                }
            }
            return "No encontrado";
        }

        public void AddName(string Nom, IList<string> Nombres)
        {
            if (Nom != null && Nom != "")
            {
                Nombres.Add(Nom);
                MessageBox.Show("nombre añadido");
            }
            else
            {
                MessageBox.Show("Campo vacio");
            }

        }
        public void DelName(string NombreSele, IList<string> Nombres, string Nom)
        {
            if (NombreSele != null)
            {
                Nombres.Remove(NombreSele);
                MessageBox.Show("nombre eliminado");
            }
            else
            {
                foreach (var i in Nombres)
                {
                    if (Nom == i)
                    {
                        Nombres.Remove(Nom);
                        MessageBox.Show("nombre eliminado");
                        return;
                    }
                }
                MessageBox.Show("nombre no encontrado");
            }
        }
    }

}
