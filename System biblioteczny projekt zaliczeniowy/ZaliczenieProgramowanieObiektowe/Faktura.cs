using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaliczenieProgramowanieObiektowe
{
    internal class Faktura: Rachunek
    {
        public int Nip { get; set; }

        public override void WydrukujRachunek()
        {
            Console.WriteLine($"Imie: {ImieKlienta} Nazwisko: {NazwiskoKlienta} NIP: {Nip}, {Cena}zł, {NazwaKsiazki}");
        }
    }
}
