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
                    Mostrarpaneles(panel1,panel4,paneles);
                    ctr.ListandoADM(dataGridView1);
                    break;
                case 1:
                    Mostrarpaneles(panel2,panel4,paneles);
                    ctr.ListandoMed(dataGridView2);
                    break;
                case 2:
                    Mostrarpaneles(panel3,panel4,paneles);
                    ctr.ListandoSec(dataGridView3);
                    break;
                

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            paneles = new Panel[] {panel1,panel2,panel3,panel4};
            p4 = new TextBox[] { textBox1, textBox2, textBox3 };
        }

        public void Mostrarpaneles(Panel a,Panel b, Panel[] c )
        {
            for (int i = 0;i <= c.Length -1; i++)
            {
                if (c[i] == a || c[i] == b)
                {
                    c[i].Visible = true;
                    
                }
                else
                {
                    c[i].Visible = false;
                }
            }
        }
        //boton agregar
        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarContent(p4))
            {
                
            }
            else
            {
                
            }
        }
        public bool VerificarContent(TextBox[] a )
        {
            for (int i = 0;i < a.Length;i++)
            {
                if (string.IsNullOrEmpty(a[i].Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 4 || textBox1.Text.Length >8)
            {
                ctr.SonPalabras(textBox1.Text);
                label5.Text = "El largo entre 5 y 8";
                label5.Visible = true;
            }
            else
            {
                label5.Visible=false;
            }
        }

        
    }
}
