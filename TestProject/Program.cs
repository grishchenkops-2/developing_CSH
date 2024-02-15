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
        public int[] delete100(){
            int cnt = 0;
            for (int i = 0; i < a.Length; ++i){
                if (Math.Abs(a[i]) > 100){
                    cnt++;
                }
            }
            int [] b = new int[cnt];
            int i = 0;
            int j = 0;
            while (i < a.Length){
                if (Math.Abs(a[i]) < 100){
                    b[j] = a[i]
                }
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
        }
    }
}
