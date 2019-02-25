using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Какое задание? (Для выхода нажмите 0)");
                int nz = Int32.Parse(Console.ReadLine());
                if (nz == 0)
                    break;
                switch (nz)
                {
                    case 1:
                        {
                            /*1.Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
                             * Программа должна сосчитать количество введенных пользователем пробелов. */
                            string str = "";
                            int i = 0;
                            Console.WriteLine("Введите строку ");
                            do
                            {
                                str += Console.ReadLine();// str=str+cr()
                                i++;

                            } while (!str.Contains('.'));

                            //int countSpace = str.Count(w => w == ' '); ne sovsem poniala kak eto rabotaet

                            int b = 0;
                            for (int k = 0; k < str.Length; k++)
                            {
                                if (str[k] == ' ')
                                    b++;
                            }
                            Console.WriteLine("Кол-во строк: " + i);
                            Console.WriteLine("Кол-во пробелов: " + b);
                            break;
                        }
                    case 2:
                        {
                            /*2.	Ввести с клавиатуры номер трамвайного билета и проверить является ли 
                             * данный билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр
                             * равна сумме последних трёх, то этот билет считается счастливым). */
                            string chislo = Console.ReadLine();
                            Console.WriteLine("Введите номер билета(6-значное число)");
                            if (chislo.Length == 6)
                            {
                                int A = chislo[0] + chislo[1] + chislo[2];
                                int B = chislo[3] + chislo[4] + chislo[5];
                                if (A == B)
                                    Console.WriteLine("билет счастливый");
                                else
                                    Console.WriteLine("билет не счастливый ");
                            }
                            else
                                Console.WriteLine("Длина билета не правильная");
                            break;
                        }
                    case 3:
                        {
                            /*4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению.*/
                            Console.WriteLine("Введите целые положительные числа A и B (A < B)");
                            int A = Int32.Parse(Console.ReadLine());
                            int B = Int32.Parse(Console.ReadLine());
                            for (int i = A; i <= B; i++)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    Console.Write(i);
                                }
                                Console.WriteLine(" ");

                            }
                            break;
                        }
                    case 4:
                        {
                            /*5.Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено число 345, то программа должна вывести число 543.*/
                            Console.WriteLine("Введите число: ");
                            string A = Console.ReadLine();

                            for (int i = A.Length - 1; i >= 0; i--)
                            {
                                Console.Write(A[i]);
                            }
                            break;

                        }
                    case 5:
                        {
                            /*6.Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.*/
                            Random rnd = new Random();
                            string str = rnd.Next(1, 30) + "  " + rnd.Next(1, 50) + "  " + rnd.Next(10, 50);
                            Console.WriteLine(str);
                            break;
                        }
                    case 6:
                        {
                            /*10.	Дано двузначное число. Найти:
                                a.	число десятков в нем;
                                b.	число единиц в нем;
                                c.	сумму его цифр;
                                d.	произведение его цифр*/
                            Console.WriteLine("Введите двузначное число");
                            string A = Console.ReadLine();
                            Console.WriteLine("число десятков - " + A[0]);
                            Console.WriteLine("число единиц - " + A[1]);
                            int a = Int32.Parse(A);
                            int b = (a / 10) + (a % 10);
                            int c = (a / 10) * (a % 10);
                            Console.WriteLine("сумму его цифр = " + b);
                            Console.WriteLine("произведение его цифр = " + c);
                            break;
                        }
                    case 7:
                        {
                            /*Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, ..., 7) выводит на экран его название (понедельник, вторник, ..., воскресенье).*/

                            int d = Int32.Parse(Console.ReadLine());
                            DayOfWeek D = (DayOfWeek)d;
                            Console.WriteLine(D);
                            break;
                        }
                    case 8:
                        {
                            /*35.Составить программу, которая в зависимости от порядкового номера дня месяца (1, 2, ..., 12) выводит на экран его название (январь, февраль, ..., декабрь).*/
                            int d = Int32.Parse(Console.ReadLine());
                            if (d == 1)
                                Console.WriteLine("Январь");
                            else if (d == 2)
                                Console.WriteLine("Феваль");
                            else if (d == 3)
                                Console.WriteLine("Март");
                            else if (d == 4)
                                Console.WriteLine("Апрель");
                            else if (d == 5)
                                Console.WriteLine("Май");
                            else if (d == 6)
                                Console.WriteLine("Июнь");
                            else if (d == 7)
                                Console.WriteLine("Июль");
                            else if (d == 8)
                                Console.WriteLine("Август");
                            else if (d == 9)
                                Console.WriteLine("Сентябрь");
                            else if (d == 10)
                                Console.WriteLine("Октябрь");
                            else if (d == 11)
                                Console.WriteLine("Ноябрь");
                            else if (d == 12)
                                Console.WriteLine("Декабрь");

                            break;
                        }
                    case 9:
                        {
                            /*36.	Составить программу, которая в зависимости от порядкового номера дня месяца (1, 2, ..., 12) выводит на экран время года, к которому относится этот месяц.*/
                            int d = Int32.Parse(Console.ReadLine());
                            switch (d)
                            {
                                case 1:
                                case 2:
                                case 12:
                                    {
                                        Console.WriteLine("Winter");
                                        break;
                                    }
                                case 3:
                                case 4:
                                case 5:
                                    {
                                        Console.WriteLine("Spring");
                                        break;
                                    }
                                case 6:
                                case 7:
                                case 8:
                                    {
                                        Console.WriteLine("Summer");
                                        break;
                                    }
                                case 9:
                                case 10:
                                case 11:
                                    {
                                        Console.WriteLine("Autumn");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 10:
                        {
                            /*38.	Дата некоторого дня характеризуется тремя натуральными числами: g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m определить: 
                            a.	дату предыдущего дня;
                            b.	дату следующего дня.
                            */
                            Console.WriteLine("введите дату: ");
                            int n = Int32.Parse(Console.ReadLine());
                            int m = Int32.Parse(Console.ReadLine());
                            int g = Int32.Parse(Console.ReadLine());
                            DateTime date = new DateTime(g, m, n);
                            Console.WriteLine(date);
                            Console.WriteLine(date.AddDays(-1));
                            Console.WriteLine(date.AddDays(1));
                            break;
                        }
                    case 11:
                        {
                            /*3.Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует Домашнее задание №1 Домашнее задание № все символы нижнего регистра в символы верхнего регистра и наоборот. */
                            string s = "Домашнее задание №1";
                            Console.WriteLine(s.ToUpper());

                            break;
                        }
                    case 12:
                        {
                            /*42.	Напечатать таблицу умножения на 9: 9 х 1 = 9 9 х 2 = 18 ... 9 х 9 = 81*/
                            int a;
                            for (int i = 1; i <= 9; i++)
                            {
                                a = 9 * i;
                                Console.WriteLine("9 * {0} = {1}", i, a);

                            }
                            break;
                        }

                }


            }
        }
    }
}
