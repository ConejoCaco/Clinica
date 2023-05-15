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
    public partial class Form5 : Form
    {
        Controlador control = new Controlador();    
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Rellene los campos por favor");
            }
            else 
            {
                control.RutSecre = textBox1.Text;
                control.PassSecre = textBox2.Text;
                if (control.VerifRutyPassSecre())
                {
                    Form6 form6 = new Form6();
                    this.Hide();
                    form6.Show();

                }
            
            
            }
            

        }
    }
}
