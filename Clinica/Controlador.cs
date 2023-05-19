using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;



namespace Clinica
{
    internal class Controlador
    {
        Modelo mo = new Modelo();
        public Controlador() { }

        //Variables Gerson
        private string admin, admpass,admrut;
        //Variables Doctor
        private string rutdoctor, contradoc, nombre, apellido;
        //Variables Clemente
        private string rutsecre, passsecre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Rutdoctor
        {
            get { return rutdoctor; }
            set { rutdoctor = value; }
        }
        public string Contradoc
        {
            get { return contradoc; }
            set { contradoc = value; }
        }

        public string Admin
        {
            get { return admin; }
            set { admin = value; }
        }

        public string Admpass
        {
            get { return admpass; }
            set { admpass = value; }
        }

        public string RutSecre
        {
            get { return rutsecre; }
            set { rutsecre = value; }
        }

        public string PassSecre
        {
            get { return passsecre; }
            set { passsecre = value; }
        }
        public string Admrut
        {
            get { return admrut; }
            set { admrut = value; }
        }



        /*Para usar el metodo de verificar rut, al momento de ingresar paramatros verificar que esten sin puntos
         y con guion*/

        
        public bool Rut(string rut)
        {
            
            rut = rut.Replace(".", "").Replace("-", "");

            
            if (!Regex.IsMatch(rut, @"^\d{7,8}[0-9Kk]$"))
            {
                return false;
            }

            
            char dv = rut[rut.Length - 1];

            
            string cuerpo = rut.Substring(0, rut.Length - 1);

            
            int suma = 0;
            int multiplicador = 2;

            for (int i = cuerpo.Length - 1; i >= 0; i--)
            {
                suma += int.Parse(cuerpo[i].ToString()) * multiplicador;
                multiplicador = multiplicador == 7 ? 2 : multiplicador + 1;
            }

            int resto = suma % 11;
            int verificador = 11 - resto;

            
            if (verificador == 10 && (dv == 'K' || dv == 'k'))
            {
                return true;
            }
            else if (verificador == 11 && dv == '0')
            {
                return true;
            }
            else if (verificador == int.Parse(dv.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Login()
        {
            string[] dat = mo.datos(admin);

            if (dat[0].Equals(admin) && dat[1].Equals(admpass))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool VerifRutDoc()
        {
            string[] RyPv = mo.ComprobarRutyContra(Rutdoctor);
            if (RyPv[0].Equals(rutdoctor) && RyPv[1].Equals(contradoc))
            {
                return true;
            }
            else { return false; }
        }

        public bool VerifRutyPassSecre()
        {
            string[] DatosSecre = mo.ComprobarSecreRutyPass(rutsecre);

            if (DatosSecre[0].Equals(rutsecre) && DatosSecre[1].Equals(passsecre))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ListandoADM(DataGridView a)
        {
            a.DataSource = mo.admLista();
        }
        public void ListandoMed(DataGridView a)
        {
            a.DataSource = mo.admmedicosLista();
        }
        public void ListandoSec(DataGridView a)
        {
            a.DataSource = mo.admsecretariosLista();
        }
        public void Citas(DataGridView tabla)
        {
            tabla.DataSource = mo.CitasLista();
        }
        public void pacientes(DataGridView Pacientes)
        {
            Pacientes.DataSource = mo.PacientesListas();
        }
        public void historial(DataGridView Historial)
        {
            Historial.DataSource = mo.Historial();
        }

        public bool SonPalabras(string x)
        {
            char[] y = x.ToCharArray();
            
            for (int i = 0; i < x.Length; i++)
            {
                if (!char.IsLetter(y[i]))
                {
                    Console.WriteLine("No es una letra");
                    return false;

                }
                
            }
            return true;
            
        }

        public bool VerificarContent(TextBox[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (string.IsNullOrEmpty(a[i].Text))
                {
                    return false;
                }
            }
            return true;
        }
        public string AgregarGuion(string texto)
        {
            texto = texto.ToLower();
            texto = texto.Replace(".", "").Replace("-", "");
            
            char ultimaLetra = texto[texto.Length - 1];

            string resultado = texto.Insert(texto.Length - 1, "-");

            return resultado;
        }

        public bool RegistroAdm()
        {
            if(mo.RegistrarAdm(admin, admpass, admrut))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void Mostrarpaneles(Panel a, Panel b, Panel[] c)
        {
            for (int i = 0; i <= c.Length - 1; i++)
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


    }
}
