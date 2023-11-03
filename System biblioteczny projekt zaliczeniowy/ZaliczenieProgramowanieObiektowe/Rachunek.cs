using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaliczenieProgramowanieObiektowe
{
    internal abstract class Rachunek
    {
        public string ImieKlienta { get; set; }
        public string NazwiskoKlienta { get; set; }
        public double Cena { get; set; }
        public string NazwaKsiazki { get; set; }
        public virtual void WydrukujRachunek()
        {
            Console.WriteLine($"Imie: {ImieKlienta} Nazwisko: {NazwiskoKlienta}, {Cena}zł, {NazwaKsiazki}");
        }
    }
}
