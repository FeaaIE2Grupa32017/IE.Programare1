using IE.Programare1.Functii;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.CursDeSchimb
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataCurenta = DateTime.Now;
            //int lunaCurenta = dataCurenta.Month;
            //doar pentru teste; inlucuieste cu linia de mai sus
            int lunaCurenta = 6;

            decimal[] cursuri = new decimal[lunaCurenta - 1];
            int i = 0;
            while (i < cursuri.Length)
            {
                Console.WriteLine("Introduceti cursul pentru luna " + i);
                cursuri[i] = Convert.ToDecimal(Console.ReadLine());
                i++;
            }

            int j = 1;
            decimal min, max, media, suma;
            min = cursuri[0];
            max = cursuri[0];
            suma = cursuri[0];
            do
            {
                if (cursuri[j] < min)
                {
                    min = cursuri[j];
                }
                if (cursuri[j] > max)
                {
                    max = cursuri[j];
                }
                suma += cursuri[j];
                j++;
            } while (j < cursuri.Length);
            media = suma / cursuri.Length;

            int[] luniMin = new int[0];
            int[] luniMax = new int[0];

            for (int k = 0; k < cursuri.Length; k++)
            {
                if (min == cursuri[k])
                {
                    Array.Resize(ref luniMin, luniMin.Length + 1);
                    luniMin[luniMin.Length - 1] = k;
                }
                if (max == cursuri[k])
                {
                    Array.Resize(ref luniMax, luniMax.Length + 1);
                    luniMax[luniMax.Length - 1] = k;
                }
            }
            string mesaj = "Luni de min: ";
            for (int k = 0; k < luniMin.Length; k++)
            {
                string numeLuna = Functie.ObtineNumeLuna((byte)luniMin[k]);
                mesaj += numeLuna;
                if (k != luniMin.Length - 1)
                {
                    mesaj += ";";
                }

                //mesaj += luniMin[k] + (k == luniMin.Length - 1 ? "" : ";");

                //if(k == luniMin.Length - 1)
                //{
                //    mesaj += luniMin[k];
                //}
                //else
                //{
                //    mesaj += luniMin[k] + ";";
                //}
            }
            Console.WriteLine(mesaj);

            Console.WriteLine("Luni de max: " + string.Join(";", luniMax));
            Console.WriteLine("Media este: " + media);



            Console.ReadKey();
        }


        
    }
}
