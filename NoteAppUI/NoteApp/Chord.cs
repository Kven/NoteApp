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
			Name = name; 
						
			if (beginfret <= 12 && beginfret >= 1)
				BeginFret = beginfret;
			
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
				BeginFret = value;
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