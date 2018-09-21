using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс содержащий название аккорда, начальный лад, а так же массив значений флагов координат
    /// </summary>
    class Chord
    {
        private string _name;   //название аккорда
        private int _begin;     //начальный лад
        private int[] _frets = new int[24] {    0,0,0,0,0,0,
                                                0,0,0,0,0,0,
                                                0,0,0,0,0,0,
                                                0,0,0,0,0,0 };    //массив 0 или 1, если 1 то там зажимается струна

        public Chord() { _name = "неизвестно"; _begin = 1; }  //конструктор для "пустого аккорда"

        ~Chord() { } //деконструктор
        /// <summary>
        /// Устанавливает название аккорда
        /// </summary>
        public string Name
        {
            get { return _name; }
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
            get { return _begin; }
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
        /// Устанавливает значение флагов координат
        /// </summary>
        public int[] Frets
        {
            get
            {
                return _frets;
            }
            set
            {
                foreach (int i in value)
                {
                   _frets[i] = value[i];
                }
            }
        }
    }
}