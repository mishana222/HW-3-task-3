using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3_task_3
{
	class Converter
	{
		public Converter(double usd, double eur)
		{
			Usd = usd;
			Eur = eur;
		}

		public  double StartConvert (double amount, string CurrencyFrom, string CurrencyTo)
		{
			if      (CurrencyFrom == "UAH" && CurrencyTo == "USD")
				return amount / Usd;
			else if (CurrencyFrom == "UAH" && CurrencyTo == "EUR")
				return amount / Eur;
			else if (CurrencyFrom == "USD" && CurrencyTo == "UAH")
				return amount * Usd;
			else if (CurrencyFrom == "EUR" && CurrencyTo == "UAH")
				return amount * Eur;
			else if ( (CurrencyFrom == "UAH" && CurrencyTo == "UAN")
				    || (CurrencyFrom == "USD" && CurrencyTo == "USD")
				    || (CurrencyFrom == "EUR" && CurrencyTo == "EUR") )
				return amount;

			else return -1;
		}

		public double Usd;
		public double Eur;
	}
}
