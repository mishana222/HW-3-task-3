using System;

namespace HW_3_task_3
{
	class Program
	{
		static void Set(ref double amount,ref string CurrencyFrom,ref string CurrencyTo)
		{
			Console.WriteLine("Enter amount of money you wish to convert:");
			amount = Convert.ToDouble(Console.ReadLine());
			while (amount <= 0)
			{
				Console.WriteLine("Inadmissible amount of money entered. Please, try again.");
				amount = Convert.ToDouble(Console.ReadLine() );
			}

			Console.WriteLine("Enter the Currency which you want to convert from:\n" +
				"(UAH/USD/EUR only)");
			CurrencyFrom = Console.ReadLine();
			while (CurrencyFrom != "UAH" && CurrencyFrom != "USD" && CurrencyFrom != "EUR")
			{
				Console.WriteLine("Wrong currency entered. Please, try again.");
				CurrencyFrom = Console.ReadLine();
			}

			Console.WriteLine("Enter the Currency which you want to convert to:\n" +
				"(UAH/USD/EUR only)");
			CurrencyTo = Console.ReadLine();
			while (CurrencyTo != "UAH" && CurrencyTo != "USD" && CurrencyTo != "EUR")
			{
				Console.WriteLine("Wrong currency entered. Please, try again.");
				CurrencyTo = Console.ReadLine();
			}
		}
		static void Main(string[] args)
		{
			double amount = 0;
			string CurrencyFrom = "", CurrencyTo = "";

			Set(ref amount,ref CurrencyFrom,ref CurrencyTo);

			Converter work = new Converter(8, 10);
			
			Console.WriteLine($"Your result: {work.StartConvert(amount, CurrencyFrom, CurrencyTo)} ");
		}
	}
}
