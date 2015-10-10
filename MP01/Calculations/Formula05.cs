using System;

namespace Calculations
		{
	/// <summary>
	/// Клас за формула за канален изкоп. ( Формула 5 )</summary>
			public class Formula05
			{
				private Colors.ForCLI _cl = new Colors.ForCLI ();

				public Formula05 ()
				{
				}
				//Формула за страничен ъгъл
				public void calc ( string _input )
				{
					try{
						string[] param = _input.Split (' ');

						if ( param.Length > 1 && _input.ToLower().Contains ("-p") )
						{
							help ();

						}
						if ( param.Length == 5 )
						{
							double result = 0;
							if ( runCalculate  (param, out result) )
							{
								_cl.Default (); 	Console.Write ("Obemut na kanalniq izkop e: ");
								_cl.Result ();  	Console.Write (result.ToString ("N2") );
								_cl.Default (); 	Console.WriteLine ( " m3\n" );

							} else{
								_cl.Default ();     Console.WriteLine ("Vuveden e greshen parametur. S parametura '-p', mojete\n da vidite sintaksisa na komandata.\n");
							}

						}


					}catch{
					}


				}

				private bool runCalculate (string[] _param, out double _result)
				{
					try
					{
						double a = 0; Double.TryParse ( _param[1], out a);
						double b = 0; Double.TryParse ( _param[2], out b);
						double h = 0; Double.TryParse ( _param[3], out h);
						double l = 0; Double.TryParse ( _param[4], out l);

						_result = ( a + b ) / h * l;

						return true;
					}catch{
					}


					_result = 0;

					return false;
				}

				private void help ()
				{
					_cl.Result ();		Console.Write ("[kizkop]");
					_cl.Default (); 	Console.WriteLine (" - kanalen izkop.");

					_cl.Command (); 	Console.Write ("parametri: ");
					_cl.Default (); 	Console.WriteLine (" a, b, h i l\n");

					_cl.Command (); 	Console.Write ("a i b");
					_cl.Default (); 	Console.WriteLine (" - shirina na profila i visochina.");

					_cl.Command (); 	Console.Write ("h");
					_cl.Default (); 	Console.WriteLine (" - visochina");

					_cl.Command (); 	Console.Write ("l");
					_cl.Default (); 	Console.WriteLine (" - duljina");
				}
			}
		}
	
