
namespace Evaluacion_Final_POO
{
    partial class frm_Empleado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_Correo = new System.Windows.Forms.TextBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txb_DUI = new System.Windows.Forms.TextBox();
            this.txb_Telefono = new System.Windows.Forms.TextBox();
            this.txb_Apellidos = new System.Windows.Forms.TextBox();
            this.txb_Nombres = new System.Windows.Forms.TextBox();
            this.lbl_FechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_DUI = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nud_TasaRenta = new System.Windows.Forms.NumericUpDown();
            this.nud_TasaISSS = new System.Windows.Forms.NumericUpDown();
            this.dtp_FechaContrato = new System.Windows.Forms.DateTimePicker();
            this.txb_Sueldo = new System.Windows.Forms.TextBox();
            this.lbl_Renta = new System.Windows.Forms.Label();
            this.lbl_ISSS = new System.Windows.Forms.Label();
            this.lbl_Sueldo = new System.Windows.Forms.Label();
            this.lbl_FechaContrato = new System.Windows.Forms.Label();
            this.btn_NuevoEmpleado = new System.Windows.Forms.Button();
            this.btn_SiguienteEmpleado = new System.Windows.Forms.Button();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.dgw_Empleados = new System.Windows.Forms.DataGridView();
            this.lbl_Confirmacion = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suledo_base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo_neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TasaRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TasaISSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_Correo);
            this.groupBox1.Controls.Add(this.lbl_Correo);
            this.groupBox1.Controls.Add(this.dtp_FechaNacimiento);
            this.groupBox1.Controls.Add(this.txb_DUI);
            this.groupBox1.Controls.Add(this.txb_Telefono);
            this.groupBox1.Controls.Add(this.txb_Apellidos);
            this.groupBox1.Controls.Add(this.txb_Nombres);
            this.groupBox1.Controls.Add(this.lbl_FechaNacimiento);
            this.groupBox1.Controls.Add(this.lbl_Telefono);
            this.groupBox1.Controls.Add(this.lbl_DUI);
            this.groupBox1.Controls.Add(this.lbl_Apellidos);
            this.groupBox1.Controls.Add(this.lbl_Nombres);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txb_Correo
            // 
            this.txb_Correo.Location = new System.Drawing.Point(124, 123);
            this.txb_Correo.Name = "txb_Correo";
            this.txb_Correo.Size = new System.Drawing.Size(163, 20);
            this.txb_Correo.TabIndex = 12;
            this.txb_Correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Correo_KeyPress);
            this.txb_Correo.Leave += new System.EventHandler(this.txb_Correo_Leave);
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(46, 126);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(38, 13);
            this.lbl_Correo.TabIndex = 11;
            this.lbl_Correo.Text = "Correo";
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(124, 149);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaNacimiento.TabIndex = 10;
            this.dtp_FechaNacimiento.CloseUp += new System.EventHandler(this.dtp_FechaNacimiento_CloseUp);
            // 
            // txb_DUI
            // 
            this.txb_DUI.Location = new System.Drawing.Point(124, 71);
            this.txb_DUI.Name = "txb_DUI";
            this.txb_DUI.Size = new System.Drawing.Size(163, 20);
            this.txb_DUI.TabIndex = 9;
            this.txb_DUI.TextChanged += new System.EventHandler(this.txb_DUI_TextChanged);
            this.txb_DUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_DUI_KeyPress);
            // 
            // txb_Telefono
            // 
            this.txb_Telefono.Location = new System.Drawing.Point(124, 97);
            this.txb_Telefono.Name = "txb_Telefono";
            this.txb_Telefono.Size = new System.Drawing.Size(163, 20);
            this.txb_Telefono.TabIndex = 8;
            this.txb_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Telefono_KeyPress);
            // 
            // txb_Apellidos
            // 
            this.txb_Apellidos.Location = new System.Drawing.Point(124, 45);
            this.txb_Apellidos.Name = "txb_Apellidos";
            this.txb_Apellidos.Size = new System.Drawing.Size(163, 20);
            this.txb_Apellidos.TabIndex = 6;
            this.txb_Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Apellidos_KeyPress);
            // 
            // txb_Nombres
            // 
            this.txb_Nombres.Location = new System.Drawing.Point(124, 19);
            this.txb_Nombres.Name = "txb_Nombres";
            this.txb_Nombres.Size = new System.Drawing.Size(163, 20);
            this.txb_Nombres.TabIndex = 5;
            this.txb_Nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Nombres_KeyPress);
            // 
            // lbl_FechaNacimiento
            // 
            this.lbl_FechaNacimiento.AutoSize = true;
            this.lbl_FechaNacimiento.Location = new System.Drawing.Point(12, 155);
            this.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            this.lbl_FechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lbl_FechaNacimiento.TabIndex = 4;
            this.lbl_FechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(46, 100);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefono.TabIndex = 3;
            this.lbl_Telefono.Text = "Teléfono";
            // 
            // lbl_DUI
            // 
            this.lbl_DUI.AutoSize = true;
            this.lbl_DUI.Location = new System.Drawing.Point(46, 74);
            this.lbl_DUI.Name = "lbl_DUI";
            this.lbl_DUI.Size = new System.Drawing.Size(26, 13);
            this.lbl_DUI.TabIndex = 2;
            this.lbl_DUI.Text = "DUI";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Location = new System.Drawing.Point(46, 48);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(49, 13);
            this.lbl_Apellidos.TabIndex = 1;
            this.lbl_Apellidos.Text = "Apellidos";
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Location = new System.Drawing.Point(46, 22);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(49, 13);
            this.lbl_Nombres.TabIndex = 0;
            this.lbl_Nombres.Text = "Nombres";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_TasaRenta);
            this.groupBox2.Controls.Add(this.nud_TasaISSS);
            this.groupBox2.Controls.Add(this.dtp_FechaContrato);
            this.groupBox2.Controls.Add(this.txb_Sueldo);
            this.groupBox2.Controls.Add(this.lbl_Renta);
            this.groupBox2.Controls.Add(this.lbl_ISSS);
            this.groupBox2.Controls.Add(this.lbl_Sueldo);
            this.groupBox2.Controls.Add(this.lbl_FechaContrato);
            this.groupBox2.Location = new System.Drawing.Point(385, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Empresariales";
            // 
            // nud_TasaRenta
            // 
            this.nud_TasaRenta.DecimalPlaces = 1;
            this.nud_TasaRenta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_TasaRenta.Location = new System.Drawing.Point(250, 101);
            this.nud_TasaRenta.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_TasaRenta.Name = "nud_TasaRenta";
            this.nud_TasaRenta.ReadOnly = true;
            this.nud_TasaRenta.Size = new System.Drawing.Size(77, 20);
            this.nud_TasaRenta.TabIndex = 13;
            // 
            // nud_TasaISSS
            // 
            this.nud_TasaISSS.DecimalPlaces = 1;
            this.nud_TasaISSS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_TasaISSS.Location = new System.Drawing.Point(88, 102);
            this.nud_TasaISSS.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_TasaISSS.Name = "nud_TasaISSS";
            this.nud_TasaISSS.ReadOnly = true;
            this.nud_TasaISSS.Size = new System.Drawing.Size(77, 20);
            this.nud_TasaISSS.TabIndex = 12;
            // 
            // dtp_FechaContrato
            // 
            this.dtp_FechaContrato.Location = new System.Drawing.Point(127, 42);
            this.dtp_FechaContrato.Name = "dtp_FechaContrato";
            this.dtp_FechaContrato.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaContrato.TabIndex = 11;
            this.dtp_FechaContrato.CloseUp += new System.EventHandler(this.dtp_FechaContrato_CloseUp);
            this.dtp_FechaContrato.ValueChanged += new System.EventHandler(this.dtp_FechaContrato_ValueChanged);
            this.dtp_FechaContrato.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtp_FechaContrato_MouseDown);
            // 
            // txb_Sueldo
            // 
            this.txb_Sueldo.Location = new System.Drawing.Point(127, 68);
            this.txb_Sueldo.Name = "txb_Sueldo";
            this.txb_Sueldo.Size = new System.Drawing.Size(163, 20);
            this.txb_Sueldo.TabIndex = 11;
            this.txb_Sueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Sueldo_KeyPress);
            // 
            // lbl_Renta
            // 
            this.lbl_Renta.AutoSize = true;
            this.lbl_Renta.Location = new System.Drawing.Point(183, 104);
            this.lbl_Renta.Name = "lbl_Renta";
            this.lbl_Renta.Size = new System.Drawing.Size(61, 13);
            this.lbl_Renta.TabIndex = 8;
            this.lbl_Renta.Text = "Tasa renta:";
            // 
            // lbl_ISSS
            // 
            this.lbl_ISSS.AutoSize = true;
            this.lbl_ISSS.Location = new System.Drawing.Point(21, 104);
            this.lbl_ISSS.Name = "lbl_ISSS";
            this.lbl_ISSS.Size = new System.Drawing.Size(61, 13);
            this.lbl_ISSS.TabIndex = 7;
            this.lbl_ISSS.Text = "Tasa ISSS:";
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.AutoSize = true;
            this.lbl_Sueldo.Location = new System.Drawing.Point(24, 71);
            this.lbl_Sueldo.Name = "lbl_Sueldo";
            this.lbl_Sueldo.Size = new System.Drawing.Size(69, 13);
            this.lbl_Sueldo.TabIndex = 6;
            this.lbl_Sueldo.Text = "Sueldo base:";
            // 
            // lbl_FechaContrato
            // 
            this.lbl_FechaContrato.AutoSize = true;
            this.lbl_FechaContrato.Location = new System.Drawing.Point(24, 46);
            this.lbl_FechaContrato.Name = "lbl_FechaContrato";
            this.lbl_FechaContrato.Size = new System.Drawing.Size(97, 13);
            this.lbl_FechaContrato.TabIndex = 5;
            this.lbl_FechaContrato.Text = "Fecha de contrato:";
            // 
            // btn_NuevoEmpleado
            // 
            this.btn_NuevoEmpleado.Location = new System.Drawing.Point(38, 226);
            this.btn_NuevoEmpleado.Name = "btn_NuevoEmpleado";
            this.btn_NuevoEmpleado.Size = new System.Drawing.Size(125, 50);
            this.btn_NuevoEmpleado.TabIndex = 2;
            this.btn_NuevoEmpleado.Text = "Nuevo empleado";
            this.btn_NuevoEmpleado.UseVisualStyleBackColor = true;
            this.btn_NuevoEmpleado.Click += new System.EventHandler(this.btn_NuevoEmpleado_Click);
            // 
            // btn_SiguienteEmpleado
            // 
            this.btn_SiguienteEmpleado.Location = new System.Drawing.Point(211, 226);
            this.btn_SiguienteEmpleado.Name = "btn_SiguienteEmpleado";
            this.btn_SiguienteEmpleado.Size = new System.Drawing.Size(125, 50);
            this.btn_SiguienteEmpleado.TabIndex = 3;
            this.btn_SiguienteEmpleado.Text = "Proximo empleado";
            this.btn_SiguienteEmpleado.UseVisualStyleBackColor = true;
            this.btn_SiguienteEmpleado.Click += new System.EventHandler(this.btn_SiguienteEmpleado_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Location = new System.Drawing.Point(409, 224);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(125, 50);
            this.btn_Abrir.TabIndex = 4;
            this.btn_Abrir.Text = "Abrir plantilla";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // btn_Generar
            // 
            this.btn_Generar.Location = new System.Drawing.Point(597, 226);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(125, 50);
            this.btn_Generar.TabIndex = 5;
            this.btn_Generar.Text = "Generar plantilla";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // dgw_Empleados
            // 
            this.dgw_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.dui,
            this.Telefono,
            this.correo,
            this.suledo_base,
            this.sueldo_neto});
            this.dgw_Empleados.Location = new System.Drawing.Point(28, 306);
            this.dgw_Empleados.Name = "dgw_Empleados";
            this.dgw_Empleados.Size = new System.Drawing.Size(715, 185);
            this.dgw_Empleados.TabIndex = 6;
            // 
            // lbl_Confirmacion
            // 
            this.lbl_Confirmacion.AutoSize = true;
            this.lbl_Confirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirmacion.Location = new System.Drawing.Point(356, 287);
            this.lbl_Confirmacion.Name = "lbl_Confirmacion";
            this.lbl_Confirmacion.Size = new System.Drawing.Size(0, 16);
            this.lbl_Confirmacion.TabIndex = 7;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellidos";
            this.apellido.Name = "apellido";
            // 
            // dui
            // 
            this.dui.HeaderText = "DUI";
            this.dui.Name = "dui";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            // 
            // suledo_base
            // 
            this.suledo_base.HeaderText = "Sueldo base";
            this.suledo_base.Name = "suledo_base";
            // 
            // sueldo_neto
            // 
            this.sueldo_neto.HeaderText = "Sueldo neto";
            this.sueldo_neto.Name = "sueldo_neto";
            // 
            // frm_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 503);
            this.Controls.Add(this.lbl_Confirmacion);
            this.Controls.Add(this.dgw_Empleados);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.btn_Abrir);
            this.Controls.Add(this.btn_SiguienteEmpleado);
            this.Controls.Add(this.btn_NuevoEmpleado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Empleado";
            this.Text = "Datos de Empleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TasaRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TasaISSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.TextBox txb_DUI;
        private System.Windows.Forms.TextBox txb_Telefono;
        private System.Windows.Forms.TextBox txb_Apellidos;
        private System.Windows.Forms.TextBox txb_Nombres;
        private System.Windows.Forms.Label lbl_FechaNacimiento;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_DUI;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Renta;
        private System.Windows.Forms.Label lbl_ISSS;
        private System.Windows.Forms.Label lbl_Sueldo;
        private System.Windows.Forms.Label lbl_FechaContrato;
        private System.Windows.Forms.NumericUpDown nud_TasaRenta;
        private System.Windows.Forms.NumericUpDown nud_TasaISSS;
        private System.Windows.Forms.DateTimePicker dtp_FechaContrato;
        private System.Windows.Forms.TextBox txb_Sueldo;
        private System.Windows.Forms.Button btn_NuevoEmpleado;
        private System.Windows.Forms.Button btn_SiguienteEmpleado;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.TextBox txb_Correo;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.DataGridView dgw_Empleados;
        private System.Windows.Forms.Label lbl_Confirmacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn suledo_base;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo_neto;
    }
}

