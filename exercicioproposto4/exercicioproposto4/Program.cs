using System;
using System.Globalization;

namespace exercicioproposto4 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = sal * n1;
            Console.WriteLine($"NUMBER = {n}");
            Console.WriteLine($"SALARY = U$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
