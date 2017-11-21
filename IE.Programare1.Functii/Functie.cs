using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.Functii
{
    public class Functie
    {
        public static string ObtineNumeLuna(byte luna)
        {
            string[] lunileAnului = new[] { "Ian", "Feb", "Mar", "Apr", "Mai", "Iun", "Iul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            return lunileAnului[luna];
        }

        public static void ScrieMatriceLaConsola(decimal[,] matrice)
        {
            int k = 0;
            while (k < matrice.GetLength(0))
            {
                int l = 0;
                string linie = "";
                while (l < matrice.GetLength(1))
                {
                    linie += matrice[k, l] + " ";
                    l++;
                }
                Console.WriteLine(linie);
                k++;
            }
        }

        public static string VectorCaString(object[] vector)
        {
            string mesaj = "";
            for (int i = 0; i < vector.Length; i++)
            {
                mesaj += vector[i];
                if (i != vector.Length - 1)
                {
                    mesaj += "-";
                }
            }
            return mesaj;
        }
    }
}
