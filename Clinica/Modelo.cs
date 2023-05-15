using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Modelo
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Modelo() { }

        public string[] datos(string a)
        {
            Administrador data = db.Administrador.Single(r => r.Usuario.Equals(a));

            string usu = data.Usuario.Trim();
            string pass = data.Password.Trim();

            string[] dt = { usu, pass };

            return dt;
        }
        public string ComprobarRut(string b)
        {
            Medicos doc = db.Medicos.Single(r => r.Rut.Equals(b));
            string run = doc.Rut;
            
            return run;

        }
    }
}
