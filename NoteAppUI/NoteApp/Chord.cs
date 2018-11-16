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
		/// Название аккорда
		/// </summary>
        private string _name;   

		/// <summary>
		/// Начальный лад аккорда
		/// </summary>
        private int _begin;

		/// <summary>
		/// Лады аккорда
		/// </summary>
		public List<int[]> Frets { get; set; } = new List<int[]>();

		/// <summary>
		/// Конструктор при пустых аргументах
		/// </summary>
		public Chord() { } 

		/// <summary>
		/// Конструктор с передаваемым именем
		/// </summary>
		/// <param name="name">Название аккорда</param>
        public Chord(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Устанавливает название аккорда
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] == '!') //добавить диапазон
                        {
                            throw new ArgumentException("Недопустимые символы в названии акккорда - " + value[i]);
                        }
                        _name = value;
                    }
                }
            }
        }

        /// <summary>
        /// Устанавливает начальный лад
        /// </summary>
        public int Begin
        {
            get => _begin;
            set
            {
                if (value > 16)
                {
                    throw new ArgumentException("Недопустим начальный лад " + value);
                }
                else
                    _begin = value;
            }
        }


        /// <summary>
        /// Устанавливаем значения флагов и мест нанесения точки
        /// /// </summary>
        /// <param name="X">Координата Х</param>
        /// <param name="Y">Координата У</param>
		public void SetFretsCoor(int X, int Y) => Frets.Add(new int[] {X, Y});

		public void SetFretsCoor(int[] coor) => Frets.Add(coor);



		


	}
}