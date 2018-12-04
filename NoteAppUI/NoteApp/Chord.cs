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
		public Chord(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Конструктор при пустых аргументах
		/// </summary>
		public Chord() { }

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
        public List<int[]> Frets { get; set; }
		
		/// <summary>
		/// Добавление координат точек в поле Frets в класс
		/// </summary>
		/// <param name="coor">Массив из двух координат</param>
		public void SetFretsCoor(int[] coor) => Frets.Add(coor);
	}
}