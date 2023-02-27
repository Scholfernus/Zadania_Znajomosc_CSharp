using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Zadania_Znajomosc_CSharp
    {
    class Program
        {
        static void Main(string[] args)
            {
            //Zadanie 1.5 str. 14
            int a = 37, b = 11;
            int wynikDzielenia = a / b;
            Console.WriteLine("Wynik dzielenia bez reszty liczb {0} oraz {1}, to {2}.", a, b, wynikDzielenia);
            Console.WriteLine(a + " / " + b + " = " + wynikDzielenia);

            //Zadanie 1.6. Napisz program, który oblicza resztę z dzielenia całkowitego dwóch liczb
            double wynikDzielenia2 = a % b;
            Console.WriteLine("Wynik dzielenia z resztą liczb {0} oraz {1}, to {2}.", a, b, wynikDzielenia2);
            Console.WriteLine(a + " % " + b + " = " + wynikDzielenia2);

            /* Zadanie 1.7.Napisz program, który oblicza sumę, różnicę, iloczyn i iloraz dla dwóchliczb x i y wprowadzanych z klawiatury. W programie przyjmujemy, że zmienne x i y są typu double(typu rzeczywistego).Wszystkie zmienne należy wyświetlić z dokładnością
            do dwóch miejsc po przecinku.*/
            double suma, roznica, iloczyn, iloraz, x, y;
            Console.Write("Za chwilę poproszę Cię o podanie 2 dowolnych liczb x i y, następnie otrzymasz sumę, różnicę, iloczyn oraz iloraz tych liczb\nPodaj liczbę x = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę y = ");
            y = double.Parse(Console.ReadLine());
            suma = x + y;
            roznica = x - y;
            iloczyn = x * y;
            iloraz = x / y;
            Console.WriteLine(x + " + " + y + " = " + suma);
            Console.WriteLine(x + " - " + y + " = " + roznica);
            Console.WriteLine(x + " * " + y + " = " + iloczyn);
            Console.WriteLine(x + " / " + y + " = " + iloraz);

            /*Zadanie 2.1. Napisz program, który dla trzech liczb a, b, c wprowadzonych z klawiatury sprawdza, czy tworzą one trójkę pitagorejską*/
            Console.WriteLine();
            int c, d, e;
            Console.Write("Podaj liczbę c = ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę d = ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę e = ");
            e = int.Parse(Console.ReadLine());
            if (c * c + d * d == e * e)
                {
                Console.WriteLine("Liczby stanowią trójkę Pitagoasa\n");
                }
            else
                {
                Console.WriteLine("Liczby nie stanowią trójki Pitagorasa\n");
                }
            //Zadanie 2.5.Napisz program, w którym użytkownik zgaduje całkowitą liczbę losową z przedziału od 0 do 9 generowaną przez komputer.
            //Random random = new Random();
            //int liczba;
            //Console.WriteLine("Guessing number");
            //Console.WriteLine("Zgadnij jaką liczbę wylosował komputer ?");
            //int jaka = random.Next(0, 3);
            //do
            //    {
            //    Console.Write("Podaj wylosowaną liczbę = ");
            //    liczba = int.Parse(Console.ReadLine());
            //    if (jaka == liczba)
            //        {
            //        Console.WriteLine("Niesamowite, odgadłeś wylosowaną liczbę przez komputer");
            //        }
            //    else
            //        {
            //        Console.WriteLine("Niestety to nie ta liczba");
            //        }
            //    } while (jaka != liczba);
            //Zadanie 3.1. Napisz program, który za pomocą instrukcji for dla danych wartości i zmieniających się w przedziale od 0 do 10 obliczy wartość funkcji j = 3*i.
            int j;
            for (int i = 0; i < 10; i++)
                {
                Console.WriteLine("{1} = 3 * {0}", i, j = 3 * i);
                }
            Console.WriteLine();
            //Zadanie 3.2. Napisz program, który za pomocą instrukcji do ... while dla danych wartości x zmieniających się od 0 do 10 oblicza wartość funkcji y = 3x. strona 30
            int k = 0, l = 0;
            do
                {
                k = 3 * l;
                Console.WriteLine("k = 3 x l      k = " + k + '\t' + " l = " + l);
                l++;
                } while (l <= 10);
            //Zadanie 3.3. Napisz program, który za pomocą instrukcji while dla danych wartości x zmieniających się od 0 do 10 oblicza wartość funkcji y = 3x.
            int aa = 0, bb = 0;
            while (bb <= 10)
                {
                aa = 3 * bb;
                Console.WriteLine("{1} = 3 * {0}", bb, aa = 3 * bb);
                bb++;
                }
            //Zadanie 3.4. Napisz program, który za pomocą instrukcji for wyświetla liczby całkowite od 1 do 20.
            Console.WriteLine("\nWyświetla liczby od 1 do 20");
            for (int i = 0; i <= 20; i++)
                {
                if (i < 20)
                    {
                    Console.Write(i + ", ");
                    }
                else
                    {
                    Console.Write(i + ".");
                    }
                }
            //Zadanie 3.5. Napisz program, który za pomocą instrukcji do ... while wyświetla liczby całkowite od 1 do 20.
            Console.WriteLine();
            int numb = 1;
            do
                {
                if (numb < 20)
                    {
                    Console.Write(numb + ", ");
                    }
                else
                    {
                    Console.Write(numb + ".");
                    }
                numb++;
                } while (numb <= 20);
            //Zadanie 3.6. Napisz program, który za pomocą instrukcji while wyświetla liczby całkowite od 1 do 20.
            Console.WriteLine();
            int numero = 1;
            while (numero <= 20)
                {
                if (numero < 20)
                    {
                    Console.Write(numero + ", ");
                    }
                else
                    {
                    Console.Write(numero + ".");
                    }
                numero++;
                }
            //Zadanie 3.7. Napisz program, który za pomocą instrukcji for sumuje liczby całkowite od 1 do 100.
            Console.WriteLine("Program sumuje liczby od 1 do 100");
            int sumaLiczb = 0;
            for (int i = 0; i <= 100; i++)
                {
                sumaLiczb = sumaLiczb + i;
                }
            Console.Write("Suma liczb od 1 do 100 wynosi {0}", sumaLiczb);
            //Zadanie 3.8. Napisz program, który za pomocą instrukcji do ... while sumuje liczby całkowite od 1 do 100.
            int ile = 0, co = 0;
            do
                {
                ile += co;
                co++;
                } while (co <= 100);
            Console.WriteLine("\nSuma liczb od 1 do 100 wynosi {0}", ile);
            //Zadanie 3.9. Napisz program, który za pomocą instrukcji while sumuje liczby całkowite od 1 do 100.
            int ile2 = 0, co2 = 0;
            while (co2 <= 100)
                {
                ile2 += co2;
                co2++;
                }
            Console.WriteLine("Suma liczb od 1 do 100 wynosi {0}\n", ile2);
            //Zadanie 3.10. Napisz program, który za pomocą instrukcji for sumuje liczby parzyste od 1 do 100 (strona 36)
            int razem = 0;
            for (int i = 0; i <= 100; i++)
                {
                if (i % 2 == 0)
                    {
                    razem += i;
                    }
                }
            Console.WriteLine("Suma parzystych liczb od 0 do 100 wynosi {0}", razem);
            //Zadanie 3.11.Napisz program, który za pomocą instrukcji do ... while sumuje liczby parzyste od 1 do 99.
            int one = 0, together = 0;
            do
                {
                if (one % 2 == 0)
                    {
                    together += one;
                    }
                one++;
                } while (one < 100);
            Console.WriteLine("Suma parzystych liczb od 0 do 99 wynosi {0}", together);
            //Zadanie 3.12. Napisz program, który za pomocą instrukcji while sumuje liczby parzyst z przedziału od 1 do 98.
            int ile3 = 0, razem2 = 0;
            while (ile3 < 98)
                {

                if (ile3 % 2 == 0)
                    {
                    razem2 += ile3;
                    }
                ile3++;
                }
            Console.WriteLine("Suma parzystych liczb od 0 do 99 wynosi {0}", razem2);
            //Zadanie 3.13. Napisz program, który za pomocą instrukcji for sumuje liczby nieparzyste od 1 do 100 (strona 38).
            int suma3 = 0;
            for (int i = 0; i <= 100; i++)
                {
                if (!(i % 2 == 0))
                    {
                    suma3 += i;
                    }
                }
            Console.WriteLine("Suma nieparzystych liczb od 0 do 100 wynosi {0}", suma3);
            //Zadanie 3.14.Napisz program, który za pomocą instrukcji do ... while sumuje liczby nieparzyste w przedziale od 1 do 98
            int suma2 = 0, g = 0;
            do
                {
                if (!(g % 2 == 0))
                    {
                    suma2 += g;
                    }
                g++;
                } while (g <= 98);
            Console.WriteLine("Suma nieparzystych liczb od 0 do 98 wynosi {0}", suma2);
            //Zadanie 3.15. Napisz program, który za pomocą instrukcji while sumuje liczby nieparzyste w przedziale od 1 do 100 (strona 40).
            int suma4 = 0, h = 0;
            while (h <= 98)
                {
                if (!(h % 2 == 0))
                    {
                    suma4 += h;
                    }
                h++;
                }
            Console.WriteLine("Suma nieparzystych liczb od 0 do 98 wynosi {0}", suma4);
            //Zadanie 3.16. Napisz program, który za pomocą instrukcji for znajduje największą i najmniejszą liczbę ze zbioru n wylosowanych liczb całkowitych od 0 do 99(w zadaniu n = 5) oraz oblicza średnią ze wszystkich liczb.
            double min, maks, srednia, liczba, ileRazy = 6, sum = 0;
            Random losuj = new Random();
            min = Math.Round(100 * (losuj.NextDouble()));
            Console.WriteLine();
            maks = min;
            suma = suma + maks;
            Console.Write("Wylosowano liczbę: " + min + ", ");

            for (int i = 2; i <= ileRazy; i++)
                {
                liczba = losuj.Next(0, 101);
                if (i < ileRazy)
                    Console.Write(liczba + ", ");
                else
                    {
                    Console.WriteLine(liczba + ".");
                    }
                if (maks < liczba)
                    {
                    maks = liczba;
                    if (liczba < min)
                        {
                        min = liczba;
                        }
                    }
                sum += liczba;
                }
            Console.WriteLine();
            Console.WriteLine("Największa liczba to {0}", maks);
            Console.WriteLine("Najmniejsza liczba to {0}", min);
            srednia = sum / ileRazy;
            Console.WriteLine("Srednia wylosowanych liczb wynosi {0}", srednia);

            //Zadanie 3.17.Napisz program, który za pomocą instrukcji do ... while znajduje największą i najmniejszą liczbę ze zbioru n wylosowanych liczb całkowitych od 0 do 99 (w zadaniu n = 5) oraz oblicza średnią ze wszystkich liczb. strona 43
            double minimum, max, razem1 = 0, avrg, ileLiczb = 0, wynik;
            Random r = new Random();
            minimum = Math.Round(100 * (r.NextDouble()));
            max = minimum;
            do
                {
                wynik = r.Next(0, 101);
                if (ileLiczb < 5)
                    Console.Write(wynik + ", ");
                else
                    {
                    Console.WriteLine(wynik + ".");
                    }
                if (max < wynik)
                    minimum = max;
                if (wynik < minimum)
                    {
                    minimum = wynik;
                    }
                ileLiczb++;
                razem1 += wynik;
                } while (ileLiczb <= 5);
            Console.WriteLine();
            Console.WriteLine("Największa liczba to {0}", max);
            Console.WriteLine("Najmniejsza liczba to {0}", minimum);
            avrg = razem1 / ileLiczb;
            Console.WriteLine("Srednia wylosowanych liczb wynosi {0}", avrg);
            //Zadanie 3.19. Napisz program wyświetlający tabliczkę mnożenia dla liczb od 1 do 100 (tj. 10 × 10) z wykorzystaniem podwójnej pętli for.
            for (int i = 1; i <= 10; i++)
                {
                for (int m = 1; m <= 10; m++)
                    {
                    Console.Write(i * m + "\t");
                    }
                Console.WriteLine();
                }
            //Zadanie 3.20. Napisz program wyświetlający tabliczkę mnożenia dla liczb od 1 do 100(tj. 10 × 10) z wykorzystaniem podwójnej pętli do ... while.
            Console.WriteLine();
            int o = 1, p, petla = 10;
            do
                {
                p = 1;
                do
                    {
                    Console.Write(o * p + "\t");
                    p++;
                    }
                while (p <= petla);
                o++;
                Console.WriteLine();
                }
            while (o <= petla);
            //Zadanie 3.21. Napisz program wyświetlający tabliczkę mnożenia dla liczb od 1 do 100 (tj. 10 × 10) z wykorzystaniem podwójnej pętli while. strona 47
            Console.WriteLine();
            int n = 10, wiersz = 1, kolumna;
            while (wiersz <= n)
                {
                kolumna = 1;

                while (kolumna <= n)
                    {
                    Console.Write(wiersz * kolumna + "\t");
                    kolumna++;
                    }
                wiersz++;
                Console.WriteLine();
                }
            //Zadanie 3.22. Napisz program, który wyświetla duże litery alfabetu od A do Z i od Z do A z wykorzystaniem pętli for. strona 48
            Console.WriteLine();
            char znak;
            for (znak = 'A'; znak <= 'Z'; znak++)
                {
                Console.Write(znak + " ");
                }
            Console.WriteLine();
            for (char i = 'Z'; i >= 'A'; i--)
                {
                Console.Write(i + " ");
                }
            //Zadanie 3.22.Napisz program, który wyświetla duże litery alfabetu od A do Z i od Z do A z wykorzystaniem pętli for.
            Console.WriteLine();
            char litera = 'A';
            do
                {
                Console.Write(litera + " ");
                litera++;
                } while (litera <= 'Z');
            Console.WriteLine();
            char litera2 = 'Z';
            do
                {
                Console.Write(litera2 + " ");
                litera2--;
                } while (litera2 >= 'A');
            // Zadanie 3.24. Napisz program, który wyświetla duże litery alfabetu od A do Z i od Z do A z wykorzystaniem pętli while.
            Console.WriteLine();
            char lit = 'A';
            while (lit <= 'Z')
                {
                Console.Write(lit + " ");
                lit++;
                }
            Console.WriteLine();
            char z = 'Z';
            while (z >= 'A')
                {
                Console.Write(z + " ");
                z--;
                }
            //Zadanie 3.25. Wiedząc, że 1233 = 122 + 332, napisz program, który znajduje wszystkie liczby z przedziału od 1000 do 9999 spełniające taką ciekawą zależność. Program dodatkowo liczy ich ilość. Strona 51
            Console.WriteLine();
            int jj = 0;
            for (int i = 1000; i < 10000; i++)
                {
                int pdcyfry = i / 100;
                int odcyfry = i % 100;

                if (pdcyfry * pdcyfry + odcyfry * odcyfry == i)
                    {
                    Console.WriteLine(i + " = " + pdcyfry + "*" + pdcyfry + "+" + odcyfry + "*" + odcyfry);
                    jj++;
                    }
                }
            Console.WriteLine("Znaleziono " + jj + " cyfry");
            // Zadanie 3.28. Korzystając z dowolnej instrukcji iteracyjnej, napisz program, który generuje następujący ciąg liczb: strona 54 00112233445566778899
            int iks;
            for (int i = 0; i < 20; i++)
                {
                iks = i / 2;
                Console.Write(iks);
                }
            Console.WriteLine();
            // Zadanie 4.1. Napisz program, który w 10-elementowej tablicy jednowymiarowej o nazwie dane umieszcza liczby od 0 do 9
            int[] dane = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int item in dane)
                {
                Console.WriteLine(dane[item].ToString() + " " + item.ToString());
                }
            // Zadanie 4.1. Napisz program, który w 10-elementowej tablicy jednowymiarowej o nazwie dane umieszcza liczby od 0 do 9
            int t = 10;
            int[] tablica = new int[t];
            for (int i = 0; i < t; i++)
                {
                tablica[i] = i;
                Console.WriteLine("tablica[" + i + "] = " + tablica[i]);
                }
            // Zadanie 4.2. Napisz program, który w jednowymiarowej 10-elementowej tablicy dane umieszcza liczby od 9 do 0
            int[] tab = new int[t];
            for (int i = 0; i < t; i++)
                {
                tab[i] = ((t - i) - 1);
                Console.WriteLine("Dane [" + i + "]  = " + tab[i].ToString());
                }
            // Zadanie 4.3. Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10 × 10 o nazwie macierz umieszcza na przekątnej liczbę 1, a poza przekątną 0.Dodatkowo program powinien obliczać sumę wyróżnionych w tablicy elementów, tj. elementów znajdujących się na jej przekątnej. strona 62
            int sumaPrzekątnej = 0;
            int[,] macierz = new int[10, 10];
            for (int i = 0; i < 10; i++)
                {
                for (int s = 0; s < 10; s++)
                    if (i == s)
                        {
                        macierz[i, s] = 1;
                        }
                    else
                        macierz[i, s] = 0;
                }
            for (int i = 0; i < 10; i++)
                {
                for (int s = 0; s < 10; s++)
                    {
                    Console.Write(macierz[i, s] + "  ");
                    }
                Console.WriteLine();
                }
            for (int i = 0; i < 10; i++)
                {
                for (int s = 0; s < 10; s++)
                    {
                    sumaPrzekątnej += macierz[i, s];
                    }
                }
            Console.WriteLine("Suma wyróżnionych elementów w tablicy wynosi {0}", sumaPrzekątnej);
            //Zadanie 4.4. Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10 × 10 o nazwie macierz umieszcza na przekątnej liczby od 0 do 9, a poza przekątną 0.Dodatkowo program powinien obliczać sumę wyróżnionych w tablicy elementów, tj. elementów znajdujących się na przekątnej tablicy. strona 64
            int sumali = 0;
            int[,] tab2 = new int[10, 10];
            for (int i = 0; i < t; i++)
                {
                for (int w = 0; w < t; w++)
                    {
                    if (i == w)
                        tab2[i, w] = i;
                    else
                        tab2[i, w] = 0;
                    }
                }
            for (int i = 0; i < t; i++)
                {
                for (int w = 0; w < t; w++)
                    {
                    Console.Write(tab2[i, w] + "  ");
                    }
                Console.WriteLine();
                }
            for (int i = 0; i < t; i++)
                {
                for (int w = 0; w < t; w++)
                    {
                    sumali += tab2[i, w];
                    }
                }
            Console.WriteLine("Suma liczb na przekątnej wynosi {0}", sumali);
            // Zadanie 4.5. Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10 × 10 o nazwie macierz umieszcza liczby 1 i 0 zgodnie z zamieszczoną poniżej interpretacją graficzną. Program dodatkowo powinien obliczać sumę wyróżnionych elementów strona 66
            int sumOfNumbers = 0;
            int[,] tab3 = new int[10, 10];
            for (int i = 0; i < t; i++)
                {
                for (int u = 0; u < t; u++)
                    {
                    if (i == t - u - 1)
                        tab3[i, u] = 1;
                    else
                        tab3[i, u] = 0;
                    }
                }
            for (int i = 0; i < t; i++)
                {
                for (int u = 0; u < t; u++)
                    {
                    Console.Write(tab3[i, u] + "  ");
                    }
                Console.WriteLine();
                }
            for (int i = 0; i < t; i++)
                {
                for (int u = 0; u < t; u++)
                    {
                    sumOfNumbers += tab3[i, u];
                    }
                }
            Console.WriteLine("Suma liczb na przekątnej wynosi {0}", sumOfNumbers);
            //Zadanie 4.7.Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10 × 10 umieszcza w pierwszej kolumnie liczby od 0 do 9, w drugiej kolumnie kwadraty tych liczb, a w pozostałych kolumnach 0(zobacz interpretację graficzną tablicy poniżej). Dodatkowo program powinien obliczać sumę liczb znajdujących się w pierwszej kolumnie oraz sumę liczb znajdujących się w drugiej kolumnie strona 70
            int[,] tab4 = new int[10, 10];
            int ilePion1 = 0; int ilePion2 = 0;
            for (int i = 0; i < t; i++)
                {
                for (int pion = 0; pion < t; pion++)
                    {
                    if (pion == 0)
                        tab4[i, pion] = i;
                    if (pion == 1)
                        tab4[i, pion] = i * i;
                    if (pion > 1)
                        tab4[i, pion] = 0;
                    }
                }


            for (int i = 0; i < t; i++)
                {
                for (int pion = 0; pion < t; pion++)
                    {
                    Console.Write(tab4[i, pion] + "  ");
                    }
                Console.WriteLine();
                }
            for (int i = 0; i < t; i++)
                {
                ilePion1 += tab4[i, 0];
                }
            for (int i = 0; i < t; i++)
                {
                ilePion2 += tab4[i, 1];
                }
            Console.WriteLine("Suma liczb w pionie 1 wynosi {0}, zaś w pionie 2 czyli kwadrat pionu 1 wynosi {1}", ilePion1, ilePion2);
            // Zadanie 4.8. Dane są dwie tablice dwuwymiarowe 10 × 10 o nazwie a i b. Tablica a zawiera elementy przedstawione poniżej. str 73
            int[,] aTab = new int[10, 10];
            int[,] bTab = new int[10, 10];
            for (int i = 0; i < t; i++)
                {
                for (int q = 0; q < t; q++)
                    {
                    aTab[i, q] = q;
                    Console.Write(aTab[i, q] + "  ");
                    }
                Console.WriteLine();
                }
            Console.WriteLine("Poniżej tabelka po zmianie ułożenia\n");
            for (int i = 0; i < t; i++)
                {
                for (int q = 0; q < t; q++)
                    {
                    bTab[i, q] = aTab[q, i];
                    Console.Write(bTab[i, q] + "  ");
                    }
                Console.WriteLine();
                }
            //Zadanie 4.9. Napisz program, który w tablicy jednowymiarowej 100-elementowej o nazwie dane umieszcza liczby od 1 do 100, a następnie je sumuje           
            int[] jeden = new int[100];
            int tablicaRazem = 0;
            for (int i = 1; i < 100; i++)
                {
                jeden[i] = i;
                tablicaRazem += i;
                }
            foreach (int item in jeden)
                {
                Console.Write(item.ToString() + "*");
                }
            Console.WriteLine("\nSuma wszystkich liczb tablicy wynosi {0}", tablicaRazem);
            // Zadanie 4.10. Napisz program, który w tablicy jednowymiarowej 100-elementowej o nazwie dane umieszcza liczby od 1 do 100, a następnie sumuje liczby parzyste i nieparzyste znajdujące się w tym przedziale.
            int[] dwa = new int[100];
            int parzyste = 0;
            int nieparzyste = 0;
            for (int i = 0; i < 100; i++)
                {
                dwa[i] = i + 1;
                if (i % 2 == 0)
                    {
                    parzyste += i;
                    }
                else
                    {
                    nieparzyste += i;
                    }
                }
            foreach (int item in dwa)
                {
                Console.Write(item.ToString() + "-");
                }
            Console.WriteLine("\nSuma liczb parzystych wynosi {0}, a nieparzystych {1}", parzyste, nieparzyste);

            // Zadanie 4.11. Korzystając z właściwości kolekcji ArrayList(), napisz program, który do kolekcji tego typu dodaje 6 liczb, a następnie je sortuje. Po wykonaniu tej operacji należy dokonać usunięcia drugiego elementu z listy, dodać nowy element do listy i dokonać ponownego sortowania.
            List<int> liczby3 = new List<int>(6);
            liczby3.Add(4);
            liczby3.Add(6);
            liczby3.Add(3);
            liczby3.Add(2);
            liczby3.Add(5);
            liczby3.Add(1);
            liczby3.Sort();
            foreach (int item in liczby3)
                {
                Console.Write(item.ToString() + " - ");
                }
            Console.WriteLine("\nPo sortowaniu");
            liczby3.Remove(1);
            liczby3.Insert(1, 12);
            liczby3.Sort();
            foreach (int item in liczby3)
                {
                Console.Write(item.ToString() + " ");
                }
            // Zadanie 4.12. Korzystając z właściwości kolekcji ArrayList(), napisz program, który do kolekcji tego typu dodaje 6 imion, a następnie je sortuje
            Console.WriteLine();
            ArrayList list = new ArrayList();
            list.Add("Piotr");
            list.Add("Zenon");
            list.Add("Adam");
            list.Add("Grażyna");
            list.Add("Barbara");
            list.Add("Danuta");
            list.Sort();
            foreach (string item in list)
                {
                Console.Write(item.ToString() + " - ");
                }
            Console.WriteLine();
            int[,] macierzA = new int[10, 10];
            int[,] macierzB = new int[10, 10];
            int[,] macierzC = new int[10, 10];
            for (int i = 0; i < t; i++)
                {
                for (int lo = 0; lo < t; lo++)
                    {
                    macierzA[i, lo] = 1;
                    Console.Write(macierzA[i,lo] + "  ");
                    }
                Console.WriteLine();
                }
            Console.WriteLine();
            for (int i = 0; i < t; i++)
                {
                for (int k2 = 0; k2 < t; k2++)
                    {
                    macierzB[i, k2] = 2;
                    Console.Write(macierzB[i,k2]+ "  ");
                    }
                Console.WriteLine();
                }
            Console.WriteLine();
            for (int i = 0; i < t; i++)
                {
                for (int c3 = 0; c3 < t; c3++)
                    {
                    macierzC[i, c3] = macierzA[i, c3] + macierzB[i, c3];
                    Console.Write(macierzC[i,c3] + "  ");
                    }
                Console.WriteLine();
                }           
            Console.ReadKey();
            }
        }
    }



