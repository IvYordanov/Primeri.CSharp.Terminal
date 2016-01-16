using System;

namespace Enum
{
	class MainClass
	{
		enum ti{ime =0,familia,godini};
		public static void Main (string[] args)
		{
			// Дефиниране на таблица
			string[,]table=new string[2,3];
			// Въвеждане на редове
			table[0,(int)ti.ime]="Ivan";table[0,(int) ti.familia]="Yordanov";table[0,(int) ti.godini]="35";
			table[1,(int)ti.ime]="Yordan";table[1,(int) ti.familia]="Ivanov";table[1,(int) ti.godini]="45";
			//Печат
			Console.Write ("Отбележете с 1и2!\nКой ред искате да отворите:  ");
			int _index = Convert.ToInt32 (Console.ReadLine ())-1;
			Console.WriteLine(
				(table[_index,0])[0]+". "+
				 table[_index,1]+", "+
				 table[_index,2]+"г.");


		}
	}
}
