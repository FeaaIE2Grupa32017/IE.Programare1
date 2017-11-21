using IE.Programare1.Functii;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.CursDeSchimb2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int lunaCurenta = DateTime.Now.Month;
            //in release folositi linia de mai sus
            int lunaCurenta = 3;

            decimal[,] cursuriDeSchimb = new decimal[2, lunaCurenta - 1];
            for (int i = 0; i < cursuriDeSchimb.GetLength(0); i++)
            {
                for (int j = 0; j < cursuriDeSchimb.GetLength(1); j++)
                {
                    string ceCurs = i == 0 ? "EUR" : "USD";
                    Console.WriteLine("Introduceti cursul " + ceCurs + " pentru luna " + Functie.ObtineNumeLuna((byte)j));
                    cursuriDeSchimb[i, j] = Convert.ToDecimal(Console.ReadLine());
                }
            }

            Functie.ScrieMatriceLaConsola(cursuriDeSchimb);

            string[] luniCursuriEgale = new string[0];

            for (int i = 0; i < cursuriDeSchimb.GetLength(1); i++)
            {
                if (cursuriDeSchimb[0, i] == cursuriDeSchimb[1, i])
                {
                    Array.Resize(ref luniCursuriEgale, luniCursuriEgale.Length + 1);
                    luniCursuriEgale[luniCursuriEgale.Length - 1] = Functie.ObtineNumeLuna((byte)i);
                }
            }

            string mesajLuniEgale = Functie.VectorCaString(luniCursuriEgale);
            Console.WriteLine(mesajLuniEgale);

            Console.ReadKey();


        }

        
    }
}
