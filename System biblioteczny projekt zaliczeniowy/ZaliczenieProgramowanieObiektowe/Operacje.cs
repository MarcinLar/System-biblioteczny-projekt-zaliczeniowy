using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaliczenieProgramowanieObiektowe
{
    internal static class Operacje
    {
        public static void WyswietlKsiazki(List<Ksiazka> lista)
        {
            int i = 0;

            foreach (var item in lista)
            {
                i++;
                Console.WriteLine($"{i.ToString().PadRight(3, ' ')} {item.Nazwa.PadRight(40, ' ')} {item.Autor.PadRight(25, ' ')} {item.Kategoria}");
            }     
        }

        public static void WysiwtlFaktury(List<Faktura> faktury)
        {
            int i = 0;

            foreach (var item in faktury)
            {
                i++;
                Console.WriteLine($"Faktura nr. {i}");
                item.WydrukujRachunek();
                Console.WriteLine();
            }
        }

        public static void WysiwtlParagony(List<Paragon> paragony)
        {
            int i = 0;

            foreach (var item in paragony)
            {
                i++;
                Console.WriteLine($"Paragon nr. {i}");
                item.WydrukujRachunek();
                Console.WriteLine();
            }
        }

        public static void WypelnijListeKsiazek(ref List<Ksiazka> lista)
        {
            lista.Add(new Ksiazka("Folwark Zwierzecy", "George Orwell", "fantastyka"));
            lista.Add(new Ksiazka("1984", "George Orwell", "fantastyka"));
            lista.Add(new Ksiazka("Francuska Encyklopedia", "Denis Diderot", "encyklopedia"));
            lista.Add(new Ksiazka("Słownik Języka Polskiego", "Halina Zgolkowa", "słownik"));
            lista.Add(new Ksiazka("Quo Vadis", "Henryk Sienkiewicz", "historyczna"));
            lista.Add(new Ksiazka("Lalka", "Boleslaw Prus", "powieść"));
            lista.Add(new Ksiazka("Solaris", "Stanislaw Lem", "fantastyka"));
            lista.Add(new Ksiazka("Medaliony", "Zofia Naukowska", "powieść"));
            lista.Add(new Ksiazka("Pan Tadeusz", "Adam Mickiewicz", "poezja"));
            lista.Add(new Ksiazka("dzieła wszystkie", "Czeslaw Milosz", "poezja"));
            lista.Add(new Ksiazka("Kwantechizm 2.0, czyli klatka na ludzi", "Andrzej Dragan", "popularnonaukowa"));
            lista.Add(new Ksiazka("Innowatorzy", "Walter Isaacson", "reportaż"));
            lista.Add(new Ksiazka("Nowy Długi Marsz Chiny ery Xi Jinpinga", "Bogdan Góralczyk", "reportaż"));
            lista.Add(new Ksiazka("CHIŃSKI FENIKS.", "Bogdan Góralczyk", "nauki społeczne"));
            lista.Add(new Ksiazka("Birma. Złota ziemia roni łzy", "Bogdan Góralczyk", "reportaż"));
            lista.Add(new Ksiazka("Węgierski syndrom Trianon", "Bogdan Góralczyk", "historia"));
            lista.Add(new Ksiazka("Wielki renesans. Chińska transformacja", "Bogdan Góralczyk", "nauki społeczne"));
            lista.Add(new Ksiazka("Sapiens. Od zwierząt do bogów", "Yuval Noah Harari", "popularnonaukowa"));
            lista.Add(new Ksiazka("Homo deus. Krótka historia jutra", "Yuval Noah Harari", "popularnonaukowa"));
            lista.Add(new Ksiazka("Opus magnum C++11", "Jerzy Grębosz", "informatyka"));
            lista.Add(new Ksiazka("To, co widzialne i to, czego nie widać", "Frederic Bastiat", "ekonomia"));
            lista.Add(new Ksiazka("Rząd. Krytyka socjalizmu", "Frederic Bastiat", "ekonomia"));
            lista.Add(new Ksiazka("Prawo", "Frederic Bastiat", "nauki społeczne"));
            lista.Add(new Ksiazka("Państwo", "Frederic Bastiat", "filozofia"));
            lista.Add(new Ksiazka("Ekonomia w jednej lekcji", "Henry Hazlitt", "ekonomia"));
            lista.Add(new Ksiazka("Ekonomia dla normalnych ludz", "Gene Callahan", "ekonomia"));
            lista.Add(new Ksiazka("Ekonomia wolnego rynku", "Murray N. Rothbard", "ekonomia"));
            lista.Add(new Ksiazka("Inteligentny Inwestor", "Benjamin Graham", "ekonomia"));
            lista.Add(new Ksiazka("Inflacja. Wróg publiczny nr 1", "Henry Hazlit", "ekonomia"));
            lista.Add(new Ksiazka("Wojny walutowe", "James Rickards", "ekonomia"));
            lista.Add(new Ksiazka("Kiedy umiera pieniądz", "Adam Fergusson", "ekonomia"));
            lista.Add(new Ksiazka("Kiedy nadchodzi kryzys", "Max Otte", "ekonomia"));
            lista.Add(new Ksiazka("Harry Potter i Komnata Tajemnic", "J.K. Rowling", "fantastyka"));
            lista.Add(new Ksiazka("Harry Potter i więzień Azkabanu", "J.K. Rowling", "fantastyka"));
            lista.Add(new Ksiazka("Harry Potter i Czara Ognia", "J.K. Rowling", "fantastyka"));
            lista.Add(new Ksiazka("Harry Potter i Zakon Feniksa", "J.K. Rowling", "fantastyka"));
            lista.Add(new Ksiazka("Harry Potter i Kamień Filozoficzny", "J.K. Rowling", "fantastyka"));
            lista.Add(new Ksiazka("Władca Pierścieni", "J.R.R. Tolkien", "fantastyka"));
            lista.Add(new Ksiazka("Hobbit, czyli tam i z powrotem", "J.R.R. Tolkien", "fantastyka"));
            lista.Add(new Ksiazka("Python od podstaw", "Moskała Marcin", "informatyka"));
            lista.Add(new Ksiazka("Java. Efektywne programowanie", "Bloch Joshua", "informatyka"));
            lista.Add(new Ksiazka("Zaawansowany Python", "Ramalho Luciano", "informatyka"));
            lista.Add(new Ksiazka("Linux. Komendy i polecenia", "Sosna Łukasz", "informatyka"));
            lista.Add(new Ksiazka("Uczenie maszynowe w Pythonie dla każdego", "Fenner Peter", "informatyka"));
            lista.Add(new Ksiazka("C# 9.0 w pigułce", "Albahari Joseph", "informatyka"));
            lista.Add(new Ksiazka("Język C++. Szkoła programowania", "Prata Stephen", "informatyka"));
            lista.Add(new Ksiazka("Unity. Przewodnik projektanta gier", "Geig Mike", "informatyka"));
            lista.Add(new Ksiazka("Microsoft XML. Vademecum", "Stanek William", "informatyka"));
            lista.Add(new Ksiazka("Linux. Biblia", "Negus Christopher", "informatyka"));
            lista.Add(new Ksiazka("Windows Server 2019 Inside Out", "Thomas Orin", "informatyka"));
        }
    }
}
