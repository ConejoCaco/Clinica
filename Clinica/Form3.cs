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
    public partial class Form3 : Form
    {
        private static int key = 0;
        Controlador ctr = new Controlador();
        Panel[] paneles;
        TextBox[] p4;
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = comboBox1.SelectedIndex;
            switch (x)
            {
                case 0:
                    ctr.Mostrarpaneles(panel1,panel4,paneles);
                    ctr.ListandoADM(dataGridView1);
                    break;
                case 1:
                    ctr.Mostrarpaneles(panel2,panel2,paneles);
                    ctr.ListandoMed(dataGridView2);
                    break;
                case 2:
                    ctr.Mostrarpaneles(panel3,panel3,paneles);
                    ctr.ListandoSec(dataGridView3);
                    break;
                

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            paneles = new Panel[] {panel1,panel2,panel3,panel4};
            p4 = new TextBox[] { textBox1, textBox2, textBox3 };
        }

        
        //boton agregar
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ctr.VerificarContent(p4))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                string run = ctr.AgregarGuion(textBox3.Text);
                ctr.Admin = textBox1.Text;
                ctr.Admpass = textBox2.Text;
                ctr.Admrut = run;
                if (ctr.RegistroAdm())
                {
                    MessageBox.Show("Registrado existosamente");
                }
                else
                {
                    MessageBox.Show("Fallo al registrar");
                }
                
                
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 4 || textBox1.Text.Length >8)
            {
                label5.Text = "El largo entre 5 y 8";
                if (!ctr.SonPalabras(textBox1.Text))
                {
                    label5.Text = "Solo letras";
                }
                button1.Enabled = false;
                label5.Visible = true;
            }
            else
            {
                button1.Enabled = true;
                label5.Visible=false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 4 || textBox1.Text.Length > 8)
            {
                label6.Text = "El largo entre 5 y 8";
                button1.Enabled = false;
                
            }
            else
            {
                label6.Text = String.Empty;
                button1.Enabled = true;
                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!ctr.Rut(textBox3.Text))
            {
                label7.Text = "Ingrese un rut valido";
                button1.Enabled =false;
            }
            else
            {
                label7.Text = String.Empty;
                button1.Enabled = true;
            }
        }
    }
}
