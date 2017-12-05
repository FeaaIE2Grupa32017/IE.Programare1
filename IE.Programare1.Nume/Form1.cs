﻿using System;
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
    }
}
