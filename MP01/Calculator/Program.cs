using System;

namespace Calculator
{
	class MainClass
	{
		//Дефиниране на библиотеки
		public UserInput.UInput UInput = new UserInput.UInput ();
		public About.Me about = new About.Me ();


		public static void Main (string[] args)
		{
          	MainClass _program = new MainClass ();

			//Форматиране
			Console.Title = _program.about.shortName + ", " + _program.about.version;


			//Стартиране на програмата
			_program.UInput.sayHello ();
			_program.UInput.getUserCommands ();

		}
	}
}
