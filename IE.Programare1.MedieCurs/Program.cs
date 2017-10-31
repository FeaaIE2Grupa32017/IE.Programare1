using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.MedieCurs
{
    class Program
    {
        static void Main(string[] args)
        {
            const float prag = 5;
            Console.WriteLine("Introduceti nota1");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti nota2");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti nota la proba practica");
            float probaPractica = float.Parse(Console.ReadLine());

            var notaFinala = nota1 * 0.3 + nota2 * 0.3 + probaPractica * 0.4;

            bool promovat = notaFinala > prag;
            if(promovat)
            {
                Console.WriteLine("Am promovat cu: "+notaFinala);
            }
            else
            {
                Console.WriteLine("Refacere curs: "+notaFinala);
            }
            Console.ReadKey();




        }
    }
}
