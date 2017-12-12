using IE.Programare1.Struct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE.Programare1.Facturi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Factura[] facturi = new Factura[0];


        private void uxButtonAddFact_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            try
            {               
                factura.Numar = Convert.ToInt32(uxTextBoxNumar.Text);
            }
            catch(FormatException)
            {                
                MessageBox.Show("Valoarea trebuie sa fie numerica!");
                return;
            }
          
            factura.Data = uxDateTimePickerDataFact.Value;

            Array.Resize(ref facturi, facturi.Length + 1);
            facturi[facturi.Length - 1] = factura;

            uxListBoxFacturi.DataSource = facturi;

        }
    }
}
