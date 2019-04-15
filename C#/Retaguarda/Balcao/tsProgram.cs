using System;
using System.Windows.Forms;

namespace Balcao
{
	static class tsProgram
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main( string[] args )
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new Balcao.View.FMenu() );
		}
	}
}