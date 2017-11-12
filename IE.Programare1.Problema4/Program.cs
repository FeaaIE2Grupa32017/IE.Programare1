using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            float[] valori = new float[n];
            for(int i = 0; i < valori.Length; i++)
            {
                Console.WriteLine("Introduceti valoarea de la pozitia: " + i);
                valori[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(",", valori));
            for(int i = 0; i < valori.Length - 1; i += 2)
            {
                float suma = valori[i] + valori[i + 1];
                Array.Resize(ref valori, valori.Length + 1);
                int j = valori.Length;
                while(j > i + 1)
                {
                    j--;
                    valori[j] = valori[j - 1];
                }
                valori[i + 1] = suma;
            }
            Console.WriteLine(string.Join(",", valori));


            Console.ReadKey();
        }
    }
}
