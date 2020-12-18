using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesAbstractFactory
{
    public class ClassicPants : IPants
    {
		/// <summary>
		/// Длина по внутреннему шву, cm.
		/// </summary>
		private readonly float _insideLength;

		/// <summary>
		/// Обхват бедер, cm.
		/// </summary>
		private readonly float _hipGirth;

		/// <summary>
		/// Длина, cm.
		/// </summary>
		private readonly float _seamLength;

		/// <summary>
		/// Конструктор с 3 параметрами.
		/// </summary>
		/// <param name="insideLength">Длина по внутреннему шву, cm.</param>
		/// <param name="hipGirth">Обхват бедер, cm.</param>
		/// <param name="seamLength">Длина, cm.</param>
		public ClassicPants(float insideLength, float hipGirth, float seamLength)
		{
			if (insideLength > 170 || insideLength <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(insideLength), "must be beetwen 0 and 170.");
			}

			if (seamLength > 180 || seamLength <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(seamLength), "must be beetwen 0 and 180.");
			}

			if (hipGirth > 300 || hipGirth <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(seamLength), "must be beetwen 0 and 300.");
			}

			if (seamLength - insideLength < 5)
			{
				throw new ArgumentException($"Difference beetween {nameof(seamLength)} and {nameof(insideLength)} must be equal or bigger than 5 cm.");
			}

			if (hipGirth / seamLength > 5)
			{
				throw new ArgumentException($"{nameof(seamLength)} can`t be more then 5 less then {nameof(hipGirth)}.");
			}

			_hipGirth = hipGirth;
			_insideLength = insideLength;
			_seamLength = seamLength;

		}

		/// <summary>
		/// Возвращает размер брюк.
		/// </summary>
		/// <returns></returns>
		public string CalcSize()
		{
			return Math.Round((_hipGirth / 2), 0).ToString();
		}
	}
}
