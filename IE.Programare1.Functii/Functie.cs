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

        public static void InsertionSort(string[] valori, bool descrescator)
        {
            string temp;
            int j;
            for (int i = 1; i < valori.Length; i++)
            {
                temp = valori[i];
                j = i - 1;

                while (j >= 0 && (descrescator ? valori[j].CompareTo(temp) < 0 : valori[j].CompareTo(temp) > 0))
                {
                    valori[j + 1] = valori[j];
                    j--;
                }

                if (i != j + 1)
                {
                    valori[j + 1] = temp;
                }
            }
        }

        public static void SelectionSort(string[] valori, bool descrescator)
        {
            for (int i = 0; i < valori.Length; i++)
            {
                int minMaxIdx = i;
                int j = i + 1;
                while (j < valori.Length)
                {
                    if (descrescator ? valori[minMaxIdx].CompareTo(valori[j]) < 0 : valori[minMaxIdx].CompareTo(valori[j]) > 0)
                    {
                        minMaxIdx = j;
                    }
                    j++;
                }

                if (minMaxIdx != i)
                {
                    string temp = valori[minMaxIdx];
                    valori[minMaxIdx] = valori[i];
                    valori[i] = temp;
                }
            }
        }


        public static void BubbleSort(string[] valori, bool descrescator)
        {
            string temp;
            bool ordonat;

            do
            {
                ordonat = true;
                for (int i = 0; i < valori.Length - 1; i++)
                {
                    bool conditieOrdonare = descrescator ? valori[i].CompareTo(valori[i + 1]) < 0 : valori[i].CompareTo(valori[i + 1]) > 0;
                    if (conditieOrdonare)
                    {
                        temp = valori[i];
                        valori[i] = valori[i + 1];
                        valori[i + 1] = temp;
                        ordonat = false;
                    }
                }
            } while (!ordonat);

        }



    }
}
