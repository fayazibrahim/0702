using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Notebook
    {


        public Notebook(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public string Brand;
        public string Model;
        public int Price;



        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Price: {Price}");

        }

    }
}
