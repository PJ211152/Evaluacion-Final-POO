using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Final_POO
{
    class Datos_Empleados
    {
        private string[] nombres;
        private string[] apellidos;
        private string[] dui;
        private string[] telefono;
        private string[] correo;

        public string[] Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string[] Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string[] DUI
        {
            get { return dui; }
            set { dui = value; }
        }
        public string[] Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string[] Correo
        {
            get { return correo; }
            set { correo = value; }
        }


    }
}
