using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            if (string.IsNullOrEmpty(RutDoctor.Text) || string.IsNullOrEmpty(PassDoctor.Text))
            {
                MessageBox.Show("Rellene los campos por favor");
            }
            else
            {
                controlador.Rutdoctor = RutDoctor.Text;
                controlador.Contradoc = PassDoctor.Text;
                if (controlador.VerifRutDoc())
                {
                    
                    Form10 nuevo = new Form10();
                    
                    this.Hide();
                    nuevo.Show();
                    
                }
                else
                {
                    MessageBox.Show("Datos Invalidos");
                }
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
