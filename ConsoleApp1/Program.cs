using System.Collections.Generic;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
        #region 8.2 Wyszukiwanie w tablicy
            #region Zadanie 8.2.1
        static void zadanie_8_2_1()
        {
            int howManyNumbers = 5;
            Console.WriteLine("Podaj 5 liczb.");
            int[] tab = new int[howManyNumbers];
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            int maxNumber = tab[0];
            foreach(int number in tab)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine($"Największa z posród podanych liczb to {maxNumber}");
        }
        #endregion
            #region Zadanie 8.2.2
        static void zadanie_8_2_2()
        {
            int howManyNumbers = 5;
            Console.WriteLine("Podaj 5 liczb.");
            int[] tab = new int[howManyNumbers];
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            int minNumber = tab[0];
            foreach(int number in tab)
            {
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine($"Najmniejsza z posród podanych liczb to {minNumber}");
        }
        #endregion
            #region Zadanie 8.2.3
        static void zadanie_8_2_3()
        {
            int howManyNumbers = 5;
            Console.WriteLine("Podaj 5 liczb.");
            int[] tab = new int[howManyNumbers];
            int count = 0;
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            int maxNumber = tab[0];
            foreach (int number in tab)
            {
                if (number == maxNumber)
                {
                    count++;
                }
                if (number > maxNumber)
                {
                    maxNumber = number;
                    count = 1;
                }
            }
            Console.WriteLine($"Największa sposród podanych liczb to {maxNumber}, wystąpiła {count} razy.");
        }
        #endregion
            #region Zadanie 8.2.4
        static void zadanie_8_2_4()
        {
            int howManyNumbers = 10;
            Console.WriteLine("Podaj 10 liczb");
            int[] tab = new int[howManyNumbers];
            int count = 0;
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            int minNumber = tab[0];
            foreach(int number in tab)
            {
                if (number == minNumber)
                {
                    count++;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                    count = 1;
                }
            }
            Console.WriteLine($"Najmniejsza sposród podanych liczb to {minNumber}, wystąpiła {count} razy.");
        }
        #endregion
            #region Zadanie 8.2.5
        static void zadanie_8_2_5()
        {
            int howManyNumbers = 4;
            Console.WriteLine("Podaj 4 liczby.");
            int[] tab = new int[howManyNumbers];
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            int maxNumber = tab[0];
            int secondMaxNumber = tab[1];
            foreach(int number in tab)
            {
                if (number > secondMaxNumber)
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                    else if (number > secondMaxNumber && number < maxNumber)
                    {
                        secondMaxNumber = number;
                    }
            }
            Console.WriteLine($"Druga największa liczba to {secondMaxNumber}");
        }
        #endregion
            #region Zadanie 8.2.6
        static void zadanie_8_2_6()
        {
            int howManyNumbers = 4;
            Console.WriteLine("Podaj 4 liczby");
            int[] tab = new int[howManyNumbers];
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            int minNumber = tab[0];
            int secondMinNumber = tab[1];
            foreach(int number in tab)
            {
                if (number < secondMinNumber)
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                    else if (number < secondMinNumber && number > minNumber)
                    {
                        secondMinNumber = number;
                    }
            }
            Console.WriteLine($"Druga najmniejsza liczba to {secondMinNumber}");
        }
        #endregion
            #region Zadanie 8.2.7
        static void zadanie_8_2_7()
        {
            int howManyNumbers = 8;
            Console.WriteLine("Podaj 8 liczb.");
            int maxNumber = 0;
            int secondMaxNumber = 0;
            int count = 0;
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                
                if (number == secondMaxNumber)
                {
                    count++;
                }
                if (number > secondMaxNumber)
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                    else if (number > secondMaxNumber && number < maxNumber)
                    {
                        secondMaxNumber = number;
                        count = 1;
                    }
                
            }

            Console.WriteLine($"Druga największa liczba to {secondMaxNumber}, wystąpiła {count} razy");
        }
        #endregion
            #region Zadanie 8.2.8
        static void zadanie_8_2_8()
        {
            int howManyNumbers = 8;
            int minNumber = int.MaxValue;
            int secondMinNumber = int.MaxValue;
            int count = 0;
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                
                if (number == secondMinNumber)
                {
                    count++;
                }
                if (number < secondMinNumber)
                    if(number < minNumber)
                    {
                        minNumber = number;
                    }
                    else if (number < secondMinNumber && number > minNumber)
                    {
                        secondMinNumber = number;
                        count = 1;
                    }
            }
            Console.WriteLine($"Druga najmniejsza liczba to {secondMinNumber}, wystąpiła {count} razy");
        }
        #endregion
        #endregion
        #region 8.3 Przetwarzanie elementów tablicy
            #region Zadanie 8.3.1
        static void zadanie_8_3_1()
        {
            int howManyNumbers = 5;
            Console.WriteLine("Podaj 5 liczb.");
            int[] tab = new int[howManyNumbers];
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            foreach(int number in tab)
            {
                int newNumber = number * number;
                Console.WriteLine($"Liczba {number} podniesiona do potęgi 2 wynosi {newNumber} \n");
            }
        }
        #endregion
            #region Zadanie 8.3.2
        static void zadanie_8_3_2()
        {
            int howManyNumbers = 5;
            Console.WriteLine("Podaj 5 liczb");
            double[] tab = new double[howManyNumbers];
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                double number = double.Parse(Console.ReadLine());
                tab[i] = number;
            }
            foreach(double number in tab)
            {
                double newNumber = Math.Pow(number, 3);
                Console.WriteLine($"Liczba {number} podniesiona do potęgi 2 wynosi {newNumber} \n");
            }
        }
        #endregion
            #region Zadanie 8.3.3
        static void zadanie_8_3_3()
        {
            int howManyNumbers = 5;
            Console.WriteLine("Podaj 5 liczb");
            int[] tab = new int[howManyNumbers];
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            foreach(int number in tab)
            {
                int newNumber = number + 1;
                Console.WriteLine($"{number} + 1 = {newNumber} \n");
            }
        }
        #endregion
            #region Zadanie 8.3.4
        static void zadanie_8_3_4()
        {
            int howManyNumbers = 5;
            Console.WriteLine("Podaj 5 liczb.");
            int[] tab = new int[howManyNumbers];
            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            foreach(int number in tab)
            {
                int newNumber = number * 2;
                Console.WriteLine($"{number} * 2 = {newNumber} \n");
            }
        }
        #endregion
        #endregion
        #region 8.4 Przetwarzanie elementów tablicy o zadanych wartościach
            #region Zadanie 8.4.1
        static void zadanie_8_4_1()
        {
            static int[] sortTable(int[] table)
            {
                bool change;
                do
                {
                    change = false;
                    for (int i = 0; i < table.Length - 1; i++)
                    {
                        int ele1 = table[i];
                        int ele2 = table[i + 1];
                        if (ele2 < ele1)
                        {
                            table[i] = ele2;
                            table[i + 1] = ele1;
                            change = true;
                        }
                    }
                } while (change);

                return table;
            }

            int howManyNumbers = 10;
            int[] tab = new int[howManyNumbers];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            
            foreach (int i in sortTable(tab))
            {
                if (i % 2 == 0)
                Console.WriteLine(i);
            }
        }
        #endregion
            #region Zadanie 8.4.2
        static void zadanie_8_4_2()
        {
            static int[] sortTable(int[] table)
            {
                bool change;
                do
                {
                    change = false;
                    for (int i = 0; i < table.Length - 1; i++)
                    {
                        int ele1 = table[i];
                        int ele2 = table[i + 1];
                        if (ele2 < ele1)
                        {
                            table[i] = ele2;
                            table[i + 1] = ele1;
                            change = true;
                        }
                    }
                } while (change);
                return table;
            }

            int howManyNumbers = 10;
            int[] tab = new int[howManyNumbers];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            foreach (int i in sortTable(tab))
            {
                if (i % 2 == 1)
                 Console.WriteLine(i);
            }
        }
        #endregion
            #region Zadanie 8.4.3
        static void zadanie_8_4_3()
        {
            static long[] sortTable(long[] table)
            {
                bool change;
                do
                {
                    change = false;
                    for (int i = 0; i < table.Length - 1; i++)
                    {
                        long ele1 = table[i];
                        long ele2 = table[i + 1];
                        if (ele2 < ele1)
                        {
                            table[i] = ele2;
                            table[i + 1] = ele1;
                            change = true;
                        }
                    }
                } while (change);
                return table;
            }

            int howManyNumbers = 5;
            long[] tab = new long[howManyNumbers];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                long number = long.Parse(Console.ReadLine());
                tab[i] = number;
            }
            foreach (long i in sortTable(tab))
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        #endregion
            #region Zadanie 8.4.4
        static void zadanie_8_4_4()
        {
            static int[] sortTable(int[] table)
            {
                bool change;
                do
                {
                    change = false;
                    for (int i = 0; i < table.Length - 1; i++)
                    {
                        int ele1 = table[i];
                        int ele2 = table[i + 1];
                        if (ele2 < ele1)
                        {
                            table[i] = ele2;
                            table[i + 1] = ele1;
                            change = true;
                        }
                    } 
                } while (change);
                return table;
            }
            int howManyNumbers = 5;
            int[] tab = new int[howManyNumbers];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"Podaj liczbę nr. {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                tab[i] = number;
            }
            foreach (int i in sortTable(tab))
            {
                if (i >= 4 && i < 15)
                {
                    Console.WriteLine(i);
                }
            }
        }
        #endregion
        #endregion
        static void Main(string[] args)
        {
            zadanie_8_4_4();
        }
    }
}