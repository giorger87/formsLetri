/*
 * Created by SharpDevelop.
 * User: Mi-PC
 * Date: 9/3/2018
 * Time: 6:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Data;

namespace PruebaLetri
{
	public static class ObjAux{
		public static string BaseDatos{get;set;}
		public static string ContadorClientes{get;set;}
		public static DataTable FilaNueva{get;set;}
		public static string Borrar{get;set;}
		public static int act{get;set;}
		public static string ClienteInfo{get;set;}
		public static int clitrab{get;set;}
		public static bool agretrab{get;set;}
		public static string Coment{get;set;}
		
	}
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			ObjAux.BaseDatos="C:\\Users\\Mi-PC\\Documents\\SharpDevelop Projects\\PruebaLetri\\PruebaLetri\\base.xml";
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
