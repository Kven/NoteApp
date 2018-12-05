using System.Collections.Generic;

namespace NoteApp
{
	public class ListOfChords
	{
		/// <summary>
		/// Контейнер для аккордов
		/// </summary>
		private readonly List<Chord> _chords;

		/// <summary>
		/// Конструктор с пустыми параметрами, инициализирующий список
		/// </summary>
		public ListOfChords ()
		{
			_chords = new List<Chord>();
		}

		/// <summary>
		/// Индексатор
		/// </summary>
		/// <param name="index">Индекс аккорда в списке</param>
		/// <returns>Возвращает аккорд из списка с указаным индексом</returns>
		public Chord this[int index]
		{
			get
			{
				return _chords[index];
			}
		}

	}
}
