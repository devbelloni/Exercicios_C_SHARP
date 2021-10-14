using System;
using System.Globalization;

namespace exercicioproposto5 {
    class Program {
        static void Main(string[] args) {
            string[] p1 = Console.ReadLine().Split(' ');
            string[] p2 = Console.ReadLine().Split(' ');
            string q1 = p1[1];
            string v1 = p1[2];
            string q2 = p2[1];
            string v2 = p2[2];
            int quant1 = int.Parse(q1);
            double valor1 = double.Parse(v1, CultureInfo.InvariantCulture);
            int quant2 = int.Parse(q2);
            double valor2 = double.Parse(v2, CultureInfo.InvariantCulture);
            double total = quant1 * valor1 + quant2 * valor2;
            Console.WriteLine($"VALOR A PAGAR: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
