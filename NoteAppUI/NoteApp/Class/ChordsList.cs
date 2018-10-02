using System.Collections.Generic;
using System;
using System.Linq;

namespace NoteApp.Class
{
    public class ChordsList
    {
        /// <summary>
        /// Создаём словарь
        /// </summary>
        private Dictionary<int, Chord> _ChordDic = new Dictionary<int, Chord>();

        /// <summary>
        /// Метод добавление элементов в словарь
        /// </summary>
        public void Add(int i, Chord chord)
        {
            try
            {
                _ChordDic.Add(i, chord);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\nЗаданный ключ уже используется ");
                throw;
            }
            
        }
        /// <summary>
        /// Находит ключ по полю имени в классе chord
        /// </summary>
        /// <param name="name">Название аккорда</param>
        /// <returns>Возвращает id в словоре</returns>
        public int Serch(string name)
        {
            foreach (var VARIABLE in _ChordDic)
            {
                if (VARIABLE.Value.Name == name)
                {
                    return VARIABLE.Key;
                }
            }
            return 0;
        }

        /// <summary>
        /// Метод для удаления элемента словаря
        /// </summary>
        /// <param name="name"> Название аккорда который нужно удалить</param>
        public void Delete(string name)
        {
            int key = 0;
            foreach (var VARIABLE in _ChordDic)
            {
                if (VARIABLE.Value.Name == name)
                {
                    key = VARIABLE.Key;
                }

            }
            _ChordDic.Remove(key);
        }
    }
}
