using System;
using main.Models;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();
            pen.HasColor("Red").HasBrand("Bic").IsNew();
            Console.WriteLine("Pen has color: " + pen.Color + " and brand: " + pen.Brand);
            Func<int, int, int> sum = (x, y) => x+y;
            Console.WriteLine("A Soma deu: " + sum(2,3));
        }
    }
}
