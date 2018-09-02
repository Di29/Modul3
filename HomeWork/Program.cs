using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Task5();
            Task4();
            Task3();
            Task2();
            Task1();

            Console.ReadLine();
        }

        private static void Task1()
        {
            int symbolsValue = 0;
            ConsoleKeyInfo symbol;

            do
            {
                Console.WriteLine("Введите символ");
                Console.WriteLine("Для окончания ввода нажмите точку ");
                symbol = Console.ReadKey();

                Console.WriteLine();
                Console.Clear();
                Console.WriteLine(symbol.Key);

                if (symbol.KeyChar == ' ')
                {
                    Console.WriteLine("Пробел");
                    symbolsValue++;
                }

                if (symbol.KeyChar == '.')
                {
                    break;
                }
            } while (true);

            Console.WriteLine("Количество введенных пробелов = " + symbolsValue);
        }

        private static void Task2()
        {
            Console.WriteLine("Введите 6 значный билет");
            string ticketNum = Console.ReadLine();

            if (ticketNum.Length < 0 && ticketNum.Length > 6)
            {
                throw new IndexOutOfRangeException();
            }

            int ticket = Convert.ToInt32(ticketNum);
            Console.WriteLine((Convert.ToInt32(Convert.ToString(ticketNum)[0].ToString()) +
                               Convert.ToInt32(Convert.ToString(ticketNum)[1].ToString()) +
                               Convert.ToInt32(Convert.ToString(ticketNum)[2].ToString())) ==
                              (Convert.ToInt32(Convert.ToString(ticketNum)[3].ToString()) +
                               Convert.ToInt32(Convert.ToString(ticketNum)[4].ToString()) +
                               Convert.ToInt32(Convert.ToString(ticketNum)[5].ToString()))
                ? "Билет счастливый"
                : "Билет не является счастливым");
        }

        private static void Task3()
        {
            ConsoleKeyInfo symbol;
            do
            {
                Console.WriteLine("Введите символ для конвертации регистра");
                Console.WriteLine("Для окончания ввода нажмите ESC ");

                symbol = Console.ReadKey();

                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Введенный символ " + symbol.KeyChar);

                if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
                {
                    if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
                    {
                        Console.WriteLine("Конвертируемый символ " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
                    }
                    else
                    {
                        Console.WriteLine("Конвертируемый символ " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
                    }
                }

                if (Convert.ToInt32(symbol.KeyChar) == 27)
                {
                    break;
                }

            } while (true);
        }

        private static void Task4()
        {
            Console.WriteLine("Необходимо ввести А и В, (А<B)");

            try
            {
                Console.WriteLine("Введите А");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите B");
                int B = Convert.ToInt32(Console.ReadLine());

                if (A >= B || A <= 0 || B <= 0)
                {
                    Console.WriteLine("Не соблюдено условие А<B либо числа A и B не положительные ");
                    return;
                }

                Console.Clear();

                for (int i = A; i <= B; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }
        }

        private static void Task5()
        {
            try
            {
                Console.WriteLine("Введите число для конвертации(N>0):");
                string numberN = Console.ReadLine();

                if (Convert.ToInt32(numberN) < 0)
                {
                    Console.WriteLine("Не соблюдено условие N>0");
                    return;
                }

                Console.WriteLine("Полученное число");
                for (int i = numberN.Length - 1; i >= 0; i--)
                {
                    Console.Write(numberN[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }
            Console.WriteLine();
        }
    }
}
