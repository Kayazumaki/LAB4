using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB04_Zad2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            {
                

                

                int[] tablica = {35,4,754,123,35,62,0,730,84,6 }; //ile wartości w tablicy

                Console.WriteLine("zawartość tablicy");
                WypiszTablice(tablica);
                Console.ReadKey();
                Console.WriteLine("zawartość tablicy od tyłu");

                // Wypisywanie zawartości tablicy od tyłu
                Odtylu(tablica);

                

                // Sortowanie babelkowe
                Console.WriteLine("Sortowanie Babelkowe");
                
                niemain(tablica);

                
                Console.WriteLine("Sortowanie przez wstawianie");
                
                Ej(tablica);
                Console.ReadLine();

                wybieranie(tablica);

            }

            
            
            



        }
        static void WypiszTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
        }

        static void Odtylu(int[] tablica)
        {
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                
                Console.WriteLine(tablica[i]);


                
            }
            Console.ReadKey();
            
            
            // Znajdowanie najmniejszego i największego elementu tablicy
            int najmniejszy = NajmniejszyElement(tablica);
            int najwiekszy = NajwiekszyElement(tablica);

            Console.WriteLine("Kliknij dowolny przycisk, by z tablicy znaleźć najmiejszą i największą cyfrę");
            Console.ReadKey();

            Console.WriteLine("Najmniejszy element: " + najmniejszy);
            Console.WriteLine("Największy element: " + najwiekszy);

            Console.ReadLine();
        }

        

        static int NajmniejszyElement(int[] tablica)
        {
            int najmniejszy = tablica[0];

            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] < najmniejszy)
                {
                    najmniejszy = tablica[i];
                }
            }

            return najmniejszy;
        }

        static int NajwiekszyElement(int[] tablica)
        {
            int najwiekszy = tablica[0];

            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] > najwiekszy)
                {
                    najwiekszy = tablica[i];
                }
            }

            return najwiekszy;
        }


        // Sortowanie babelkowe
        static void niemain(int[] ints)
        {
            int[] tablica = ints;
            Console.WriteLine("Oryginalna Tablica:");
            PrintArray(tablica);

            BubbleSort(tablica);

            Console.WriteLine("Posegrowana Tablica:");
            PrintArray(tablica);
            Console.ReadKey();
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }



        static void Ej(int[] lol)
        {
            int[] tablica = lol;

            

            

            Console.WriteLine("Tablica po sortowaniu przez wstawianie:"); //bez zmian, jeśli porównano z bąbelkowym
            Poco(tablica);

            Console.ReadLine();
        }

        

        static void Poco(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            Console.WriteLine();

        }

        static void wybieranie(int[] co)
        {
            int[] tablica = co;

            

            Console.WriteLine("Tablica po sortowaniu przez wybieranie:");
            WyświetlTablice(tablica);

            Console.ReadLine();
        }

        static void SortowaniePrzezWybieranie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int indeksMin = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (tablica[j] < tablica[indeksMin])
                    {
                        indeksMin = j;
                    }
                }

                ZamienElementy(tablica, i, indeksMin);
            }
        }

        static void ZamienElementy(int[] tablica, int indeks1, int indeks2)
        {
            int temp = tablica[indeks1];
            tablica[indeks1] = tablica[indeks2];
            tablica[indeks2] = temp;
        }

        static void WyświetlTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            Console.WriteLine();
        }








    }

}
