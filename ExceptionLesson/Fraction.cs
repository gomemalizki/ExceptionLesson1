using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLesson
{
	internal class Fraction
	{
		//private int nominator;//מונה	
		private int denominator;//מכנה

		public int Nominator
		{
			get;set;
		}

		public int Denominator
		{
			get
			{
				return denominator;
			}
			set
			{
				if (value != 0)
					denominator = value;
			}
		}
		public Fraction(int nominator, int denominator)
		{
			Nominator = nominator;
			Denominator = denominator;
		}
		public override string ToString()
		{
			return $"{Nominator}/{Denominator}";
		}
		public double Result()
		{
			return (double)Nominator / Denominator;
		}

		public int Modulu()
		{
			return Nominator % Denominator;
		}
	}
}
