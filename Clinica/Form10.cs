using System;
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
    public partial class Form10 : Form
    {
        Controlador controlador = new Controlador();
        public Form10()
        {
            InitializeComponent();
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 nuevo = new Form9();
            nuevo.Show();
        }

        
    }
}
