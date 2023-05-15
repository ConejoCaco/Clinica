using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    internal class Controlador
    {
        Modelo mo = new Modelo();
        public Controlador() { }

        //Variables Gerson
        private string admin, admpass;
        //Variables Doctor
        private string rutdoctor, contradoc;
        //Variables Clemente
        private string rutsecre,passsecre;

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
            get { return admin;}
            set { admin = value;}
        }

        public string Admpass
        {
            get { return admpass;}
            set { admpass = value;}
        }

        public string RutSecre 
        {
            get { return rutsecre;} 
            set { rutsecre = value;}
        }
        
        public string PassSecre
        {
            get { return passsecre;}
            set { passsecre = value;}
        }
        //Termino Variables Gerson


        /*Para usar el metodo de verificar rut, al momento de ingresar paramatros verificar que esten sin puntos
         y con guion*/

        public bool Rut(string rut)
        {
            string run = "";
            string auxrut = rut;
            string rut1 = rut.Split('-')[0];
            int sum = 0;
            int mult = 0;
            int num_verificador = 0;
            char[] rut_div = rut1.ToCharArray();
            int[] a8 = { 2, 3, 4, 5, 6, 7, 2, 3 };

            
                try
                {
                    for (int i = rut1.Length - 1; i >= 0; i--)
                    {
                        if (char.IsDigit(rut_div[i]))
                        {
                            run += rut_div[i];
                        }
                    }
                    char[] rutf = run.ToCharArray();
                    if (rutf.Length == 7)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            char a = rutf[i];
                            int b;
                            b = a - '0';
                            mult = b * a8[i];
                            sum += mult;
                        }
                        int c = sum / 11;
                        int d = c * 11;
                        int e = sum - d;
                        num_verificador = 11 - e;
                    }
                    if (rutf.Length == 8)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            char a = rutf[i];
                            int b;
                            b = a - '0';
                            mult = b * a8[i];
                            sum += mult;
                        }
                        int c = sum / 11;
                        int d = c * 11;
                        int e = sum - d;
                        num_verificador = 11 - e;
                    }
                }
                catch (Exception e) { }

                string ultimo = auxrut.Substring(auxrut.Length - 1);
                string auxR = num_verificador.ToString();
                if (ultimo.Equals("K") || ultimo.Equals("k") && num_verificador == 10)
                {
                    return true;
                }
                else if (auxR.Equals(ultimo))
                {
                    return true;
                }
                else if (ultimo.Equals("0") && num_verificador == 11)
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

            if (dat[0].Equals(admin) && dat[1].Equals(admpass)) { 
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
            string[] DatosSecre = mo.ComprobarSecreRutyPass(Admin);

            if (DatosSecre[0].Equals(rutsecre) && DatosSecre[1].Equals(passsecre))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
