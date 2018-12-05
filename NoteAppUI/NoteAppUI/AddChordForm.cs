using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NoteApp;
using System.Collections.Generic;

namespace NoteAppUI
{
	public partial class AddChordForm : Form
    {
		/// <summary>
		/// Локальный экземпляр класса
		/// </summary>
		public Chord NewChord;

		private List<(int, int)> _tempCoor;

		Regex _rN = new Regex(@"^[A-Z]{1,10}"); //;

		/// <summary>
		/// Создаем битмап для рисования на нем сетки
		/// </summary>
		Bitmap _bitmap;

		/// <summary>
		/// Инструмент для рисования
		/// </summary>
		Graphics _g;

        /// <summary>
        /// Инициализация формы и инициализация битмапа
        /// </summary>
        public AddChordForm()
        {
            InitializeComponent();
			_bitmap = new Bitmap(noteBox.Width, noteBox.Height);
			_tempCoor = new List<(int, int)>();
		}

       
        /// <summary>
        /// Закрытие формы и возвращение на главную без добавления аккорда
        /// </summary>
        private void Сancel_Click(object sender, EventArgs e)
        {
            Close();
        }

		/// <summary>
		/// При нажатии создает точку где зажимается аккорд. Записывает координаты в массив ладов аккорда
		/// </summary>
		private void NoteBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.X >= 50 && e.X <= 240 && e.Y >= 50 && e.Y <= 250)
				_tempCoor.Add(Draw.Point(e.X, e.Y, _g));
			
		}

		/// <summary>
		/// Проверяет значения полей и добавляет аккорд в глобальный список
		/// </summary>
		private void AddChord_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nameInput.Text) || string.IsNullOrWhiteSpace(beginInput.Text))
			{
				MessageBox.Show("Введите название и начальный лад");
			}
			else
			{
				if (_rN.IsMatch(nameInput.Text) && int.TryParse(beginInput.Text, out int bg))
				{
					if (bg >= 0 && bg <= 12)
					{
						NewChord = new Chord(nameInput.Text, int.Parse(beginInput.Text));
						_tempCoor.ForEach(x => NewChord.SetFretsCoor((x.Item1, x.Item2)));
						Hide();
					}
				}
				else
				{
					MessageBox.Show("Введено не корректное название или не допустимый лад");
				}
			}
        }

        /// <summary>
        /// При поялвении формы создает сетку аккорда
        /// </summary>
        private void AddChordForm_Load(object sender, EventArgs e)
        {
			Draw.DrawGrid(_bitmap, _g, noteBox, 70, 55);
        }

        /// <summary>
        /// Динамично отображает название вводимого аккорда
        /// </summary>
        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            name.Text = nameInput.Text;
        }

        /// <summary>
        /// Динамично отображает начальный лад
        /// </summary>
        private void BeginInput_TextChanged(object sender, EventArgs e)
        {
            begin.Text = beginInput.Text;
        }

		/// <summary>
		/// Вызывается при рисовании точек
		/// </summary>
		private void NoteBox_Paint(object sender, PaintEventArgs e)
		{
			_g = noteBox.CreateGraphics();
			
		}

		/// <summary>
		/// Стирает все точки на сетке
		/// </summary>
		private void Clear_Click(object sender, EventArgs e)
		{
			noteBox.Refresh();
			_tempCoor.Clear();
		}

	}
}
