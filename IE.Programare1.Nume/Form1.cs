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

namespace IE.Programare1.Nume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxButtonAdauga_Click(object sender, EventArgs e)
        {
            AdaugaNume();
        }

        private void AdaugaNume()
        {
            string nume = uxTextBoxNume.Text;
            uxListBoxNume.Items.Add(nume);
            uxTextBoxNume.Focus();
            uxTextBoxNume.Select(0, uxTextBoxNume.Text.Length);
        }

        private void uxTextBoxNume_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdaugaNume();
            }
        }

        private void uxButtonOrdoneaza_Click(object sender, EventArgs e)
        {
            string[] valori = new string[uxListBoxNume.Items.Count];
            for (int i = 0; i < uxListBoxNume.Items.Count; i++)
            {
                valori[i] = uxListBoxNume.Items[i].ToString();
            }

            //Functie.BubbleSort(valori, uxCheckBoxDirectie.Checked);
            //Functie.InsertionSort(valori, uxCheckBoxDirectie.Checked);
            //Functie.SelectionSort(valori, uxCheckBoxDirectie.Checked);
            Array.Sort(valori);
            if (uxCheckBoxDirectie.Checked)
            {
                Array.Reverse(valori);
            }
            uxListBoxNume.Items.Clear();
            uxListBoxNume.Items.AddRange(valori);
        }
    }
}
