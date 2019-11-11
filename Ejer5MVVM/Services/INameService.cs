using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.Services
{
    public interface INameService
    {
        List<string>GetNames();
        void DelName();
        void AddName();
        string Checkindice();
    }
}
