using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Evaluacion_Final_POO
{
    public partial class Form1 : Form
    {
        int num = 0;
        bool valfecha = false;

        Datos_Empleados empleados = new Datos_Empleados();
        public Form1()
        {
            InitializeComponent();

            //Asignando el tamaño de los textbox

            txb_DUI.MaxLength = 9;
            txb_Telefono.MaxLength = 8;
            txb_Sueldo.MaxLength = 9;
            txb_Nombres.MaxLength = 50;
            txb_Apellidos.MaxLength = 50;

            //Fexha por defecto de el sistema
            dtp_FechaNacimiento.Value = DateTime.Parse("31 Dec 2003");
            dtp_FechaContrato.Value = DateTime.Parse("31 Dec 2003");

            //DEcimal places configuracion

            nud_TasaISSS.Value = 3;
            nud_TasaRenta.Value = 10;

            //El form aparece con los controles apagados
            desactivar();
            dtp_FechaContrato.Enabled = false;
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
            else if (char.IsControl(e.KeyChar))
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

        private void txb_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validando el que solo se ingresen letras al nombre

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txb_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validando el ingreso de números al teléfono

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txb_Sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Vailidando el ingreso de números al sueldo

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txb_Sueldo.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtp_FechaNacimiento_CloseUp(object sender, EventArgs e)
        {
            //Validacion para la fecha de nacimiento

            if(dtp_FechaNacimiento.Value.Date < DateTime.Parse("31 Dec 2003")&& dtp_FechaNacimiento.Value.Date > DateTime.Parse("1 Jan 1972"))
            {
                dtp_FechaContrato.Enabled = true;
                dtp_FechaContrato.Value = dtp_FechaNacimiento.Value.AddYears(18);
                valfecha = true;
            }
            else
            {
                MessageBox.Show("Se admiten fechas desde 1972 hasta 2003", "validación de fecha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtp_FechaNacimiento.Value = DateTime.Parse("31 Dec 2003");
            }
        }

        private void dtp_FechaContrato_CloseUp(object sender, EventArgs e)
        {

            //Validacion para la fecha de Contrato

            if (dtp_FechaContrato.Value.Date < DateTime.Today && dtp_FechaContrato.Value.Date >= (dtp_FechaNacimiento.Value.AddYears(18))&&dtp_FechaContrato.Value.Date<= (dtp_FechaNacimiento.Value.AddYears(50)))
            {

            }
            else
            {
                MessageBox.Show("Ingrese una fecha valida (Se tiene que tener de 18 a 50 años)", "validación de fecha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtp_FechaContrato.Value = dtp_FechaNacimiento.Value.AddYears(18);
            }
        }

        private void txb_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txb_Correo_Leave(object sender, EventArgs e)
        {

            if (validarEmail(txb_Correo.Text))
            {
                
            }
            else
            {
                MessageBox.Show("Ingrese un correo valido", "validación de Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txb_Correo.Text = "";
            }
        }

        public static bool validarEmail(string email)
        {

            //Funcion que indica si el email esta bien escrito
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btn_NuevoEmpleado_Click(object sender, EventArgs e)
        {
            activar();
            lbl_Confirmacion.Text = "";
            btn_Generar.Enabled = false;
            btn_Abrir.Enabled = false;
            dgw_Empleados.Enabled = false;

        }

        public void activar()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btn_SiguienteEmpleado.Enabled = true;
            btn_Generar.Enabled = false;
            btn_Abrir.Enabled = false;
            btn_NuevoEmpleado.Enabled = false;
        }

        public void desactivar()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            btn_SiguienteEmpleado.Enabled = false;
            btn_Generar.Enabled = false;
            btn_Abrir.Enabled = false;
            dgw_Empleados.Enabled = false;
        }

        private void dtp_FechaContrato_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_FechaContrato_MouseDown(object sender, MouseEventArgs e)
        {
            if (dtp_FechaContrato.Enabled == false)
            {
                MessageBox.Show("Primero ingrese la fecha de nacimiento", "validación de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_SiguienteEmpleado_Click(object sender, EventArgs e)
        {
            if (num <= 9)
            {
                if (txb_Nombres.TextLength != 0)
                {
                    if (txb_Telefono.TextLength != 0)
                    {
                        if (txb_Apellidos.TextLength != 0)
                        {
                            if (txb_Sueldo.TextLength != 0)
                            {
                                if (valfecha == true)
                                {
                                    valfecha = false;
                                    empleados.Nombres[num] = txb_Nombres.Text;
                                    empleados.Apellidos[num] = txb_Apellidos.Text;
                                    empleados.DUI[num] = txb_DUI.Text;
                                    empleados.Telefono[num] = txb_Telefono.Text;
                                    empleados.Correo[num] = txb_Correo.Text;
                                    empleados.Sueldo[num] = Convert.ToInt32(txb_Sueldo.Text);
                                    empleados.FechaContrato[num] = dtp_FechaContrato.Value;
                                    empleados.FechaNacimiento[num] = dtp_FechaNacimiento.Value;
                                    empleados.ISSS[num] = Convert.ToDouble(nud_TasaISSS.Value / 100);
                                    empleados.Renta[num] = Convert.ToDouble(nud_TasaRenta.Value / 100);
                                    vaciarcampos();
                                    num = num + 1;
                                    lbl_Confirmacion.Text = Convert.ToString(num);
                                }
                                else
                                {
                                    MessageBox.Show("Verifique que los datos esten ingresados correctamente", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else 
                            {
                                MessageBox.Show("Verifique que los datos esten ingresados correctamente", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        
                        }
                        else
                        {
                            MessageBox.Show("Verifique que los datos esten ingresados correctamente", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Verifique que los datos esten ingresados correctamente", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique que los datos esten ingresados correctamente", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                btn_SiguienteEmpleado.Enabled = false;
                btn_Abrir.Enabled = true;
                btn_Generar.Enabled = true;
                lbl_Confirmacion.Text = "Ya se han llenado los espacios para empleados";
            }
        }

        public void vaciarcampos()
        {
            txb_Nombres.Clear();
            txb_Apellidos.Clear();
            txb_DUI.Clear();
            txb_Telefono.Clear();
            txb_Correo.Clear();
            txb_Sueldo.Clear();
            dtp_FechaNacimiento.Value = DateTime.Parse("31 Dec 2003");
            dtp_FechaContrato.Value = DateTime.Parse("31 Dec 2003");
            dtp_FechaContrato.Enabled = false;
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            int i= 0;
            for (i = 0; i < 9; i++)
            {
                int n = dgw_Empleados.Rows.Add();
                dgw_Empleados.Rows[i].Cells[0].Value = empleados.Nombres[i];
                dgw_Empleados.Rows[i].Cells[1].Value = empleados.Apellidos[i];
                dgw_Empleados.Rows[i].Cells[2].Value = empleados.DUI[i];
                dgw_Empleados.Rows[i].Cells[3].Value = empleados.Telefono[i];
                dgw_Empleados.Rows[i].Cells[4].Value = empleados.Correo[i];
                dgw_Empleados.Rows[i].Cells[5].Value = empleados.Sueldo[i];
                dgw_Empleados.Rows[i].Cells[5].Value = (empleados.Sueldo[i]-empleados.Sueldo[i]*empleados.ISSS[i]- empleados.Sueldo[i] * empleados.Renta[i]);
            }
            btn_NuevoEmpleado.Enabled = true;
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            dgw_Empleados.Enabled = true;
            dgw_Empleados.ReadOnly = true;
            btn_Generar.Enabled = true;
        }

        public void agregar(int x)
        {

        }
    }
}
