using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_Final_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Asignando el tamaño de los textbox

            txb_DUI.MaxLength = 9;
            txb_Telefono.MaxLength = 8;
            txb_Nombres.MaxLength = 50;
            txb_Apellidos.MaxLength = 50;
        }

        private void txb_DUI_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txb_DUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validando el que solo se ingresen numeros

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txb_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validando el que solo se ingresen letras al apellido

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
