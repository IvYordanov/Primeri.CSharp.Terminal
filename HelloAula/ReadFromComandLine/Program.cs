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
			Console.WriteLine ("Третия знак е: " + test.Split(';')[2]+"\n\n");


			//Задача №1
			/*Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World". 
			 * Декларирайте променлива от тип object и й присвоете стойността на конкатенацията на двете променливи от тип string
			 * (не изпускайте интервала по средата).
			 * Декларирайте трета променлива от тип string
			 * и я инициализирайте със стойността на променливата от тип object. ( Hint: Трябва да използвате type casting.)
           */
			string first = "Hello",second="World!";
			object all = first +" "+ second;
			//string third = all;
			Console.WriteLine (all+"\n\n");
			//Задачата не е решена СЛЕДВА ПРОДЪЛЖЕНИЕ!!!!!

			//Задача№2
			/*Да се въведат от командния ред 1 число или цифра и 1 дума/стринг.
			 * След това да изведе дължината на получения стринг при конкатенация,
			 * тоест броя на символите в новополучения стринг при конкатенация.
			 * (Hint: Трябва да преобразувате int към String и след това да конкатениратe.)
			 */
			Console.Write (" Enter number: ");
			int number = Convert.ToInt32 (Console.ReadLine ());
			Console.Write (" Enter word: ");
			string word = Console.ReadLine ();
			string conc = Convert.ToString (number);
			string arr = number + word; 
			Console.WriteLine (arr);
			Console.WriteLine (" Брой символи:  "+arr.Length+"\n\n");
			//Задачата е решена





		}
	}
}
