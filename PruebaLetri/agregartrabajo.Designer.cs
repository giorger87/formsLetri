﻿/*
 * Created by SharpDevelop.
 * User: Mi-PC
 * Date: 28/5/2018
 * Time: 7:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PruebaLetri
{
	partial class agregartrabajo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(29, 265);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(222, 117);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(205, 20);
			this.textBox3.TabIndex = 29;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(222, 91);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(205, 20);
			this.textBox2.TabIndex = 28;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(222, 65);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(205, 20);
			this.textBox1.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(29, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "Tipo Trabajo";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(29, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "Apellido";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(29, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Precio Final";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(222, 143);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(205, 20);
			this.textBox4.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 146);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 23);
			this.label1.TabIndex = 30;
			this.label1.Text = "Fecha";
			// 
			// agregartrabajo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 320);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Name = "agregartrabajo";
			this.Text = "agregartrabajo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
