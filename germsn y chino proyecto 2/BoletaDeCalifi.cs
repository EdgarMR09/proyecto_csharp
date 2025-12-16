/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC48
 * Fecha: 15/12/2025
 * Hora: 06:26 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace germsn_y_chino_proyecto_2
{



    public partial class BoletaDeCalifi : Form
    {
        public BoletaDeCalifi()
        {
            InitializeComponent();  
            ConfigurarTabla();  
        }




        void ConfigurarTabla()
        {
            if (lvTabla != null)  
            {
                lvTabla.Clear();
                lvTabla.View = View.Details;
                lvTabla.FullRowSelect = true;
                lvTabla.GridLines = true;

                lvTabla.Columns.Add("Nombre", 150);
                lvTabla.Columns.Add("Asignatura", 120);
                lvTabla.Columns.Add("Parcial 1", 80);
                lvTabla.Columns.Add("Parcial 2", 80);
                lvTabla.Columns.Add("Parcial 3", 80);
                lvTabla.Columns.Add("Promedio", 80);
                lvTabla.Columns.Add("Resultado", 100);
            }
            else
            {
                MessageBox.Show("El control ListView no está inicializado correctamente.");
            }
        }




        void BtnRegistrarClick(object sender, EventArgs e)
        {
            if (TxtNombreDelAlumno.Text == "" ||
                cmbSubmodulo.SelectedIndex == -1 ||
                cmbGrado.SelectedIndex == -1 ||
                cmbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los datos");
                return;
            }

            double p1, p2, p3;

            if (!double.TryParse(TxtParcial1.Text, out p1) ||
                !double.TryParse(TxtParcial2.Text, out p2) ||
                !double.TryParse(TxtParcial3.Text, out p3))
            {
                MessageBox.Show("Ingrese solo números en los parciales");
                return;
            }

            double promedio = (p1 + p2 + p3) / 3;
            string resultado = promedio >= 6 ? "Aprobado" : "Reprobado";

            ListViewItem fila = new ListViewItem(TxtNombreDelAlumno.Text);
            fila.SubItems.Add(cmbSubmodulo.Text);
            fila.SubItems.Add(p1.ToString("0.0"));
            fila.SubItems.Add(p2.ToString("0.0"));
            fila.SubItems.Add(p3.ToString("0.0"));
            fila.SubItems.Add(promedio.ToString("0.0"));
            fila.SubItems.Add(resultado);

            lvTabla.Items.Add(fila);

            TxtPromedio.Text = promedio.ToString("0.0");
        }




        void LvTablaSelectedIndexChanged(object sender, EventArgs e)
        {

        }




        void BtnCancelarClick(object sender, EventArgs e)
        {
            TxtParcial1.Clear();
            TxtParcial2.Clear();
            TxtParcial3.Clear();
            TxtPromedio.Clear();
            TxtNombreDelAlumno.Clear();

            cmbSubmodulo.SelectedIndex = -1;
            cmbGrado.SelectedIndex = -1;
            cmbEspecialidad.SelectedIndex = -1;

            TxtParcial1.Focus();
        }




        void BtnSalirClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
