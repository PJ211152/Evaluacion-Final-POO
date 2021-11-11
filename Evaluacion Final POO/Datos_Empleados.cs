using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Final_POO
{
    class Datos_Empleados
    {
        private string[] nombres = new string[10];
        private string[] apellidos = new string[10];
        private string[] dui = new string[10];
        private string[] telefono = new string[10];
        private string[] correo = new string[10];
        private double[] sueldo = new double[10];
        private double[] isss = new double[10];
        private double[] renta = new double[10];
        private DateTime[] fechaNacimiento = new DateTime[10];
        private DateTime[] fechaContrato = new DateTime[10];

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
        public double[] Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public DateTime[] FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public DateTime[] FechaContrato
        {
            get { return fechaContrato; }
            set { fechaContrato = value; }
        }
        public double[] ISSS
        {
            get { return isss; }
            set { isss = value; }
        }
        public double[] Renta
        {
            get { return renta; }
            set { renta = value; }
        }



    }
}
