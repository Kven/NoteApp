using System;
using System.Collections.Generic;

namespace NoteApp
{

	/// <summary>
	/// Класс содержащий название аккорда, начальный лад, а так же список точек зажимания струны
	/// </summary>
	public class Chord
	{
		private System.Text.RegularExpressions.Regex _regularForName = new System.Text.RegularExpressions.Regex("^[A-Z]{1}$|[A-Z]{1}[a-z,0-9]{1,9}$"); //Регулярное выражение для проверки введенного названия

		/// <summary>
		/// Конструктор с передаваемым именем и начальным ладом
		/// </summary>
		/// <param name="name">Название аккорда</param>
		/// <param name="beginFret">Начальный лад</param>
		public Chord(string name, int beginFret)
		{
			if (_regularForName.IsMatch(name) && name.Length >= 1 && name.Length <= 10)
				Name = name;
						
			if (beginFret >= 1 && beginFret <= 12)
				BeginFret = beginFret;
			
			Points = new List<Coordinates>();
		}

		/// <summary>
		/// Конструктор при пустых аргументах
		/// </summary>
		public Chord()
		{
			Points = new List<Coordinates>();
		}


	    private string _name; //Поле, хранящее название аккорда

		/// <summary>
		/// Свойство поля _name. Проверяет и устанавливает, а так же возвращает название 
		/// </summary>
		public string Name
		{
			get => _name;
			set
			{
                if(!_regularForName.IsMatch(value) || value.Length >= 10)
                    throw new ArgumentException("Не корректное название");
				_name = value;
			}
		}

	    private int _beginFret; //Поле которое хранит начальный лад

		/// <summary>
		/// Свойство поля _beginFret. Проверяет и устанавливает начальный лад, а так же возвращает его
		/// </summary>
		public int BeginFret {
			get =>  _beginFret;
			set
			{
                if (value < 1 || value > 12)
                    throw new ArgumentException("Некорректный начальный лад");
				
				_beginFret = value;
			}
		}

	    private List<Coordinates> _points; //Список точек зажатия на грифе

		/// <summary>
		/// Список точек зажима струны
		/// </summary>
		public List<Coordinates> Points {
            get => _points;
			set
			{
				_points = value;
			}
        }

        /// <summary>
        /// Добавление точки зажатия в список Points
        /// </summary>
        /// <param name="coor">Структура из координат Х и У одной точки зажатия</param>
        public void AddPoint(Coordinates coor) => _points.Add(coor);
	}
}