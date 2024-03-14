using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            VectorBase[] vectors = new VectorBase[1];
            vectors[0] = new Vector1(0, false);
            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[0].print();
                vectors[0].average();
                
                vectors[0].input();
                vectors[0].print();
                vectors[0].average();
                // vectors[0].check_100();
                // vectors[0].pop_repeated();
            }
        }
    }
}
