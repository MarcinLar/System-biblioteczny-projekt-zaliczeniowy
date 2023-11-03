using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaliczenieProgramowanieObiektowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ksiazka> listaKsiazek = new List<Ksiazka>();
            List<Ksiazka> listaWypozyczonychKsiazek = new List<Ksiazka>();
            List<Paragon> paragony = new List<Paragon>();
            List<Faktura> faktury = new List<Faktura>();
            Operacje.WypelnijListeKsiazek(ref listaKsiazek);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. wypozycz ksiazke");
                Console.WriteLine("2. zwroc ksiazke");
                Console.WriteLine("3. dodaj ksiazke");
                Console.WriteLine("4. usun ksiazke");
                Console.WriteLine("5. wyswietl ksiazki");
                Console.WriteLine("6. wyswietl wyppozyczone ksiazki");
                Console.WriteLine("7. wyswietl faktury");
                Console.WriteLine("8. wyswietl paragony");
                Console.WriteLine("9. wyszukaj ksiazki po nazwie");
                Console.WriteLine("10. wyszukaj ksiazki po autorze");
                Console.WriteLine("11. wyszukaj ksiazki po kategorii");

                int x;
                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    x = 0;
                }

                switch (x)
                {
                    case 1:
                        int pCzyF = 0;
                        Console.WriteLine("Paragon czy faktura? (1/2)");
                        try
                        {
                            pCzyF = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                        }

                        if (pCzyF == 1)
                        {
                            Paragon paragon = new Paragon();
                            
                            Console.WriteLine("Podaj imie klienta: ");
                            paragon.ImieKlienta = Console.ReadLine();
                            Console.WriteLine("Podaj nazwisko klienta: ");
                            paragon.NazwiskoKlienta = Console.ReadLine();
                            Console.WriteLine("Podaj cene: ");
                            try
                            {
                                paragon.Cena = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Podaj liczbe");
                                Console.ReadKey();
                                break;
                            }
                            Console.WriteLine("Podaj nazwe ksiazki: ");
                            paragon.NazwaKsiazki = Console.ReadLine();
                            int index1 = listaKsiazek.FindIndex(b => b.Nazwa == paragon.NazwaKsiazki);
                            if (index1 == -1)
                            {
                                Console.WriteLine("Zla nazwa");
                                Console.ReadLine();
                            }
                            else
                            {
                                paragon.WydrukujRachunek();
                                paragony.Add(paragon);
                                listaWypozyczonychKsiazek.Add(listaKsiazek[index1]);
                                listaKsiazek.RemoveAt(index1);
                                Console.ReadLine();
                            }                           
                        }
                        else if (pCzyF == 2)
                        {
                            Faktura faktura = new Faktura();

                            Console.WriteLine("Podaj imie klienta: ");
                            faktura.ImieKlienta = Console.ReadLine();
                            Console.WriteLine("Podaj nazwisko klienta: ");
                            faktura.NazwiskoKlienta = Console.ReadLine();
                            Console.WriteLine("Podaj cene: ");
                            try
                            {
                                faktura.Cena = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Podaj liczbe");
                                Console.ReadKey();
                                break;
                            }
                            Console.WriteLine("Podaj nazwe ksiazki: ");
                            faktura.NazwaKsiazki = Console.ReadLine();
                            int index2 = listaKsiazek.FindIndex(b => b.Nazwa == faktura.NazwaKsiazki);
                            if (index2 == -1)
                            {
                                Console.WriteLine("Zla nazwa");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Podaj NIP: ");
                                try
                                {
                                    faktura.Nip = int.Parse(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Podaj liczbe");
                                    Console.ReadKey();
                                    break;
                                }
                                faktura.WydrukujRachunek();
                                faktury.Add(faktura);
                                listaWypozyczonychKsiazek.Add(listaKsiazek[index2]);
                                listaKsiazek.RemoveAt(index2);
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wybierz 1 lub 2");
                            Console.ReadKey();
                        }

                        break;

                    case 2:
                        Console.WriteLine("Podaj nazwe ksiazki: ");
                        string nazwaWypozyczonejKsiazki = Console.ReadLine();
                        int index3 = listaWypozyczonychKsiazek.FindIndex(b => b.Nazwa == nazwaWypozyczonejKsiazki);
                        if (index3 == -1)
                        {
                            Console.WriteLine("Zla nazwa");
                            Console.ReadLine();
                        }
                        else
                        {
                            listaKsiazek.Add(listaWypozyczonychKsiazek[index3]);
                            listaWypozyczonychKsiazek.RemoveAt(index3);
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Podaj nazwe ksiazki: ");
                        string nazwaKsiazki = Console.ReadLine();
                        Console.WriteLine("Podaj autora ksiazki: ");
                        string autorKsiazki = Console.ReadLine();
                        Console.WriteLine("Podaj kategorie ksiazki: ");
                        string kategoriaKsiazki = Console.ReadLine();

                        Ksiazka ksiazka = new Ksiazka(nazwaKsiazki, autorKsiazki, kategoriaKsiazki);
                        listaKsiazek.Add(ksiazka);
                        break;

                    case 4:
                        Console.WriteLine("Podaj nazwe ksiazki do usuniecia: ");
                        string ksiazkaDoUsuniecia = Console.ReadLine();

                        int index4 = listaKsiazek.FindIndex(b => b.Nazwa == ksiazkaDoUsuniecia);
                        if (index4 == -1)
                        {
                            Console.WriteLine("Zla nazwa");
                            Console.ReadLine();
                        }
                        else
                        {
                            listaKsiazek.RemoveAt(index4);
                            Console.WriteLine($"Ksiazka o nazwie '{ksiazkaDoUsuniecia}' zostala usunieta");
                            Console.ReadLine();
                        }
                        break;

                    case 5:
                        Operacje.WyswietlKsiazki(listaKsiazek);
                        if(listaKsiazek.Count == 0)
                        {
                            Console.WriteLine("Brak rekordow do wyswietlenia");
                        }
                        Console.ReadKey();
                        break;

                    case 6:
                        Operacje.WyswietlKsiazki(listaWypozyczonychKsiazek);
                        if (listaWypozyczonychKsiazek.Count == 0)
                        {
                            Console.WriteLine("Brak rekordow do wyswietlenia");
                        }
                        Console.ReadKey();
                        break;

                    case 7:
                        Operacje.WysiwtlFaktury(faktury);
                        if (faktury.Count == 0)
                        {
                            Console.WriteLine("Brak rekordow do wyswietlenia");
                        }
                        Console.ReadKey();
                        break;


                    case 8:
                        Operacje.WysiwtlParagony(paragony);
                        if (paragony.Count == 0)
                        {
                            Console.WriteLine("Brak rekordow do wyswietlenia");
                        }
                        Console.ReadKey();
                        break;

                    case 9:
                        Console.WriteLine("Podaj nazwe ksiazki ktora chcesz wyszukac:");
                        string szukanaKsiazka = Console.ReadLine();

                        int i = 0;

                        foreach (var item in listaKsiazek)
                        {
                            if (item.Nazwa == szukanaKsiazka)
                            {
                                i++;
                                Console.WriteLine($"Ksiazka nr. {i}");
                                item.KsiazkaInfo();
                                Console.WriteLine();
                            }
                        }
                        if (i == 0)
                        {
                            Console.WriteLine("Brak rekordow do wyswietlenia");
                        }
                        Console.ReadKey();
                        break;

                    case 10:
                        Console.WriteLine("Podaj autora ksiazki ktora chcesz wyszukac:");
                        string szukanyAutor = Console.ReadLine();

                        int j = 0;

                        foreach (var item in listaKsiazek)
                        {
                            if (item.Autor == szukanyAutor)
                            {
                                j++;
                                Console.WriteLine($"Ksiazka nr. {j}");
                                item.KsiazkaInfo();
                                Console.WriteLine();
                            }
                        }
                        if (j == 0)
                        {
                            Console.WriteLine("Brak rekordow do wyswietlenia");
                        }
                        Console.ReadKey();
                        break;

                    case 11:
                        Console.WriteLine("Podaj nazwe kategorii ktora chcesz wyszukac:");
                        string szukanaKategoria = Console.ReadLine();

                        int z = 0;

                        foreach (var item in listaKsiazek)
                        {
                            if (item.Kategoria == szukanaKategoria)
                            {
                                z++;
                                Console.WriteLine($"Ksiazka nr. {z}");
                                item.KsiazkaInfo();
                                Console.WriteLine();
                            }
                        }
                        if (z == 0)
                        {
                            Console.WriteLine("Brak rekordow do wyswietlenia");
                        }
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Podaj liczbe z przedzialu!");
                        Console.ReadKey();
                        break;
                }

            }
            
        }
    }
}
