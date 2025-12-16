/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC48
 * Fecha: 15/12/2025
 * Hora: 06:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace germsn_y_chino_proyecto_2
{
	partial class BoletaDeCalifi
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.lvTabla = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.TxtPromedio = new System.Windows.Forms.TextBox();
			this.LblPromedio = new System.Windows.Forms.Label();
			this.TxtParcial3 = new System.Windows.Forms.TextBox();
			this.TxtParcial2 = new System.Windows.Forms.TextBox();
			this.TxtParcial1 = new System.Windows.Forms.TextBox();
			this.LblParcial3 = new System.Windows.Forms.Label();
			this.Parcial2 = new System.Windows.Forms.Label();
			this.LblParcial1 = new System.Windows.Forms.Label();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.BtnRegistrar = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cmbSubmodulo = new System.Windows.Forms.ComboBox();
			this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
			this.cmbGrado = new System.Windows.Forms.ComboBox();
			this.TxtNombreDelAlumno = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.LblAdignatura = new System.Windows.Forms.Label();
			this.LblEspecialidad = new System.Windows.Forms.Label();
			this.LblGrado = new System.Windows.Forms.Label();
			this.LblNombreAlumno = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lvTabla
			// 
			this.lvTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.lvTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7});
			this.lvTabla.Location = new System.Drawing.Point(52, 322);
			this.lvTabla.Margin = new System.Windows.Forms.Padding(2);
			this.lvTabla.Name = "lvTabla";
			this.lvTabla.Size = new System.Drawing.Size(702, 201);
			this.lvTabla.TabIndex = 44;
			this.lvTabla.UseCompatibleStateImageBehavior = false;
			this.lvTabla.View = System.Windows.Forms.View.Details;
			this.lvTabla.SelectedIndexChanged += new System.EventHandler(this.LvTablaSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Nombre";
			this.columnHeader1.Width = 141;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Asugnatura";
			this.columnHeader2.Width = 106;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Parcial 1";
			this.columnHeader3.Width = 94;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Parcial 2";
			this.columnHeader4.Width = 98;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Parcial 3";
			this.columnHeader5.Width = 119;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Promedio";
			this.columnHeader6.Width = 175;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Aprobado o no Aprobado";
			this.columnHeader7.Width = 196;
			// 
			// BtnSalir
			// 
			this.BtnSalir.BackColor = System.Drawing.Color.Red;
			this.BtnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSalir.Location = new System.Drawing.Point(485, 196);
			this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(56, 27);
			this.BtnSalir.TabIndex = 43;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.UseVisualStyleBackColor = false;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// TxtPromedio
			// 
			this.TxtPromedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtPromedio.Location = new System.Drawing.Point(217, 273);
			this.TxtPromedio.Margin = new System.Windows.Forms.Padding(2);
			this.TxtPromedio.Name = "TxtPromedio";
			this.TxtPromedio.Size = new System.Drawing.Size(109, 20);
			this.TxtPromedio.TabIndex = 42;
			// 
			// LblPromedio
			// 
			this.LblPromedio.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPromedio.Location = new System.Drawing.Point(52, 273);
			this.LblPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblPromedio.Name = "LblPromedio";
			this.LblPromedio.Size = new System.Drawing.Size(104, 37);
			this.LblPromedio.TabIndex = 41;
			this.LblPromedio.Text = "Promedio Final";
			// 
			// TxtParcial3
			// 
			this.TxtParcial3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TxtParcial3.Location = new System.Drawing.Point(635, 70);
			this.TxtParcial3.Margin = new System.Windows.Forms.Padding(2);
			this.TxtParcial3.Name = "TxtParcial3";
			this.TxtParcial3.Size = new System.Drawing.Size(47, 20);
			this.TxtParcial3.TabIndex = 40;
			// 
			// TxtParcial2
			// 
			this.TxtParcial2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TxtParcial2.Location = new System.Drawing.Point(561, 70);
			this.TxtParcial2.Margin = new System.Windows.Forms.Padding(2);
			this.TxtParcial2.Name = "TxtParcial2";
			this.TxtParcial2.Size = new System.Drawing.Size(47, 20);
			this.TxtParcial2.TabIndex = 39;
			// 
			// TxtParcial1
			// 
			this.TxtParcial1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TxtParcial1.Location = new System.Drawing.Point(492, 70);
			this.TxtParcial1.Margin = new System.Windows.Forms.Padding(2);
			this.TxtParcial1.Name = "TxtParcial1";
			this.TxtParcial1.Size = new System.Drawing.Size(44, 20);
			this.TxtParcial1.TabIndex = 38;
			// 
			// LblParcial3
			// 
			this.LblParcial3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblParcial3.Location = new System.Drawing.Point(635, 40);
			this.LblParcial3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblParcial3.Name = "LblParcial3";
			this.LblParcial3.Size = new System.Drawing.Size(75, 19);
			this.LblParcial3.TabIndex = 37;
			this.LblParcial3.Text = "Parcial3";
			// 
			// Parcial2
			// 
			this.Parcial2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Parcial2.Location = new System.Drawing.Point(561, 41);
			this.Parcial2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Parcial2.Name = "Parcial2";
			this.Parcial2.Size = new System.Drawing.Size(75, 19);
			this.Parcial2.TabIndex = 36;
			this.Parcial2.Text = "Parcial2";
			// 
			// LblParcial1
			// 
			this.LblParcial1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblParcial1.Location = new System.Drawing.Point(492, 40);
			this.LblParcial1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblParcial1.Name = "LblParcial1";
			this.LblParcial1.Size = new System.Drawing.Size(75, 19);
			this.LblParcial1.TabIndex = 35;
			this.LblParcial1.Text = "Parcial1";
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.BackColor = System.Drawing.Color.Yellow;
			this.BtnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCancelar.Location = new System.Drawing.Point(401, 196);
			this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(64, 27);
			this.BtnCancelar.TabIndex = 34;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = false;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// BtnRegistrar
			// 
			this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnRegistrar.Location = new System.Drawing.Point(317, 196);
			this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(2);
			this.BtnRegistrar.Name = "BtnRegistrar";
			this.BtnRegistrar.Size = new System.Drawing.Size(65, 27);
			this.BtnRegistrar.TabIndex = 33;
			this.BtnRegistrar.Text = "Registrar ";
			this.BtnRegistrar.UseVisualStyleBackColor = false;
			this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(217, 204);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
			this.dateTimePicker1.TabIndex = 32;
			// 
			// cmbSubmodulo
			// 
			this.cmbSubmodulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cmbSubmodulo.FormattingEnabled = true;
			this.cmbSubmodulo.Items.AddRange(new object[] {
									"Emplea Software",
									"Ingles ",
									"Lengua y comunicacion",
									"Ecositemas y  sus interacciones ",
									"Humanidades ",
									"Educacion Socioemocional"});
			this.cmbSubmodulo.Location = new System.Drawing.Point(217, 161);
			this.cmbSubmodulo.Margin = new System.Windows.Forms.Padding(2);
			this.cmbSubmodulo.Name = "cmbSubmodulo";
			this.cmbSubmodulo.Size = new System.Drawing.Size(238, 21);
			this.cmbSubmodulo.TabIndex = 31;
			// 
			// cmbEspecialidad
			// 
			this.cmbEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cmbEspecialidad.FormattingEnabled = true;
			this.cmbEspecialidad.Items.AddRange(new object[] {
									"Proogramacion ",
									"Soporte",
									"Alimentos",
									"Mecanica",
									"Siberseguridad",
									"Mecanica"});
			this.cmbEspecialidad.Location = new System.Drawing.Point(217, 118);
			this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(2);
			this.cmbEspecialidad.Name = "cmbEspecialidad";
			this.cmbEspecialidad.Size = new System.Drawing.Size(238, 21);
			this.cmbEspecialidad.TabIndex = 30;
			// 
			// cmbGrado
			// 
			this.cmbGrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cmbGrado.FormattingEnabled = true;
			this.cmbGrado.Items.AddRange(new object[] {
									"1",
									"2",
									"3"});
			this.cmbGrado.Location = new System.Drawing.Point(217, 81);
			this.cmbGrado.Margin = new System.Windows.Forms.Padding(2);
			this.cmbGrado.Name = "cmbGrado";
			this.cmbGrado.Size = new System.Drawing.Size(65, 21);
			this.cmbGrado.TabIndex = 29;
			// 
			// TxtNombreDelAlumno
			// 
			this.TxtNombreDelAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtNombreDelAlumno.Location = new System.Drawing.Point(217, 41);
			this.TxtNombreDelAlumno.Margin = new System.Windows.Forms.Padding(2);
			this.TxtNombreDelAlumno.Name = "TxtNombreDelAlumno";
			this.TxtNombreDelAlumno.Size = new System.Drawing.Size(238, 20);
			this.TxtNombreDelAlumno.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(52, 209);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 19);
			this.label5.TabIndex = 27;
			this.label5.Text = "Fecha Actual";
			// 
			// LblAdignatura
			// 
			this.LblAdignatura.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAdignatura.Location = new System.Drawing.Point(52, 164);
			this.LblAdignatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblAdignatura.Name = "LblAdignatura";
			this.LblAdignatura.Size = new System.Drawing.Size(141, 19);
			this.LblAdignatura.TabIndex = 26;
			this.LblAdignatura.Text = "Asignatura o Submodulo";
			// 
			// LblEspecialidad
			// 
			this.LblEspecialidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblEspecialidad.Location = new System.Drawing.Point(52, 121);
			this.LblEspecialidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblEspecialidad.Name = "LblEspecialidad";
			this.LblEspecialidad.Size = new System.Drawing.Size(75, 19);
			this.LblEspecialidad.TabIndex = 25;
			this.LblEspecialidad.Text = "Especialidad";
			// 
			// LblGrado
			// 
			this.LblGrado.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblGrado.Location = new System.Drawing.Point(52, 83);
			this.LblGrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblGrado.Name = "LblGrado";
			this.LblGrado.Size = new System.Drawing.Size(75, 19);
			this.LblGrado.TabIndex = 24;
			this.LblGrado.Text = "Grado";
			// 
			// LblNombreAlumno
			// 
			this.LblNombreAlumno.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNombreAlumno.Location = new System.Drawing.Point(52, 41);
			this.LblNombreAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblNombreAlumno.Name = "LblNombreAlumno";
			this.LblNombreAlumno.Size = new System.Drawing.Size(127, 19);
			this.LblNombreAlumno.TabIndex = 23;
			this.LblNombreAlumno.Text = "Nomber De Alumno";
			// 
			// BoletaDeCalifi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 563);
			this.Controls.Add(this.lvTabla);
			this.Controls.Add(this.BtnSalir);
			this.Controls.Add(this.TxtPromedio);
			this.Controls.Add(this.LblPromedio);
			this.Controls.Add(this.TxtParcial3);
			this.Controls.Add(this.TxtParcial2);
			this.Controls.Add(this.TxtParcial1);
			this.Controls.Add(this.LblParcial3);
			this.Controls.Add(this.Parcial2);
			this.Controls.Add(this.LblParcial1);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.BtnRegistrar);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cmbSubmodulo);
			this.Controls.Add(this.cmbEspecialidad);
			this.Controls.Add(this.cmbGrado);
			this.Controls.Add(this.TxtNombreDelAlumno);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.LblAdignatura);
			this.Controls.Add(this.LblEspecialidad);
			this.Controls.Add(this.LblGrado);
			this.Controls.Add(this.LblNombreAlumno);
			this.Name = "BoletaDeCalifi";
			this.Text = "BoletaDeCalifi";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label LblNombreAlumno;
		private System.Windows.Forms.Label LblGrado;
		private System.Windows.Forms.Label LblEspecialidad;
		private System.Windows.Forms.Label LblAdignatura;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtNombreDelAlumno;
		private System.Windows.Forms.ComboBox cmbGrado;
		private System.Windows.Forms.ComboBox cmbEspecialidad;
		private System.Windows.Forms.ComboBox cmbSubmodulo;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button BtnRegistrar;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Label LblParcial1;
		private System.Windows.Forms.Label Parcial2;
		private System.Windows.Forms.Label LblParcial3;
		private System.Windows.Forms.TextBox TxtParcial1;
		private System.Windows.Forms.TextBox TxtParcial2;
		private System.Windows.Forms.TextBox TxtParcial3;
		private System.Windows.Forms.Label LblPromedio;
		private System.Windows.Forms.TextBox TxtPromedio;
		private System.Windows.Forms.Button BtnSalir;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvTabla;
	}
}
