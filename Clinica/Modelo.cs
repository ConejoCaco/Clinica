﻿using System;
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
        public string[] ComprobarRutyContra(string b)
        {
            Medicos doc = db.Medicos.Single(r => r.Rut.Equals(b));
            string run = doc.Rut.Trim();
            string contra = doc.Password.Trim();
            string[] RyP = { run, contra };
            return RyP;
        }
        
        public string[] ComprobarSecreRutyPass(string c)
        {
            Secretarios sec = db.Secretarios.Single(r=>r.Rut.Equals((c)));
            string rut = sec.Rut.Trim();
            string contra = sec.Password.Trim();
            string[] DatosSecre = { rut, contra };
            return DatosSecre;
            
        }
        public List<Administrador> admLista()
        {
            List<Administrador> mda = db.Administrador.ToList();
            return mda;
        }

        public List<Medicos> admmedicosLista()
        {
            List<Medicos> mdamedi = db.Medicos.ToList();
            return mdamedi;
        }
        public List<Secretarios> admsecretariosLista()
        {
            List<Secretarios> mdasec = db.Secretarios.ToList();
            return mdasec;
        }
        public List<Citas> CitasLista()
        {
            List<Citas> citas = db.Citas.ToList();
            return citas;
        }
        public List<Pacientes> PacientesListas()
        {
            List<Pacientes> pacientes = db.Pacientes.ToList();
            return pacientes;
        }
        public List<Historial_Medico> Historial()
        {
            List<Historial_Medico> historial = db.Historial_Medico.ToList();
            return historial;
        }
        public string obtenernameylast(string n)
        {
            Medicos doc = db.Medicos.FirstOrDefault(p => p.Nombres == n);
            string nombres = doc.Nombres;
            return nombres;

        }
    }
}
