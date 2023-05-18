using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

      

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelCItas.Show();
            PanelPacientes.Hide();
            PanelHistorial.Hide();
            controlador.Citas(tabla);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PanelCItas.Hide();
            PanelHistorial.Hide();
            PanelPacientes.Show();
            controlador.pacientes(TablaPacientes);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PanelPacientes.Hide();
            PanelCItas.Hide();
            PanelHistorial.Show();
            controlador.historial(TablaHistorial);

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            NombreDoc.Text = controlador.nombredoc();
            NombreDoc.Update();
            PanelCItas.Refresh();
            PanelHistorial.Refresh();
            PanelPacientes.Refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form9 nuevo = new Form9();
            nuevo.Show();
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void NombreDoc_TextChanged(object sender, EventArgs e)
        {
            NombreDoc.Text = controlador.Nombre;
        }
    }
}
