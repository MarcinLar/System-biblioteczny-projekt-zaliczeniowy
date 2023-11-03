using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaliczenieProgramowanieObiektowe
{
    internal interface IKsiazka
    {
        string Nazwa { get; set; }
        string Autor { get; set; }
        string Kategoria { get; set; }
    }
}
