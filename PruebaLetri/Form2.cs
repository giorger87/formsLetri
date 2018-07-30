/*
 * Created by SharpDevelop.
 * User: Mi-PC
 * Date: 21/3/2018
 * Time: 1:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PruebaLetri
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{//aceptar
			
			ObjAux.Borrar= textBox1.Text;
			DialogResult= DialogResult.OK;
		}
		void Button2Click(object sender, EventArgs e)
		{//cancelar
			DialogResult= DialogResult.Cancel;
		}
	}
}
