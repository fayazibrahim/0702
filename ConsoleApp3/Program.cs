using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            
            
            
            Notebook m1 = new Notebook("Lenovo", "Legion 5");
            m1.Price = 2499;
            m1.ShowInfo();

            Notebook m2 = new Notebook("Hp", "Victus");
            m2.Price = 2300;
            m2.ShowInfo();

            Notebook m3 = new Notebook("Acer", "Nitro");
            m3.Price = 2999;
            m3.ShowInfo();


            Notebook[] m = new Notebook[] {m1, m2, m3 };

            int sum = 0;
            int count = 0;

            for (int i = 0; i < m.Length; i++)
            {
                sum += m[i].Price;
                count++;
            }

            Console.WriteLine($"\nOrtalama = {sum/count}");




        }
    }
}
