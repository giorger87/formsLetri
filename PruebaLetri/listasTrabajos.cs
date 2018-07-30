/*
 * Created by SharpDevelop.
 * User: Mi-PC
 * Date: 23/4/2018
 * Time: 7:02 p. m.
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
	/// Description of listasTrabajos.
	/// </summary>
	public partial class listasTrabajos : Form
	{
		public	DataSet dataset1= new DataSet("miDataSet");
		public DataSet datasave= new DataSet("datasave");
		BindingSource bindingSource1= new BindingSource();
		
		public listasTrabajos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		public	DataTable Trabajos= new DataTable("Trabajos");
		
		void Button2Click(object sender, EventArgs e)
		{
			agregartrabajo agregar= new agregartrabajo();
			
			agregar.FormClosing+=Agregador;
			agregar.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
	
		}
		void Agregador(object sender, EventArgs e)
		{
			
			if (ObjAux.agretrab) {
			//try {
				
			//} catch (Exception) {
				
			//	throw;
			//}	
			
			dataGridView1.DataSource=Trabajos;
			Trabajos.Merge(ObjAux.FilaNueva);
			dataGridView1.DataSource=Trabajos;
			datasave.WriteXml("datatrab.xml");
			MessageBox.Show("XML generado!");
			bindingSource1.DataSource=Trabajos;
			dataGridView1.DataSource= bindingSource1;
			}
		}
		void ListasTrabajosLoad(object sender, EventArgs e)
		{
			dataset1.ReadXml("datatrab.xml");
			dataGridView1.DataSource=Trabajos;
			bindingSource1.DataSource=dataset1.Tables[0];
			bindingSource1.Filter= "Apellido = '" + ObjAux.ClienteInfo+"'";
			
			dataGridView1.DataSource= bindingSource1;
			
			Trabajos=dataset1.Tables[0].Clone();
			Trabajos= dataset1.Tables[0].Copy();
			datasave.Tables.Add(Trabajos);
			
		}
	}
}
