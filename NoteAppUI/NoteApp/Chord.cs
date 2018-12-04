using System;
using System.Collections.Generic;

namespace NoteApp
{
	/// <summary>
	/// Класс содержащий название аккорда, начальный лад, а так же массив значений флагов координат
	/// </summary>
	public class Chord
	{
		/// <summary>
		/// Конструктор с передаваемым именем
		/// </summary>
		/// <param name="name">Название аккорда</param>
		public Chord(string name, int begin)
		{
			if (name.Length >= 10 || name.Length < 2)
				throw new Exception("Недопустимая длина названия");
			else
				Name = name;

			if (begin <= 12 && begin > 0)
				Begin = begin;
			else
				throw new Exception("Лад не в диапазоне допустимых значений");

			Frets = new List<(int, int)>();

		}

		/// <summary>
		/// Конструктор при пустых аргументах
		/// </summary>
		public Chord() { Frets = new List<(int, int)>(); }

		/// <summary>
		/// Устанавливает название аккорда
		/// </summary>
		public String Name { get; set; }

		/// <summary>
		/// Устанавливает начальный лад
		/// </summary>
		public int Begin { get; set; }

		/// <summary>
		/// Присвоение значения и вовзращение списка координат.
		/// </summary>
		public List<(int, int)> Frets { get; private set; }
		
		
		/// <summary>
		/// Добавление координат точек в поле Frets в класс
		/// </summary>
		/// <param name="coor">Кортедж из координат точки</param>
		public void SetFretsCoor((int, int) coor) => Frets.Add(coor);
	}
}