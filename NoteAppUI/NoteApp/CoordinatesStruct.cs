using System;

namespace NoteApp
{
	public struct Coordinates
	{
		/// <summary>
		/// Координата Х, хранит местоположение точки зажима по оси Х
		/// </summary>
		public int X { get; private set; }


		/// <summary>
		/// Координата У, хранит местоположение точки зажима по оси У
		/// </summary>
		public int Y { get; private set; }
		

		/// <summary>
		/// Конструктор создания точки при вызове с двумя параметрами
		/// </summary>
		/// <param name="x">Координата Х точки зажатия</param>
		/// <param name="y">Координата У точки зажатия</param>
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
