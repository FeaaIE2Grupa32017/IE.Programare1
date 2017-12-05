using IE.Programare1.Functii;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE.Programare1.RezolvareEqGrad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxButtonRezolva_Click(object sender, EventArgs e)
        {
            double a = double.Parse(uxTextBoxA.Text);
            double b = double.Parse(uxTextBoxB.Text);
            double c = Convert.ToDouble(uxTextBoxC.Text);

            bool infinitateSolutii;
            double[] solutii = Functie.EqGrad2(a, b, c, out infinitateSolutii);

            string mesaj = "";

            if (infinitateSolutii)
            {
                mesaj = "Infinitate de solutii";
            }
            else
            {
                if (solutii.Length == 0)
                {
                    mesaj = "Nu exista solutii";
                }
                else if (solutii.Length == 1)
                {
                    mesaj = "Ecuatie de gradul 1. x=" + solutii[0];
                }
                else
                {
                    mesaj = solutii[0] == solutii[1] ? "X1=X2=" + solutii[0] : "X1 = " + solutii[0] + " X2=" + solutii[1];
                }
            }
            MessageBox.Show(mesaj);
        }
    }
}
