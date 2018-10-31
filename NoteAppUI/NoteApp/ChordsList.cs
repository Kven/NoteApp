using System;
using System.Collections.Generic;

namespace NoteApp
{
    public class ChordsList
    {
        /// <summary>
        /// Создаём список
        /// </summary>
        private List<Chord> _chordsList = new List<Chord>();

        /// <summary>
        /// Метод добавление элементов в словарь
        /// </summary>
        public void Add(Chord chord)
        {
            _chordsList.Add(chord);
        }

        /// <summary>
        /// Находит ключ по полю имени в классе chord
        /// </summary>
        /// <param name="name">Название аккорда</param>
        /// <returns>Возвращает id в словаре</returns>
        public int Serch(string name)
        {
            return _chordsList.FindIndex(n=> n.Name == name);
        }

        /// <summary>
        /// Метод для удаления элемента словаря
        /// </summary>
        /// <param name="name"> Название аккорда который нужно удалить</param>
        public void Delete(string name)
        {
            _chordsList.Remove(_chordsList.Find(i=> i.Name == name));
        }
    }
}
