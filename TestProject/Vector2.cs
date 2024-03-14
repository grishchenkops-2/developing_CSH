using System;
namespace ConsoleApp1
{
    class Vector2 : VectorBase
    {
        public Vector2(int n, int m, bool flag = false)
        {
            input(flag);
        }
        private Random rnd = new Random();

        private int[,] a;

        private bool flag = false;

        protected override void input_user()
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        protected override void input_random()
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    a[i,j] = rnd.Next(-200, 200);
                }
            }
        }
        public override void input(bool flag = false)
        {
            Console.WriteLine("Введите кол-во элементов массива");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            this.a = new int[n, m];
            base.input(flag);
        }
        public override void print()
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                if (i % 2 == 1)
                {
                    for (int j = a.GetLength(1) - 1; j > -1; --j)
                    {
                        Console.Write($"{a[i,j]} ");
                    }
                }
                else
                {
                    for (int j = 0; j < a.GetLength(1); ++j)
                    {
                        Console.Write($"{a[i,j]} ");
                    }
                }
                Console.WriteLine();
                
            }
        }
        public override void average()
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i,j];
                }
                
            }
            Console.WriteLine(sum / a.Length);
        }

    }
    
}