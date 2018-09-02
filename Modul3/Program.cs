using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

            Console.ReadLine();
        }

        private static void Task5()
        {
            int[,] twoDemenArr = new int[5, 5];
            int sumB = 0, max = twoDemenArr[0, 0], min = twoDemenArr[0, 0];
            int ni = 0, mj = 0, ki = 0, lj = 0;
            bool count = false;
            Random rand = new Random();

            Console.WriteLine("Двумерный массив");

            for (int i = 0; i < twoDemenArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDemenArr.GetLength(1); j++)
                {
                    twoDemenArr[i, j] = rand.Next(-100, 100);
                    if (max < twoDemenArr[i, j])
                    {
                        max = twoDemenArr[i, j];
                        ni = i;
                        mj = j;
                    }
                    if (min > twoDemenArr[i, j])
                    {
                        min = twoDemenArr[i, j];
                        ki = i;
                        lj = j;
                    }
                    Console.Write($"{twoDemenArr[i, j]}\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < twoDemenArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDemenArr.GetLength(1); j++)
                {
                    if ((i == ni && j == mj) || (i == ki && j == lj))
                    {
                        if (count)
                        {
                            count = false;
                            continue;
                        }
                        else
                        {
                            count = true;
                            continue;
                        }
                    }
                    if (count)
                    {
                        sumB += twoDemenArr[i, j];
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Максимальный элемент массива  = " + max);
            Console.WriteLine("Минимальный элемент массива  = " + min);

            Console.WriteLine($"Максимальный элемент {twoDemenArr.Cast<int>().Max()} находится в массиве строка {ni + 1} столбец {mj + 1} позиции");
            Console.WriteLine($"Минимальный элемент {twoDemenArr.Cast<int>().Min()} находится в массиве строка {ki + 1} столбец {lj + 1} позиции");

            Console.WriteLine("Cуммa элементов массива, расположенных между минимальным и максимальным элементами = " + sumB);
        }

        private static void Task4()
        {
            Console.WriteLine("Введите предложение для подсчета слов");
            string sentence = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(sentence);

            string[] sentenceArr = sentence.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Количество слов в предложении = " + sentenceArr.Length);
        }

        private static void Task3()
        {
            Console.WriteLine("Введите строку для проверки:");
            string str = Console.ReadLine();

            char[] temp = new char[str.Length];
            int j = 0, countNull = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    countNull++;
                    continue;
                }
                temp[j] = str[i];
                j++;
            }

            Array.Resize(ref temp, str.Length - countNull);
            string output = new string(temp);

            Console.Clear();
            Console.WriteLine(str);

            str = output;
            output = new string(output.ToCharArray().Reverse().ToArray());

            if (string.Compare(str, output, true) == 0)
            {
                Console.WriteLine("Строка ЯВЛЯЕТСЯ палиндромом");
            }
            else
            {
                Console.WriteLine("Строка НЕ ЯВЛЯЕТСЯ палиндромом");
            }
        }

        private static void Task2()
        {
            Console.WriteLine("Введите размеры массивов:");
            Console.WriteLine("Массив М:");
            var valueM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Массив N:");
            var valueN = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int count = 0;

            int[] A = new int[valueM];
            int[] B = new int[valueN];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(15);
            }    
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = rand.Next(15);
                for (int j = 0; j < A.Length; j++)
                {
                    if (B[i] == A[j])
                    {
                        count++;
                    }
                }
            }

            PrintArr("Массив A", A);
            PrintArr("Массив B", B);

            if (count != 0)
            {
                int[] AB = new int[count];
                int z = 0;
                for (int i = 0; i < B.Length; i++)
                {
                    for (int j = 0; j < A.Length; j++)
                    {
                        if ((B[i] == A[j]) && (!AB.Contains(B[i])))
                        {
                            AB[z] = B[i];
                            z++;
                        }
                    }
                }

                Array.Resize(ref AB, z);
                PrintArr("Массив общий", AB);
            }
            else
            {
                Console.WriteLine("Общих элементов в массивах нет");
            }

            Console.ReadLine();
        }

        static void PrintArr(string text, int[] arr)
        {
            Console.WriteLine(text + ": ");
            for (int A = 0; A < arr.Length; A++)
            {
                Console.Write(arr[A] + "\t");
            }
        }

        private static void Task1()
        {
            int[] oneDimensArray = new int[5];
           
            Console.WriteLine("Введите 5 элемента массива: ");
            for (int i = 0; i < oneDimensArray.Length; i++)
            {
                oneDimensArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        
            int sum = 0; int composition = 1;
            Console.WriteLine("\nМассив из 5 элементов: ");
            for (int i = 0; i < oneDimensArray.Length; i++)
            {
                Console.Write(oneDimensArray[i] + " ");
                sum = sum + oneDimensArray[i];
                composition = composition * oneDimensArray[i];
            }

            Array.Sort(oneDimensArray);

            int min = oneDimensArray[0];
            int max = oneDimensArray[oneDimensArray.Length - 1];


            Console.WriteLine("\nМаксимальный элемент: " + max);
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Сумма массива: " + sum);
            Console.Write("Произведение массива: " + composition);
          
            double[,] twoDimensArray = new double[3, 4];
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    twoDimensArray[i, j] = rand.Next(0, 100) / 10.0;
                }

            Console.WriteLine("\n\nМассив 3х4: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(twoDimensArray[i, j] + "    ");
                }
                Console.WriteLine();
            }

            double min2 = twoDimensArray[0, 0];
            double max2 = twoDimensArray[0, 0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (twoDimensArray[i, j] < min2)
                    {
                        min2 = twoDimensArray[i, j];
                    }
                    if (twoDimensArray[i, j] > max2)
                    {
                        max2 = twoDimensArray[i, j];
                    }

                }
            }
            Console.Write("\nМинимальный элемент: " + min2);
            Console.Write("\nМаксимальный элемент: " + max2);
        }
    }
}
