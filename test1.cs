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
        private void input_user()
        {
            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        private void input_random() 
        {
            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = rnd.Next(1, 100);
            }
        }
        public void input(int n, bool flag = false)
        {
            this.a = new int[n];
            if (flag)
            {
                input_user();
            }
            else
            {
                input_random();
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
        public void check_100(){
            for (int i = 0; i < a.Length; ++i){
                if (Math.Abs(a[i]) < 100){
                    Console.Write($"{a[i]} ");
                }
            }
            Console.WriteLine();
        }
        public void pop_repeated(){
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length){
                
            }
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
            vector1.check_100();
        }
    }
}
