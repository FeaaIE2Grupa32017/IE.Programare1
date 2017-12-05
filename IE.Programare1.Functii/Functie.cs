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

        public static double[] EqGrad2(double a, double b, double c, out bool infinitateSolutii)
        {
            double[] solutii = new double[0];

            infinitateSolutii = false;
            if (a == 0 && b == 0 && c == 0)
            {
                infinitateSolutii = true;
                return solutii;
            }
            if (a == 0 && b == 0)
            {
                return solutii;
            }
            if (a == 0)
            {
                Array.Resize(ref solutii, 1);
                solutii[0] = -c / b;
                

            }
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta >= 0)
                {
                    Array.Resize(ref solutii, 2);
                    if (delta == 0)
                    {
                        solutii[0] = solutii[1] = -b / 2 * a;
                    }
                    else
                    {
                        solutii[0] = (-b + Math.Sqrt(delta)) / 2 * a;
                        solutii[1] = (-b - Math.Sqrt(delta)) / 2 * a;
                    }
                }
                
            }
            return solutii;


        }


    }
}
