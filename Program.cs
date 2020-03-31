using System;
using System.Collections.Generic;
using System.Linq;

namespace RevisaSumaEnColeccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 7;
            bool flag = false;
            flag = VerificaSuma(suma);
            Console.WriteLine("La suma existe en el arreglo ? " +  flag);
        }

        static bool VerificaSuma(int suma)
        {
            int[] arrNumeros = { 1, 4, 5, 2 };
            HashSet<int> hSet = new HashSet<int>();
            foreach (var n in arrNumeros)
            {
                if (hSet.Contains(n))
                    return true;
                hSet.Add(suma - n);
            }
            return false;
        }
    }

}
