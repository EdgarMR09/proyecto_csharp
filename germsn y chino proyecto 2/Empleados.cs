/*
 * Creado por SharpDevelop.
 * Usuario: miran
 * Fecha: 11/12/2025
 * Hora: 02:29 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace germsn_y_chino_proyecto_2
{
	/// <summary>
	/// Description of Empleados.
	/// </summary>
	public partial class Empleados : Form
	{
		string rutaImagen = "";
		public Empleados()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnActualizarFotoClick(object sender, EventArgs e)
		{
	OpenFileDialog abrir = new OpenFileDialog();
    abrir.Filter = "Imágenes|*.jpg;*.png;*.jpeg;*.bmp";

    if (abrir.ShowDialog() == DialogResult.OK)
    {
        rutaImagen = abrir.FileName;
        pictureBox1.Image = Image.FromFile(rutaImagen);
    }			
		}
		
		void BtnQuitarClick(object sender, EventArgs e)
		{
			pictureBox1.Image = null;
    rutaImagen = "";
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			   if (txtCodigo.Text == "" || txtNombre.Text == "")
    {
        MessageBox.Show("Complete los campos obligatorios.");
        return;
    }

    dataGridView1.Rows.Add(
        txtCodigo.Text,
        txtNombre.Text,
        cmbPuesto.Text,
        dtFecha.Value.ToShortDateString(),
        cmbSexo.Text,
        rbRegular.Checked ? "Regular" : "Contrato",
        rutaImagen
    );

    MessageBox.Show("Empleado guardado correctamente.");
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 0)
    {
        MessageBox.Show("Seleccione un registro para eliminar.");
        return;
    }

    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
    MessageBox.Show("Registro eliminado.");
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			 txtCodigo.Clear();
    txtNombre.Clear();
    cmbPuesto.SelectedIndex = -1;
    cmbSexo.SelectedIndex = -1;
    rbRegular.Checked = false;
    rbContrato.Checked = false;
    dtFecha.Value = DateTime.Today;

    pictureBox1.Image = null;
    rutaImagen = "";
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
    {
        DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

        txtCodigo.Text = fila.Cells[0].Value.ToString();
        txtNombre.Text = fila.Cells[1].Value.ToString();
        cmbPuesto.Text = fila.Cells[2].Value.ToString();
        dtFecha.Text = fila.Cells[3].Value.ToString();
        cmbSexo.Text = fila.Cells[4].Value.ToString();

        if (fila.Cells[5].Value.ToString() == "Regular")
            rbRegular.Checked = true;
        else
            rbContrato.Checked = true;

        string img = fila.Cells[6].Value.ToString();
        if (System.IO.File.Exists(img))
            pictureBox1.Image = Image.FromFile(img);
			}
		}
	}
}
