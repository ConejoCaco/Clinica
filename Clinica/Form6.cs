using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form6 : Form
    {
        Controlador control = new Controlador();
        DateTime a;
        TextBox[] x; 
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!control.VerificarContent(x))
            {
                MessageBox.Show("Complete los campos");
            }
            else
            {
                int k = Convert.ToInt32(textBox6.Text);
                string rut = control.AgregarGuion(textBox4.Text);
                control.NombrePaciente = textBox1.Text;
                control.ApellidosPaciente = textBox2.Text;
                control.FechaNaciemiento = a;
                control.RutPaciente = rut;
                control.EmailPaciente = textBox5.Text;
                control.TelefonoPaciente = k;

                if (control.RegistroPaciente())
                {
                    MessageBox.Show("Correctamente Registrado");
                }
                else
                {
                    MessageBox.Show("Falla de Registro");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            control.pacientes(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            control.Citas(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            a = dateTimePicker1.Value.Date;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            x = new TextBox[] { textBox1, textBox2, textBox4, textBox5, textBox6 };
        }
    }
}
