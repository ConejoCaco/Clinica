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
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel1.Show();
                    ctr.ListandoADM(dataGridView1);
                    break;
                case 1:
                    panel1.Visible = false;
                    panel3.Visible = false;
                    panel2.Show();
                    ctr.ListandoMed(dataGridView2);
                    break;
                case 2:
                    panel2.Visible = false;
                    panel1.Visible = false;
                    panel3.Show();
                    ctr.ListandoSec(dataGridView3);
                    break;
                

            }
        }
    }
}
