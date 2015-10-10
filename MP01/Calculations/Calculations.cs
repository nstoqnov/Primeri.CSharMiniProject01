using System;

namespace Calculations
{
	public class MainLibrary
	{
		//Дефиниции
		public Formula01 F01 = new Formula01 ();
		public Formula02 F02 = new Formula02 ();
		public Formula03 F03 = new Formula03 ();
		public Formula04 F04 = new Formula04 ();
		public Formula05 F05 = new Formula05 ();

		//Библиотеки за цветове
		private Colors.ForCLI _cl = new Colors.ForCLI ();

		public MainLibrary ()
		{
		}

		public void commands ()
		{
			_cl.Default (); Console.WriteLine ("Nalichni komandi.\n");

			_cl.Command ();	Console.Write ( "[qma]" );
			_cl.Default (); Console.WriteLine (" - presmqtane na stroitelna qma.");

			_cl.Command ();	Console.Write ( "[vugul]" );
			_cl.Default (); Console.WriteLine (" - presmqtane na vdlubnat ugul.");

			_cl.Command ();	Console.Write ( "[iugul]" );
			_cl.Default (); Console.WriteLine (" - presmqtane na izpuknal ugul.");

			_cl.Command ();	Console.Write ( "[sugul]" );
			_cl.Default (); Console.WriteLine (" - presmqtane na stranichen ugul.");

			_cl.Command ();	Console.Write ( "[kizkop]" );
			_cl.Default (); Console.WriteLine (" - presmqtane na kanalen izkop.\n");


		}
	}
}

