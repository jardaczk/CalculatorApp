
namespace CalculatorApp
{
	/// <summary>
	/// Třída Calculator odpovědná za provádění základních aritmetických operací.
	/// </summary>
	internal class Calculator
	{
		/// <summary>
		/// Sečte dvě čísla.
		/// </summary>
		/// <param name="a">První číslo.</param>
		/// <param name="b">Druhé číslo.</param>
		/// <returns>Součet dvou čísel.</returns>
		public double Add(double a, double b)
		{
			return a + b;
		}

		/// <summary>
		/// Odečte druhé číslo od prvního.
		/// </summary>
		/// <param name="a">První číslo.</param>
		/// <param name="b">Druhé číslo.</param>
		/// <returns>Rozdíl prvního a druhého čísla.</returns>
		public double Subtract(double a, double b)
		{
			return a - b;
		}

		/// <summary>
		/// Vynásobí dvě čísla.
		/// </summary>
		/// <param name="a">První číslo.</param>
		/// <param name="b">Druhé číslo.</param>
		/// <returns>Součin dvou čísel.</returns>
		public double Multiply(double a, double b)
		{
			return a * b;
		}

		/// <summary>
		/// Vydělí první číslo druhým.
		/// </summary>
		/// <param name="a">První číslo (dělenec).</param>
		/// <param name="b">Druhé číslo (dělitel).</param>
		/// <returns>Podíl prvního čísla druhým.</returns>
		/// <exception cref="DivideByZeroException">Vyhodí se, pokud je druhé číslo nula.</exception>
		public double Divide(double a, double b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException("Nelze dělit nulou.");
			}
			return a / b;
		}
	}
}
