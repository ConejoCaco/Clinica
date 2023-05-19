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
    public partial class Form6 : Form
    {
        Controlador control = new Controlador();
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
