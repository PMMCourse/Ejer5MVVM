using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ejer5MVVM.Services
{
    class MainServices
    {
       

        internal void ImprimeMsg(string TextGreetings)
        {
            if (TextGreetings == "1" | TextGreetings == "3")
            {
                MessageBox.Show("Vaya suspenso te va a caer");
            }
            else
            {
                MessageBox.Show("Muy bien pelotilla");
            }
        }
    }
}
