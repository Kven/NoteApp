using System;
using System.Collections.Generic;

namespace NoteApp
{
	/// <summary>
	/// Класс содержащий название аккорда, начальный лад, а так же список точек зажимания струны
	/// </summary>
	public class Chord
	{
		/// <summary>
		/// Конструктор с передаваемым именем
		/// </summary>
		/// <param name="name">Название аккорда</param>
		/// <param name="beginfret">Начальный лад</param>
		public Chord(string name, int beginfret)
		{
			if (name.Length >= 10 && name.Length < 1)
				throw new Exception("Недопустимая длина названия");
			else
				Name = name;

			if (beginfret <= 12 && beginfret >= 1)
				BeginFret = beginfret;
			else
				throw new Exception("Лад не в диапазоне допустимых значений");

			Points = new List<Coordinates>();
		}

		/// <summary>
		/// Конструктор при пустых аргументах
		/// </summary>
		public Chord() { Points = new List<Coordinates>(); }

		/// <summary>
		/// Устанавливает название аккорда
		/// </summary>
		public String Name
		{
			get
			{
				return Name;
			}
			set
			{
				if (value.Length >= 10 && value.Length < 1)
					throw new Exception("Недопустимая длина названия");
				else
					Name = value;
			}
		}

		/// <summary>
		/// Устанавливает начальный лад
		/// </summary>
		public int BeginFret {
			get
			{
				return BeginFret;
			}
			set
			{
				if (value <= 12 && value >= 1)
					BeginFret = value;
				else
					throw new Exception("Лад не в диапазоне допустимых значений");
			}
		}

		/// <summary>
		/// Список точек зажима струны
		/// </summary>
		public List<Coordinates> Points {
			get
			{
				return Points;
			}
			private set
			{
				Points = value;
			}
		}

		/// <summary>
		/// Добавление точки в список Points
		/// </summary>
		/// <param name="coor">Кортедж из координат точки</param>
		public void SetFretsCoor(Coordinates coor) => Points.Add(coor);
	}
}