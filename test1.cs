using System;

namespace ConsoleApp1
{
    class Vector1
    {
        public Vector1(int n, bool flag = false)
        {
            input(n, flag);
        }
        private Random rnd = new Random();

        private int[] a;

        private bool flag = false;

        public void input(int n, bool flag = false)
        {
            this.a = new int[n];
            if (flag)
            {
                for (int i = 0; i < a.Length; ++i)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                for (int i = 0; i < a.Length; ++i)
                {
                    a[i] = rnd.Next(1, 100);
                }
            }
        }
        public void print()
        {
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write($"{a[i]} ");
            }
            Console.Write("\n");
        }
        public void average()
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum / a.Length);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите кол-во элементов массива");
            Vector1 vector1 = new Vector1(0, false);
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы массива (по одному в строке)");
            vector1.input(n, true);
            vector1.print();
            vector1.average();
        }
    }
}