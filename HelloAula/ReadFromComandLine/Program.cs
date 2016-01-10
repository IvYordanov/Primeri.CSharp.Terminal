using System;

namespace ReadFromComandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на параметри
			int a = 5, b = 0;

			//Въвеждане на фходни параметри
			Console.WriteLine ("Моля въведете а:  ");
			b = Convert.ToInt32 (Console.ReadLine ());


			//Печатане на резултат

			Console.WriteLine ("Резултата  (a+b) е:  " + (a + b).ToString () + "\n\n\n\n");

			string test = "1";
			test += ",2";
			test += ",100";
			test += ",4";
			test += ",5";
			Console.WriteLine ("Събиране  с +=  :  " + test + "\n");
			// Заместване на символите , ;
			test = test.Replace (",", ";");
			Console.WriteLine ("Работа с Replace: "+test+"\n");
			Console.WriteLine ("Третия знак е: " + test.Split(';')[2]);


		}
	}
}
