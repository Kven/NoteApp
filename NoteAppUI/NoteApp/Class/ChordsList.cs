using System.Collections.Generic;
using System;

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


            return id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        public void Delete(int i)
        {

        }
    }
}
