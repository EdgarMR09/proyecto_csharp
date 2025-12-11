/*
 * Created by SharpDevelop.
 * User: CC1_PC49
 * Date: 10/12/2025
 * Time: 12:58 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace germsn_y_chino_proyecto_2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int intentos = 3;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			txtUsuario.Text="";
			txtContraseña.Text="";			
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			string usuarioCorrecta = "Admin";
            string contraseñaCorrecta = "1234";

            if (txtUsuario.Text == usuarioCorrecta && txtContraseña.Text == contraseñaCorrecta)
            {
                MessageBox.Show("Bienvenido", "Acceso Correcto");

                Menu principal = new Menu();
                principal.Owner = this;
                principal.Show();

                this.Hide();
            }
            else
            {
                intentos--;
                MessageBox.Show("Usuario o Contraseña incorrectos.\nIntentos restantes: " + intentos, 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (intentos == 0)
                {
                    MessageBox.Show("Se acabaron los intentos. La aplicación se cerrará.");
                    Application.Exit();
                }
            }
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
