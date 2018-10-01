using System.Collections.Generic;

namespace NoteApp.Class
{
    public class ChordsList
    {
        private readonly List<Chord> _list_of_chords = new List<Chord>();
        
        /// <summary>
        /// добавляет аккорд в список аккоордов
        /// </summary>
        /// <param name="chord"> аккорд который добавляют в список</param>
        public void Add(Chord chord)
        {
            _list_of_chords.Add(chord);
        }
        /// <summary>
        /// удаляет аккорд в списке аккордов по названию аккорда
        /// </summary>
        /// <param name="name">название аккорда, который нужно удалить</param>
        public void Delete(string name)
        {

        }

        /* public list<Chord> GetChords
        {   
            должен вернуть список аккордов, название в лист бокс,
            начальный лад в бокс текст,
            массив флагов в условную конструцию которая будет ставить точку в определенной координате если 1 и не будет если 0

        }
        */
    }
}
