/*
 * Created by SharpDevelop.
 * User: Mi-PC
 * Date: 28/5/2018
 * Time: 7:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace PruebaLetri
{
	/// <summary>
	/// Description of agregartrabajo.
	/// </summary>
	public partial class agregartrabajo : Form
	{
		DataTable nuetrabajo= new DataTable("TrabajoNuevo");
		public agregartrabajo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			nuetrabajo.Columns.Add("Apellido", typeof (string));
			nuetrabajo.Columns.Add("Tipo", typeof (string));
			nuetrabajo.Columns.Add("Precio", typeof (string));
			nuetrabajo.Columns.Add("Fecha", typeof (string));
			textBox1.Text= ObjAux.ClienteInfo;
			textBox4.Text= Convert.ToString(DateTime.Now);
			ObjAux.agretrab= false;
			
		}
		void Button1Click(object sender, EventArgs e)
		{
				DataRow fila= nuetrabajo.NewRow();
				fila[0]= textBox1.Text;
				fila[1]= textBox2.Text;
				fila[2]= textBox3.Text;
				fila[3]= Convert.ToString(DateTime.Now);
				nuetrabajo.Rows.Add(fila);
				ObjAux.FilaNueva=nuetrabajo.Copy();
				
				textBox1.Text= ObjAux.ClienteInfo;
				textBox2.Clear();
				textBox3.Clear();
				textBox4.Clear();
				textBox2.Focus();
				ObjAux.agretrab= true;
				Close();
				
		}
	}
}
