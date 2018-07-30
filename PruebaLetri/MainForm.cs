/*
 * Created by SharpDevelop.
 * User: Mi-PC
 * Date: 9/3/2018
 * Time: 6:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace PruebaLetri
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public partial class MainForm : Form
	{
		public	DataSet dataset1= new DataSet("miDataSet");
		BindingSource bindingSource1= new BindingSource();
		public DataSet datasave= new DataSet("Guardador");
		
		public MainForm()
		{
			//el boton cargar datos carga aunque ya esten cargados!!!
			//FECHA VENCIMIENTO TALONARIO y CONTROL DE VENCIMIENTOS 15 DIAS ANTES
			//COMBOBOX DE FECHAS EN LA LISTA
			//CONTROLAR EL GUARDAR DESPUES DE BORRAR O AGREGAR
			//ARREGLAR LO DEL TELEFONO OBLIGATORIO
			//AGREGAR CAMPO CUIT
			//AGREGAR CAMPO TRABAJO HABITUAL
			//AGREGAR EL EDITAR CUANDO BUSCO
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
			
				
			
			dataset1.ReadXml("dataclien3.xml");
            TablaMain.DataSource= dataset1.Tables[0];
			
			clientes.Columns.Add("idCliente", typeof (Int32));
			clientes.Columns.Add("Apellido", typeof (string));
			clientes.Columns.Add("Nombre", typeof (string));
			clientes.Columns.Add("Dirección", typeof (string));
			clientes.Columns.Add("Teléfono", typeof (string));
			clientes.Columns.Add("Mail",typeof(string));
			clientes.Columns.Add("Cuit", typeof (string));
			clientes.Columns.Add("Trabajo Habitual", typeof (string));
			clientes.Columns.Add("Trabajos", typeof (string));
			clientes.Columns.Add("Comentarios", typeof (string));
			
			
			TablaMain.Visible=true;
			
			ObjAux.ContadorClientes= Convert.ToString(clientes.Rows.Count);
		}
		
		public	DataTable clientes= new DataTable("Clientes");
		public int Buscarnum(int max){
			max= 0;
			for (int i = 0; i < TablaMain.Rows.Count; i++) {
				if (Convert.ToInt32(TablaMain.Rows[i].Cells[0].Value)> max) {
					max= Convert.ToInt32(TablaMain.Rows[i].Cells[0].Value);
				}
				
			}
			return max;
		}
		
		void MainFormLoad(object sender, EventArgs e){
			
			
			 
			 
			
			 //al pedo hacer un DATACLIENTE si lo uso una sola vez
			 clientes=dataset1.Tables[0].Clone();
			 clientes= dataset1.Tables[0].Copy();
			 ObjAux.ContadorClientes= Convert.ToString(clientes.Rows.Count);
			 ObjAux.act=Buscarnum(0);
			 string datos= "C:\\Users\\Mi-PC\\Documents\\SharpDevelop Projects\\PruebaLetri\\PruebaLetri\\base.xml";
			//HACER UN OPEN FILE DIALOG OPCIONAL
			textBox1.KeyDown+=Button1Click;
			
		}
		void Button2Click(object sender, EventArgs e)
		{//agregar cliente
			
			ObjAux.act=Buscarnum(0);
			Form1 Agregar= new Form1();
			Agregar.FormClosing+=MostrarTabla;
			Agregar.Name= "Agregar Nuevo Cliente";
			Agregar.Show();
			
		}
		void MostrarTabla(object sender, EventArgs e)
		{
			TablaMain.Visible=true;
			if (ObjAux.FilaNueva!=null) {
				
				
				TablaMain.DataSource=clientes;
				clientes.Merge(ObjAux.FilaNueva);
				ObjAux.act=Buscarnum(0);
				Button4Click(this, e);
			 
			}
		}
		void Button1Click(object sender, EventArgs e)//agrego solo uno, al segundo no lo guarda !!
		{//buscar
			//busqueda por apellido
			TablaMain.DataSource= clientes;
			ObjAux.act=Buscarnum(0);
			try{
			if (comboBox1.SelectedIndex==0) {
				bindingSource1.DataSource=TablaMain.DataSource;
				bindingSource1.Filter= "Apellido LIKE '"+textBox1.Text+"%'";
				
			
				TablaMain.ReadOnly=false;
				if (TablaMain.Rows.Count==0) {
					MessageBox.Show("No se encontró el cliente");
					bindingSource1.Filter= "";
				}
			}else{
			if (comboBox1.SelectedIndex==1) {
				bindingSource1.DataSource=TablaMain.DataSource;
				
				bindingSource1.Filter= "idCliente LIKE '"+Convert.ToInt32(textBox1.Text)+"%'";
				TablaMain.ReadOnly=false;
				if (TablaMain.Rows.Count==0) {
					MessageBox.Show("No se encontró el cliente");
					 bindingSource1.Filter= "";
				}
			}
				}
			}
			catch{}
			
		}
		void Button3Click(object sender, EventArgs e)
		{//limpiar lista
			ObjAux.act=Buscarnum(0);
			int end =TablaMain.Rows.Count;
			
			try {for (int i=0; i<end; i++) {
				TablaMain.Rows.Remove(TablaMain.CurrentRow);
				}
					
				} catch (ArgumentNullException) {
				MessageBox.Show("La lista esta vacia!");
				}
			
		}
		void BorrarClick(object sender, EventArgs e)
		{//borrar cliente
			int num;
			Form2 BorrarCliente= new Form2();
			BorrarCliente.Text="Borrar Cliente";
			BorrarCliente.ShowDialog();
			if (BorrarCliente.DialogResult== DialogResult.OK){
				bool res=Int32.TryParse(ObjAux.Borrar, out num);
				if (res) {
					for (int i = 0; i < clientes.Rows.Count; i++) {
						
						if(Convert.ToString(TablaMain.Rows[i].Cells[0].Value)== ObjAux.Borrar){
							try {clientes.Rows.RemoveAt(i);
								TablaMain.Rows.RemoveAt(i);
								break;
							} catch (Exception) {}
							
						}
					}
				}else{
					for (int i = 0; i < clientes.Rows.Count; i++) {
						
						if(Convert.ToString(TablaMain.Rows[i].Cells[1].Value)== ObjAux.Borrar){
							try {clientes.Rows.RemoveAt(i);
								TablaMain.Rows.RemoveAt(i);
								break;
							} catch (Exception) {}
						}
					}
				}
			}
			ObjAux.act=Buscarnum(0);
		}
		void Button4Click(object sender, EventArgs e)
		{//guardar datos
			try {
				
				MessageBox.Show(Convert.ToString(clientes.Rows.Count));
				 //solo guarda una vez!!!
				clientes.WriteXml("dataclien3.xml");
				MessageBox.Show("XML generado!");
			} catch (System.ArgumentException) {
				
				MessageBox.Show("Ya Están Guardados los Datos!");
			}
		}
		void CargarDatosClick(object sender, EventArgs e)
		{
			Button3Click(this,e);
            dataset1.ReadXml("dataclien3.xml");
            TablaMain.DataSource= dataset1.Tables[0];
		
	}
		
		void TablaMainCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if (TablaMain.CurrentCell.ColumnIndex==6){//filtro de columna
			listasTrabajos tablaFechas= new listasTrabajos();
			
			ObjAux.ClienteInfo=TablaMain.CurrentRow.Cells[1].Value.ToString();
			tablaFechas.Text="Trabajos "+ ObjAux.ClienteInfo;
			tablaFechas.Show();}
			else//hacer el else par el editado de celdas
			{if (TablaMain.CurrentCell.ColumnIndex==7) {
					VentanaComentarios Comentarios= new VentanaComentarios();
					Comentarios.FormClosed+=ControldeCambio;
					
					ObjAux.Coment= TablaMain.CurrentCell.Value.ToString();
					Comentarios.Show();
					
					
			}}
		}	
		void ControldeCambio(object sender, EventArgs e)
		{
			if (ObjAux.Coment!= TablaMain.CurrentCell.Value.ToString()) {
				
				
						TablaMain.CurrentCell.Value=ObjAux.Coment;
						//dataset1.Tables[0].Rows[TablaMain.CurrentRow.Index][7]=ObjAux.Coment;
						dataset1.WriteXml("dataclien3.xml");
						
						
					}
		
		}
		void Busqueda(object sender, EventArgs e){
		
			
		}
		void TablaMainCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		public class DataCliente: DataTable{
		
		public DataCliente(string nombre){
			this.TableName= nombre;
			
			}
		}
}
}