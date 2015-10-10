using System;

namespace UserInput
{
	public class UInput
	{
		About.Me about = new About.Me ();
		Colors.ForCLI _c = new Colors.ForCLI ();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary ();

		public UInput ()
		{
		}


		public void sayHello ()
		{
			_c.Default ();
			Console.WriteLine ("Dobri doshli v " + about.shortName + "\n" + about.version + "\n");

		}

		public void getUserCommands ()
		{
			string _command = "";

			do
			{
				//Взимане на команда
				_c.Prompt ();    Console.Write ("$ ");
				_c.Command ();    _command = Console.ReadLine ();

				//Проверка за налични команди
				if (_command.ToLower().Contains ( "qma" ) )	 	_calc.F01.calc ( _command );
				if (_command.ToLower().Contains ( "vugul" ) )	_calc.F02.calc ( _command );
				if (_command.ToLower().Contains ( "iugul" ) )	_calc.F03.calc ( _command );

				if (_command.ToLower().Contains ( "pomosht" ) ||
					_command.ToLower() == "p"  )				_calc.commands ();

				if ( _command.ToLower() == "izchisti" ||
					 _command.ToLower() == "i"  )
				{
					Console.Clear ();

					_c.Default ();
					Console.WriteLine ("Dobri doshli v " + about.shortName + "\n" + about.version + "\n");
				}

			}while (_command.ToLower () != "izhod" );
		}


		public void justTesting ()
		{
			Console.WriteLine ( "Startirane na  UserInput.UInput.justTesting ()");
		}
	}
}

