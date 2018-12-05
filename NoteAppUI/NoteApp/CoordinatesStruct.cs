using System;

namespace NoteApp
{
	public struct Coordinates
	{
		/// <summary>
		/// Координата Х, хранит местоположение точки зажима по оси Х
		/// </summary>
		public int X
		{
			get
			{
				return X;
			}
			set
			{
				if (value >= 50 && value <= 240)
					X = value;
				else
					throw new Exception("Координата Х не может быть меньше 50 или больше 240");
			}
		}

		/// <summary>
		/// Координата У, хранит местоположение точки зажима по оси У
		/// </summary>
		public int Y
		{
			get
			{
				return Y;
			}
			set
			{
				if (value >= 50 && value <= 250)
					Y = value;
				else
					throw new Exception("Координата У не может быть меньше 50 или больше 250");
			}
		}
	}

}
