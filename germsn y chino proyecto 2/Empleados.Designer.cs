/*
 * Creado por SharpDevelop.
 * Usuario: miran
 * Fecha: 11/12/2025
 * Hora: 02:29 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace germsn_y_chino_proyecto_2
{
	partial class Empleados
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker dtFecha;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnActualizarFoto;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RadioButton rbContrato;
		private System.Windows.Forms.RadioButton rbRegular;
		private System.Windows.Forms.ComboBox cmbPuesto;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label lblSexo;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lblPuesto;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblCodigo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnActualizarFoto = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rbContrato = new System.Windows.Forms.RadioButton();
			this.rbRegular = new System.Windows.Forms.RadioButton();
			this.cmbPuesto = new System.Windows.Forms.ComboBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblSexo = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblPuesto = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblCodigo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dtFecha
			// 
			this.dtFecha.Location = new System.Drawing.Point(289, 155);
			this.dtFecha.Margin = new System.Windows.Forms.Padding(4);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(225, 22);
			this.dtFecha.TabIndex = 41;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(687, 489);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(79, 42);
			this.btnLimpiar.TabIndex = 40;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(393, 489);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 42);
			this.btnEliminar.TabIndex = 39;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(124, 489);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(77, 42);
			this.btnGuardar.TabIndex = 38;
			this.btnGuardar.Text = "Guardar ";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// cmbSexo
			// 
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
			"Femenino",
			"Masculino "});
			this.cmbSexo.Location = new System.Drawing.Point(201, 194);
			this.cmbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(121, 24);
			this.cmbSexo.TabIndex = 37;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Codigo,
			this.Nombre,
			this.Puesto,
			this.fecha,
			this.sexo});
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dataGridView1.Location = new System.Drawing.Point(121, 275);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(698, 185);
			this.dataGridView1.TabIndex = 36;
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "txtCodigo";
			this.Codigo.Name = "Codigo";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "txtNombre";
			this.Nombre.Name = "Nombre";
			// 
			// Puesto
			// 
			this.Puesto.HeaderText = "cmbPuesto";
			this.Puesto.Name = "Puesto";
			// 
			// fecha
			// 
			this.fecha.HeaderText = "dtFecha";
			this.fecha.Name = "fecha";
			// 
			// sexo
			// 
			this.sexo.HeaderText = "cmbSexo";
			this.sexo.Name = "sexo";
			// 
			// btnQuitar
			// 
			this.btnQuitar.Location = new System.Drawing.Point(667, 180);
			this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(100, 28);
			this.btnQuitar.TabIndex = 35;
			this.btnQuitar.Text = "quitar";
			this.btnQuitar.UseVisualStyleBackColor = true;
			this.btnQuitar.Click += new System.EventHandler(this.BtnQuitarClick);
			// 
			// btnActualizarFoto
			// 
			this.btnActualizarFoto.Location = new System.Drawing.Point(559, 180);
			this.btnActualizarFoto.Margin = new System.Windows.Forms.Padding(4);
			this.btnActualizarFoto.Name = "btnActualizarFoto";
			this.btnActualizarFoto.Size = new System.Drawing.Size(100, 28);
			this.btnActualizarFoto.TabIndex = 34;
			this.btnActualizarFoto.Text = "actualizar foto";
			this.btnActualizarFoto.UseVisualStyleBackColor = true;
			this.btnActualizarFoto.Click += new System.EventHandler(this.BtnActualizarFotoClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Location = new System.Drawing.Point(559, 40);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(209, 129);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			// 
			// rbContrato
			// 
			this.rbContrato.BackColor = System.Drawing.Color.White;
			this.rbContrato.Location = new System.Drawing.Point(293, 237);
			this.rbContrato.Margin = new System.Windows.Forms.Padding(4);
			this.rbContrato.Name = "rbContrato";
			this.rbContrato.Size = new System.Drawing.Size(88, 30);
			this.rbContrato.TabIndex = 32;
			this.rbContrato.TabStop = true;
			this.rbContrato.Text = "contrato";
			this.rbContrato.UseVisualStyleBackColor = false;
			// 
			// rbRegular
			// 
			this.rbRegular.BackColor = System.Drawing.Color.White;
			this.rbRegular.Location = new System.Drawing.Point(201, 237);
			this.rbRegular.Margin = new System.Windows.Forms.Padding(4);
			this.rbRegular.Name = "rbRegular";
			this.rbRegular.Size = new System.Drawing.Size(79, 30);
			this.rbRegular.TabIndex = 31;
			this.rbRegular.TabStop = true;
			this.rbRegular.Text = "regular";
			this.rbRegular.UseVisualStyleBackColor = false;
			// 
			// cmbPuesto
			// 
			this.cmbPuesto.FormattingEnabled = true;
			this.cmbPuesto.Items.AddRange(new object[] {
			"Pasteleros principales",
			"Ayudantes de pastelería",
			"Decoradores de pasteles",
			"Personal de atención al cliente",
			"Encargado de producción",
			"Personal de limpieza",
			"Administrador"});
			this.cmbPuesto.Location = new System.Drawing.Point(185, 114);
			this.cmbPuesto.Margin = new System.Windows.Forms.Padding(4);
			this.cmbPuesto.Name = "cmbPuesto";
			this.cmbPuesto.Size = new System.Drawing.Size(160, 24);
			this.cmbPuesto.TabIndex = 30;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(303, 75);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(132, 22);
			this.txtNombre.TabIndex = 29;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(393, 40);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(132, 22);
			this.txtCodigo.TabIndex = 28;
			// 
			// lblEstado
			// 
			this.lblEstado.BackColor = System.Drawing.Color.White;
			this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblEstado.Location = new System.Drawing.Point(124, 237);
			this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(57, 28);
			this.lblEstado.TabIndex = 27;
			this.lblEstado.Text = "estado";
			// 
			// lblSexo
			// 
			this.lblSexo.BackColor = System.Drawing.Color.White;
			this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblSexo.Location = new System.Drawing.Point(124, 194);
			this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(57, 28);
			this.lblSexo.TabIndex = 26;
			this.lblSexo.Text = "sexo";
			// 
			// lblFecha
			// 
			this.lblFecha.BackColor = System.Drawing.Color.White;
			this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblFecha.Location = new System.Drawing.Point(121, 155);
			this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(160, 28);
			this.lblFecha.TabIndex = 25;
			this.lblFecha.Text = "fecha de nacimiento";
			// 
			// lblPuesto
			// 
			this.lblPuesto.BackColor = System.Drawing.Color.White;
			this.lblPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblPuesto.Location = new System.Drawing.Point(121, 114);
			this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPuesto.Name = "lblPuesto";
			this.lblPuesto.Size = new System.Drawing.Size(57, 28);
			this.lblPuesto.TabIndex = 24;
			this.lblPuesto.Text = "Puesto";
			// 
			// lblNombre
			// 
			this.lblNombre.BackColor = System.Drawing.Color.White;
			this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblNombre.Location = new System.Drawing.Point(121, 78);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(160, 28);
			this.lblNombre.TabIndex = 23;
			this.lblNombre.Text = "Nombre del empleado";
			// 
			// lblCodigo
			// 
			this.lblCodigo.BackColor = System.Drawing.Color.White;
			this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblCodigo.Location = new System.Drawing.Point(121, 37);
			this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(241, 25);
			this.lblCodigo.TabIndex = 22;
			this.lblCodigo.Text = "codigo del empleado";
			// 
			// Empleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(912, 568);
			this.Controls.Add(this.dtFecha);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.cmbSexo);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.btnActualizarFoto);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.rbContrato);
			this.Controls.Add(this.rbRegular);
			this.Controls.Add(this.cmbPuesto);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.lblSexo);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblPuesto);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblCodigo);
			this.Name = "Empleados";
			this.Text = "Empleados";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
