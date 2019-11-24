using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.View
{
    class Persona
    {
        public string nombre
        {
            get => nombre;
            set
            {
                this.nombre = value;
            }
        }
        public string apellidos
        {
            get => apellidos;
            set
            {
                this.apellidos = value;

            }
        }
        public Persona(String nombre,string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

    }
}
