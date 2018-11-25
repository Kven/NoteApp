using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
		/// Название аккорда
		/// </summary>
		[Required]
		[StringLength(10, MinimumLength = 2)]
		private string _name;

		/// <summary>
		/// Устанавливает название аккорда
		/// </summary>
		public String Name
		{
			get { return _name; }

			set { _name = value; }
		}

		/// <summary>
		/// Начальный лад аккорда
		/// </summary>
		[Required]
		[Range(1,16)]
		private int _begin;

		/// <summary>
		/// Устанавливает начальный лад
		/// </summary>
		
		public int Begin
		{
			get { return _begin; }
			set { _begin = value; }
		}

		/// <summary>
		/// Список значений координат, где нужно поставить точку.
		/// </summary>
		private List<int[]> _frets = new List<int[]>();
		
		/// <summary>
		/// Присвоение значения и вовзращение списка координат.
		/// </summary>
		public List<int[]> Frets
		{
			get { return _frets; }
			set { _frets = value; }
			
		}
		
		/// <summary>
		/// Добавление координат точек в поле Frets в класс
		/// </summary>
		/// <param name="coor">Массив из двух координат</param>
		public void SetFretsCoor(int[] coor) => Frets.Add(coor);


	}
}