using System.Collections.Generic;

namespace NoteApp
{
	public class ListOfChords
	{
		/// <summary>
		/// Контейнер для аккордов
		/// </summary>
		public List<Chord> Chords { get; set; }

		/// <summary>
		/// Конструктор с пустыми параметрами, инициализирующий список
		/// </summary>
		public ListOfChords ()
		{
			Chords = new List<Chord>();
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
				return Chords[index];
			}
		}

	}
}
