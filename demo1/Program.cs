using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> array= new List<int>();
            for (int i=0; i<n; i++)
            {
                Console.Write("Nhap phan tu {0}: ",i);
                array.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.Write("\nCac phan tu trong mang la: ");
            foreach (var s in array) { 
                Console.Write(" "+s);
            }
            Console.Write("\nSNT co trong mang la: ");
            foreach (var s in array) {
                int dem = 0;
                if (s < 2)
                    dem = 0;
                else
                    for (int i = 1; i < Math.Sqrt(s); i++)
                        if (s % i == 0)
                            dem++;
                if (dem == 1)
                    Console.Write(" "+s);
            }
            Console.WriteLine("\nPhan tu Min: "+array.Min(i => i));

            Console.ReadKey();
        }
    }
}
