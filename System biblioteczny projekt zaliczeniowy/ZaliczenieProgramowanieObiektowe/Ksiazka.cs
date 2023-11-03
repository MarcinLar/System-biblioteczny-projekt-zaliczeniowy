using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaliczenieProgramowanieObiektowe
{
    internal class Ksiazka : IKsiazka
    {
        public string Nazwa { get; set; }
        public string Autor { get; set; }
        public string Kategoria { get; set; }

        public Ksiazka(string nazwa, string autor, string kategoria)
        {
            Nazwa = nazwa;
            Autor = autor;
            Kategoria = kategoria;
        }

        public void KsiazkaInfo()
        {
            Console.WriteLine($"nazwa: {Nazwa}");
            Console.WriteLine($"autor: {Autor}");
            Console.WriteLine($"kategoria: {Kategoria}");
        }
    }
}
