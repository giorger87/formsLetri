/*
 * Created by SharpDevelop.
 * User: Mi-PC
 * Date: 9/3/2018
 * Time: 7:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PruebaLetri
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView TablaNue;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.TablaNue = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TablaNue)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Apellido";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Dirección";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(21, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Teléfono";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(122, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Cuit";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(21, 165);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Trabajo Habitual";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.textBox8);
			this.panel1.Controls.Add(this.textBox9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.textBox7);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.textBox6);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 281);
			this.panel1.TabIndex = 20;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(214, 214);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(205, 20);
			this.textBox8.TabIndex = 17;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(214, 188);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(205, 20);
			this.textBox9.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(21, 217);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(122, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Comentarios";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(21, 191);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(122, 23);
			this.label9.TabIndex = 7;
			this.label9.Text = "Fecha Ult. Trabajo";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(214, 110);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(205, 20);
			this.textBox7.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(21, 113);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(122, 23);
			this.label7.TabIndex = 4;
			this.label7.Text = "Mail";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(214, 162);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(205, 20);
			this.textBox6.TabIndex = 15;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(214, 136);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(205, 20);
			this.textBox5.TabIndex = 14;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(214, 84);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(205, 20);
			this.textBox4.TabIndex = 12;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(214, 58);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(205, 20);
			this.textBox3.TabIndex = 11;
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(214, 32);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(205, 20);
			this.textBox2.TabIndex = 10;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(214, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(205, 20);
			this.textBox1.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 299);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 38);
			this.button1.TabIndex = 18;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// TablaNue
			// 
			this.TablaNue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TablaNue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TablaNue.Location = new System.Drawing.Point(12, 343);
			this.TablaNue.Name = "TablaNue";
			this.TablaNue.Size = new System.Drawing.Size(663, 82);
			this.TablaNue.TabIndex = 19;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 437);
			this.Controls.Add(this.TablaNue);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Agregar Cliente";
			this.Load += new System.EventHandler(this.Form1Load);
			this.Shown += new System.EventHandler(this.Form1Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TablaNue)).EndInit();
			this.ResumeLayout(false);

		}
		}
	}
