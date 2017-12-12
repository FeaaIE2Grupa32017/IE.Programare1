using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.Struct
{
    public struct Factura
    {
        public int Numar;
        public DateTime Data;
        public Produs[] Linii;

        public override string ToString()
        {
            return $"Nr. {this.Numar} din data {this.Data}";
        }

    }
}
