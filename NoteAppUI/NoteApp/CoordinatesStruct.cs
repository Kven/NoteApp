using System;

namespace NoteApp
{
	public struct Coordinates
	{
		/// <summary>
		/// Координата Х, хранит местоположение точки зажима по оси Х
		/// </summary>
		public readonly int X;


		/// <summary>
		/// Координата У, хранит местоположение точки зажима по оси У
		/// </summary>
		public readonly int Y;
		

		public Coordinates (int x, int y)
		{
			if (x >= 50 && x <= 240)
				X = x;
			else
				throw new Exception("Координата Х не может быть меньше 50 или больше 240");

			if (y >= 50 && y <= 250)
				Y = y;
			else
				throw new Exception("Координата У не может быть меньше 50 или больше 250");
		}
	}

}
