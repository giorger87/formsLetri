/*
 * Created by SharpDevelop.
 * User: Mi-PC
 * Date: 9/3/2018
 * Time: 7:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Xml;
using System.IO;
namespace PruebaLetri
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	
	public partial class Form1 : Form
	{
		DataTable nuecliente= new DataTable("nuevo");
		
				
		public Form1()
		{	Text="Agregar Cliente Nuevo";
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//Tengo que hacer que cuando creo un nuevo cliente, se cree una tabla nueva con el tipo de trabajo y la fecha, 
			// con el nombre de archivo relacionado con el apellido del cliente
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			nuecliente.Columns.Add("idCliente", typeof (string));
			nuecliente.Columns.Add("Apellido", typeof (string));
			nuecliente.Columns.Add("Nombre", typeof (string));
			nuecliente.Columns.Add("Dirección", typeof (string));
			nuecliente.Columns.Add("Teléfono", typeof (string));
			nuecliente.Columns.Add("Mail",typeof(string));
			nuecliente.Columns.Add("Cuit", typeof (string));
			nuecliente.Columns.Add("Trabajo Habitual", typeof (string));
			nuecliente.Columns.Add("Trabajos", typeof (string));
			nuecliente.Columns.Add("Comentarios", typeof (string));
			textBox1.KeyDown+=Siguiente;
			textBox2.KeyDown+=Siguiente;
			textBox3.KeyDown+=Siguiente;
			textBox4.KeyDown+=Siguiente;
			textBox7.KeyDown+=Siguiente;
			textBox5.KeyDown+=Siguiente;
			textBox6.KeyDown+=Siguiente;
			textBox9.KeyDown+=Siguiente;
			textBox8.KeyDown+=Aceptar;
			
			
		}
		DataSet dsAux= new DataSet();
		void Form1Load(object sender, EventArgs e)
		{
			
			
			dsAux.Tables.Add(nuecliente);
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{	
			
				
				DataRow fila= nuecliente.NewRow();
				if (ObjAux.act==0) {
					fila[0]= Convert.ToInt32(ObjAux.ContadorClientes) +1;
				}
				else
				{
					fila[0]= Convert.ToInt32(ObjAux.act) +1;
				}
				
				fila[1]= textBox1.Text;
				fila[2]= textBox2.Text;
				fila[3]= textBox3.Text;
				fila[4]= textBox4.Text;
				fila[5]= textBox7.Text;
				fila[6]= textBox5.Text;
				fila[7]= textBox6.Text;
				fila[8]= textBox9.Text;
				fila[9]= textBox8.Text;
				nuecliente.Rows.Add(fila);
				ObjAux.ContadorClientes=Convert.ToString(Convert.ToInt32(ObjAux.ContadorClientes)+1);
				ObjAux.act++;
				ObjAux.FilaNueva=nuecliente.Copy();
				TablaNue.DataSource= nuecliente;
				
				textBox1.Clear();
				textBox2.Clear();
				textBox3.Clear();
				textBox4.Clear();
				textBox5.Clear();
				textBox6.Clear();
				textBox7.Clear();
				textBox8.Clear();
				textBox9.Clear();
				textBox1.Focus();
				
			
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
	
		}
		void Siguiente(object sender, KeyEventArgs e)
		{	
			if((int)e.KeyCode == (int)Keys.Enter){
				e.SuppressKeyPress = true;
				GetNextControl(sender as Control,true).Focus();
			}
			
		 }
		void Aceptar(object sender, KeyEventArgs e)
		{
			if((int)e.KeyCode == (int)Keys.Enter){
				e.SuppressKeyPress = true;
				Button1Click(this,e);
			}
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void Form1Shown(object sender, EventArgs e)
		{
			textBox1.Focus();
		}
		
	}
}
