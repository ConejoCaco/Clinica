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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = comboBox1.SelectedIndex;
            switch (x)
            {
                case 0:
                    this.Hide();
                    Form2 fm2 = new Form2();
                    fm2.Show();
                    break;
                case 1:
                    this.Hide();
                    Form5 fm5 = new Form5();
                    fm5.Show();
                    break;
                case 2:
                    this.Hide();
                    Form9 fm9 = new Form9();
                    fm9.Show();
                    break;
            }
        }
    }
}
