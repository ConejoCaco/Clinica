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
    public partial class Form9 : Form
    {
        Controlador controlador = new Controlador();
        public Form9()
        {
            
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string rut = RutDoctor.Text;
            rut.Replace(" ", "");
            rut.Replace(".", "");
            try
            {
                if (string.IsNullOrEmpty(RutDoctor.Text) || string.IsNullOrEmpty(PassDoctor.Text))
                {
                    MessageBox.Show("Debe completar los campos");
                }
                else
                {
                    controlador.Admin = RutDoctor.Text;
                    controlador.Admpass = PassDoctor.Text;
                    if (controlador.VerifRutDoc())
                    {
                        Form8 nuevo = new Form8();
                        this.Hide();
                        nuevo.Show();
                        MessageBox.Show("ola");
                    }
                    else
                    {
                        MessageBox.Show("Datos no Verificables");
                        RutDoctor.Text = String.Empty;
                        PassDoctor.Text = String.Empty;
                    }
                }
            }
            catch (Exception q)
            {
                MessageBox.Show("Error " + q);
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }
    }
}
