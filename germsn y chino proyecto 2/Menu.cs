/*
 * Created by SharpDevelop.
 * User: CC1_PC49
 * Date: 10/12/2025
 * Time: 01:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace germsn_y_chino_proyecto_2
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.panelFactorial.Visible = false;
			this.panelfibonnaci.Visible = false;
			this.panelcuadrado.Visible=false;
			this.panelRectangu.Visible=false;
			this.panelTriangulo.Visible=false;
			this.panel1.Visible=false;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();			
		}
		
		void RegresarToolStripMenuItemClick(object sender, EventArgs e)
		{
			 this.Owner.Show();
    		 this.Close();			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int n;
   			if(!int.TryParse(txtNum.Text, out n) || n < 0)
    		{
        		MessageBox.Show("Ingresa un número entero y positivo.");
        		return;
    		}

    			long resultado = 1;
    			for(int i = 1; i <= n; i++)
    			{
        			resultado *= i;
    			}
			lblResult.Text = " El Factorial es: " + resultado;	
		}
	
		void FactorialToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.panelFactorial.Visible = true;
		}
		
		
		void FiboToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.panelfibonnaci.Visible = true;		
		}
		
		void BtnLimpiarFACTORIALClick(object sender, EventArgs e)
		{
			lblResult.Text="";
			txtNum.Text="";			
		}
		
		void BtnCalFibonnaciClick(object sender, EventArgs e)
		{
			int num;
			if (!int.TryParse(txtNumFibonnici.Text,out num) || num <= 0)
			{
				MessageBox.Show("Ingresa un numero entero mayor a 0");
				return;
			}
			int a=0,b=1,c;
			string serie="";
			for (int i=1; i<=num; i++)
			{
				serie += a+"";
				c=a+b;
				b=c;
			}
			lblResultFibonnaci.Text=" Resultado " + serie;
		}
		void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.panelcuadrado.Visible=true;
		}
		void RectanguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.panelRectangu.Visible=true;
		}
		void TrianguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.panelTriangulo.Visible=true;
		}
		void BtnlimpiarcuadradoClick(object sender, EventArgs e)
		{
			txtcuadradonum.Text="";
			lblResultadocuadra.Text="";
		}
		void BtnlimrectanguloClick(object sender, EventArgs e)
		{
			txtBaseRec.Text="";
			txtHalturaRec.Text="";
			lblresultRec.Text="";
		}
		void BtntriangulolimClick(object sender, EventArgs e)
		{
			txtTriangulob.Text="";
			txttrianguloh.Text="";
			lblresultadotriangulo.Text="";
		}
		void BtncalcuadradoClick(object sender, EventArgs e)
		{
			double L;
			
			if(double.TryParse(txtcuadradonum.Text, out L))
			{
				double area = L * L;
				lblResultadocuadra.Text="El area es: " + area;
			}			
		}
		void BtnreccalcularClick(object sender, EventArgs e)
		{
			double b, h;
			
			if(double.TryParse(txtBaseRec.Text, out b) &&
				double.TryParse(txtHalturaRec.Text, out h))
			{
				double area = b * h;
				lblresultRec.Text="El area es: " + area;
			}								
		}
		void BtnTrianguloClick(object sender, EventArgs e)
		{
			double b, h;
			
			if(double.TryParse(txtTriangulob.Text, out b) &&
				double.TryParse(txttrianguloh.Text, out h))
			{
				double area = b*h/2;
				lblresultadotriangulo.Text="El area es: " + area;
			}	
		}
		void AbrirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Boleta Boleta=new Boleta();
			Boleta.Show();
		}
		void AbrirToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Postres postres=new Postres();
			postres.Show();
		}
		void AbrirToolStripMenuItem2Click(object sender, EventArgs e)
		{
			Empleados emple=new Empleados();
			emple.Show();
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void PerimetroToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void CyuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.panel1.Visible=true;
		}
		void BtnLimpiarfibonnaciClick(object sender, EventArgs e)
		{
			txtNumFibonnici.Text="";
			lblResultFibonnaci.Text="";
			
		}
	}
}
