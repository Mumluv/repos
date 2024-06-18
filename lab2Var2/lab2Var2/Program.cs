using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika2var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test1();
            // Test2();
            // Test3();
            // Test4();
            // Test5();
            // Test6();
            // Test7();
            // Test9();
            // Test10();
            // Test11();
            // Test12();
            // Test13();
            // Test14();

        }

        static void Test1()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void Test2()
        {
            string s = Console.ReadLine();
            int i = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (count < i)
            {
                Console.WriteLine(s);
                count++;
            }
        }

        static void Test3()
        {
            int i = 0;
            while (i < 10)
            {
                int j = 0;
                while (j < 10)
                {
                    Console.Write("S");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }

        static void Test4()
        {
            int i = 1;

            while (i <= 10)
            {
                int j = 1;

                while (j <= 10)
                {
                    int result = i * j;
                    Console.Write(result + " ");
                    j++;
                }

                Console.WriteLine();
                i++;
            }

            Console.ReadLine();
        }

        static void Test5()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        static void Test6()
        {
            Console.Write("Введите число m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("8");
                }
                Console.WriteLine();
            }
        }

        static void Test7()
        {
            int count = 10;

            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("8");
                }
                Console.WriteLine();
            }
        }

        static void Test9()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Я никогда не буду работать за копейки.");
            }
        }

        static void Test10()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Любое число");
            }
            else if (num1 >= num2 && num1 <= num3 || num1 <= num2 && num1 >= num3)
            {
                Console.WriteLine("Среднее число: " + num1);
            }
            else if (num2 >= num1 && num2 <= num3 || num2 <= num1 && num2 >= num3)
            {
                Console.WriteLine("Среднее число: " + num2);
            }
            else
            {
                Console.WriteLine("Среднее число: " + num3);
            }
        }
        static void Test11()
        {
            string name = Console.ReadLine();
            int y = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Меня зовут " + name + ".");
            Console.WriteLine("Я родился " + y + "." + m + "." + d);
        }
        static void Test12()
        {
            string[] array = new string[10];
            Console.WriteLine("Введите 8 строк:");
            for (int i = 0; i < 8; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("В обратном порядке:");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Test13()
        {
            int[] array = new int[10];
            Console.WriteLine("Введите 10 чисел");
            for (int i = 0; i < 10; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

        }
        static void Test14()
        {
            int[] Array1 = new int[20];

            Console.WriteLine("Введите значения для массива:");

            for (int i = 0; i < Array1.Length; i++)
            {
                Array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] Array101 = new int[10];
            int[] Array102 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Array101[i] = Array1[i];
                Array102[i] = Array1[i + 10];
            }

            Console.WriteLine("Второй маленький массив:");

            foreach (int num in Array102)
            {
                Console.WriteLine(num);
            }
        }


    }
}
