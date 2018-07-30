/*
 * Created by SharpDevelop.
 * User: Mi-PC
 * Date: 11/07/2018
 * Time: 15:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PruebaLetri
{
	/// <summary>
	/// Description of VentanaComentarios.
	/// </summary>
	public partial class VentanaComentarios : Form
	{
		public VentanaComentarios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void VentanaComentariosLoad(object sender, EventArgs e)
		{
			this.FormClosing+=Cerrando;//estan pasando al reves
			textBox1.Text=ObjAux.Coment;
			BringToFront();
		}
		void Cerrando(object sender, EventArgs e)
		{
			ObjAux.Coment= textBox1.Text;
		}
	}
}
