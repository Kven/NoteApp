using System;
using System.Collections.Generic;

namespace NoteApp
{
    /// <summary>
    /// Класс содержащий название аккорда, начальный лад, а так же массив значений флагов координат
    /// </summary>
    public class Chord
    {
        private string _name;   //название аккорда
        private int _begin;     //начальный лад
        private List<int[]> _frets = new List<int[]>();

        public Chord() { _name = "Неизвестный аккорд"; _begin = 1; }  //конструктор для "пустого аккорда"

        public Chord(string name)
        {
            _name = name;
            _begin = 1;
        }

        /// <summary>
        /// Устанавливает название аккорда
        /// </summary>
        public string Name
        {
            get => _name;
            set
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
        /// <param name="id">Указывает какая позиция на Convas</param>
        /// <param name="flag">1 если надо поставить точку, 0 нет</param>
        /// <param name="X">Координата Х</param>
        /// <param name="Y">Координата У</param>
        public void SetFrets(int id, int flag, int X, int Y) => _frets.Add(new int[] { id, flag, X, Y});

        /// <summary>
        /// Поиск по позиции в списке ладов
        /// </summary>
        /// <param name="id">Указывает какая позиция на Convas</param>
        /// <returns>Возращает всю информацию об ладе: какая позиция, зажат ли он, и координаты</returns>
        public int[] GetFrets (int id) => _frets.Find(x => x[0] == id);
    }    
}