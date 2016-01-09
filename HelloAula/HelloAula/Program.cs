using System;

namespace HelloAula
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			                     // Примери от модул 02 AULA
			
		                                                        	// Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;

		                                                          	// Събиране на числа
			a = 10;
			b = 5;
			sum = a + b;
			                                                        // Печатане в конзолата
			Console.Write (a);
			Console.Write ("+");
			Console.Write (b);
			Console.Write ("=");
			Console.WriteLine (sum);
			//Допълнителни оператори
			Console.Write("\n Използване на += ");
			a += a;                                                 //a=10+5 ,a=a+b;
			Console.WriteLine (a);
			Console.Write("\n Използване на -= ");
			a -= a;
			Console.WriteLine (a);
			Console.Write("\n Използване на *= ");
			a *= a;
			Console.WriteLine (a);
			Console.Write("\n Използване на ++ ");
			a ++;
			Console.WriteLine (a);
			Console.WriteLine ("Стандартно делене: " + (7 / 3).ToString ()); //->2(7/3=2.3333)
			Console.WriteLine ("Остатък от делене: "+ (7 % 3).ToString()); //-> 1 (1/3=0.3333)


		}
	}
}
