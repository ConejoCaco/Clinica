using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form2 : Form
    {
        Controlador ctr = new Controlador();
        
        public Form2()
        {
            InitializeComponent();
        }
        

        private void fm2button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fm2textBox1.Text) || string.IsNullOrEmpty(fm2textBox2.Text))
            {
                MessageBox.Show("Debe completar los campos");
            }
            else
            {
                ctr.Admin = fm2textBox1.Text;
                ctr.Admpass = fm2textBox2.Text;
                if (ctr.Login())
                {
                    Form3 fm3 = new Form3();
                    this.Hide();
                    fm3.Show();
                    MessageBox.Show("Bienvenido!");
                }
                else
                {
                    MessageBox.Show("Verifique sus credenciales");
                    fm2textBox1.Text = String.Empty;
                    fm2textBox2.Text = String.Empty;
                }
            }       
        }

        private void fm2button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }
    }
}
