using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Final_POO
{
    class Datos_Empleados
    {
        private string[] nombres = new string[9];
        private string[] apellidos = new string[9];
        private string[] dui = new string[9];
        private string[] telefono = new string[9];
        private string[] correo = new string[9];
        private int[] sueldo = new int[9];

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
        public int[] Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

    }
}
