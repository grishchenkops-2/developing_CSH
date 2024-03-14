namespace ConsoleApp1
{
    class Vector1 : VectorBase
    {
        public Vector1(int n, bool flag = false)
        {
            input(flag);
        }
        private Random rnd = new Random();

        private int[] a;

        private bool flag = false;
        protected override void input_user()
        {
            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        protected override void input_random() 
        {
            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = rnd.Next(1, 100);
            }
        }

        public override void input(bool flag = false)
        {
            Console.WriteLine("Введите кол-во элементов массива");
            int n = int.Parse(Console.ReadLine());
            this.a = new int[n];
            base.input(flag);
        }

        public override void print()
        {
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write($"{a[i]} ");
            }
            Console.Write("\n");
        }

        public override void average()
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum / a.Length);
        }

        public void check_100()
        {
            for (int i = 0; i < a.Length; ++i)
            {
                if (Math.Abs(a[i]) < 100)
                {
                    Console.Write($"{a[i]} ");
                }
            }
            Console.WriteLine();
        }

        public void pop_repeated()
        {
            Console.Write($"{a[0]} ");
            for (int i = 1; i < a.Length; ++i)
            {
                int cnt = 0;
                for (int j = i - 1; j > -1; --j)
                {
                    if (a[j] == a[i])
                    {
                        cnt++;
                    }
                }
                if (cnt == 0)
                {
                    Console.Write($"{a[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}