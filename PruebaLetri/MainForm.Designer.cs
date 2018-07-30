/*
 * Created by SharpDevelop.
 * User: Mi-PC
 * Date: 9/3/2018
 * Time: 6:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PruebaLetri
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Buscar;
		private System.Windows.Forms.Button Agregar;
		private System.Data.DataSet dataSet1;
		public System.Windows.Forms.DataGridView TablaMain;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button Limpiar;
		private System.Windows.Forms.Button Borrar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button crear;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Buscar = new System.Windows.Forms.Button();
			this.Agregar = new System.Windows.Forms.Button();
			this.dataSet1 = new System.Data.DataSet();
			this.TablaMain = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.Limpiar = new System.Windows.Forms.Button();
			this.Borrar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.crear = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TablaMain)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Buscar
			// 
			this.Buscar.Location = new System.Drawing.Point(3, 37);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(125, 40);
			this.Buscar.TabIndex = 0;
			this.Buscar.Text = "Buscar";
			this.Buscar.UseVisualStyleBackColor = true;
			this.Buscar.Click += new System.EventHandler(this.Button1Click);
			// 
			// Agregar
			// 
			this.Agregar.Location = new System.Drawing.Point(576, 37);
			this.Agregar.Name = "Agregar";
			this.Agregar.Size = new System.Drawing.Size(125, 40);
			this.Agregar.TabIndex = 1;
			this.Agregar.Text = "Agregar Cliente";
			this.Agregar.UseVisualStyleBackColor = true;
			this.Agregar.Click += new System.EventHandler(this.Button2Click);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			// 
			// TablaMain
			// 
			this.TablaMain.AllowUserToAddRows = false;
			this.TablaMain.AllowUserToDeleteRows = false;
			this.TablaMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TablaMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TablaMain.Location = new System.Drawing.Point(0, 0);
			this.TablaMain.Name = "TablaMain";
			this.TablaMain.ReadOnly = true;
			this.TablaMain.RowHeadersVisible = false;
			this.TablaMain.Size = new System.Drawing.Size(943, 179);
			this.TablaMain.TabIndex = 2;
			this.TablaMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaMainCellContentClick);
			this.TablaMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaMainCellDoubleClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(134, 57);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(131, 20);
			this.textBox1.TabIndex = 3;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Apellido",
			"ID"});
			this.comboBox1.Location = new System.Drawing.Point(134, 30);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(131, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// Limpiar
			// 
			this.Limpiar.Location = new System.Drawing.Point(427, 37);
			this.Limpiar.Name = "Limpiar";
			this.Limpiar.Size = new System.Drawing.Size(143, 40);
			this.Limpiar.TabIndex = 5;
			this.Limpiar.Text = "Limpiar Lista";
			this.Limpiar.UseVisualStyleBackColor = true;
			this.Limpiar.Click += new System.EventHandler(this.Button3Click);
			// 
			// Borrar
			// 
			this.Borrar.Location = new System.Drawing.Point(278, 37);
			this.Borrar.Name = "Borrar";
			this.Borrar.Size = new System.Drawing.Size(143, 40);
			this.Borrar.TabIndex = 6;
			this.Borrar.Text = "Borrar Cliente";
			this.Borrar.UseVisualStyleBackColor = true;
			this.Borrar.Click += new System.EventHandler(this.BorrarClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(707, 37);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 40);
			this.button1.TabIndex = 7;
			this.button1.Text = "Guardar Información";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button4Click);
			// 
			// crear
			// 
			this.crear.Location = new System.Drawing.Point(12, 12);
			this.crear.Name = "crear";
			this.crear.Size = new System.Drawing.Size(125, 23);
			this.crear.TabIndex = 8;
			this.crear.Text = "Cargar Datos";
			this.crear.UseVisualStyleBackColor = true;
			this.crear.Click += new System.EventHandler(this.CargarDatosClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.TablaMain);
			this.panel1.Location = new System.Drawing.Point(3, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(943, 179);
			this.panel1.TabIndex = 9;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.Buscar);
			this.panel2.Controls.Add(this.Agregar);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.comboBox1);
			this.panel2.Controls.Add(this.Borrar);
			this.panel2.Controls.Add(this.Limpiar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 234);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(961, 89);
			this.panel2.TabIndex = 10;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 323);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.crear);
			this.Name = "MainForm";
			this.Text = "Control de Clientes Letrigraf";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TablaMain)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
