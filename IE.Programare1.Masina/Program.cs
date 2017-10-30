using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.Masina
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal depreciere = 0.10m;

            DateTime dataFabricatie;
            Console.WriteLine("Introduceti data fab");
            string dataFabricatieDeLaConsola = Console.ReadLine();
            dataFabricatie = DateTime.Parse(dataFabricatieDeLaConsola);

            Console.WriteLine("Introduceti pretul");
            decimal pret = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Introduceti culoare");
            string culoare = Console.ReadLine();

            Console.WriteLine("Introduceti modelul");
            var model = Console.ReadLine();

            Console.WriteLine("Introduceti Y daca are eur6, N daca nu are");
            bool areEuro6 = Console.ReadLine() == "Y";

            string mesaj = "Masina " + model + " de culoare " + culoare + " fabricata la data " + dataFabricatie + " cu euro6 = " + areEuro6 + " costa " + pret;
            Console.WriteLine(mesaj);

            for(int i = 1; i <= 6; i=i+1)
            {
                pret = pret - pret * depreciere;
                if(i == 4)
                {
                    Console.WriteLine("In ce culoare ati vopsit masina:");
                    culoare = Console.ReadLine();
                }
                if(i == 6)
                {
                    areEuro6 = false;
                }
                if(i == 2 || i == 4 || i == 6)
                {
                    string mesajEuro6 = areEuro6 ? " cu " : " fara ";
                    mesaj = "Dupa " + i + " ani: Masina " + model + " de culoare " + culoare + " fabricata la data " + dataFabricatie + mesajEuro6 +" euro6 costa " + pret;
                    Console.WriteLine(mesaj);

                }

            }
            Console.ReadLine();


        }
    }
}
