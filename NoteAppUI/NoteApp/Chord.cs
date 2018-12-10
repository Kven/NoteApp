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

	    private string _name;
		/// <summary>
		/// Устанавливает название аккорда
		/// </summary>
		public string Name
		{
			get => _name;
			set
			{
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("Поле должно иметь значение");
				_name = value;
			}
		}

	    private int _beginFret;
		/// <summary>
		/// Устанавливает начальный лад
		/// </summary>
		public int BeginFret {
			get =>  _beginFret;
			
			set
			{
                if (value < 0 && value > 12)
                    throw new ArgumentException("Начальный лад введен некорректно");
				_beginFret = value;
			}
		}

	    private List<Coordinates> _points;
		/// <summary>
		/// Список точек зажима струны
		/// </summary>
		public List<Coordinates> Points {
            get => _points;

            private set => _points = value;
        }

        /// <summary>
        /// Добавление точки в список Points
        /// </summary>
        /// <param name="coor">Кортедж из координат точки</param>
        public void SetFretsCoor(Coordinates coor) => _points.Add(coor);
	}
}