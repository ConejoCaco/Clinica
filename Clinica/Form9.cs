﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form9 : Form
    {
        Controlador controlador = new Controlador();
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rut = textrut.Text;
            rut.Replace(" ", "");
            rut.Replace(".", "");
            if (controlador.Rut(rut))
            {

            }
        }
    }
}
