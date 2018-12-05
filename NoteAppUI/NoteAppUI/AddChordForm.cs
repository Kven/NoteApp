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

		/// <summary>
		/// Экземпляр класса-рисовки
		/// </summary>
		private Draw _draw;

		/// <summary>
		/// Контейнер для временного хранения точек (структуры координат)
		/// </summary>
		private List<Coordinates> _tempCoordinatesList;

		Regex _rN = new Regex(@"^[A-Z]{1,10}"); //регулярное выражение - шаблон для проверки вводимого названия аккорда

		/// <summary>
		/// Создаем битмап для рисования на нем сетки
		/// </summary>
		private Bitmap _bitmap;

		/// <summary>
		/// Инструмент для рисования
		/// </summary>
		private Graphics _graphic;

        /// <summary>
        /// Инициализация формы и инициализация битмапа
        /// </summary>
        public AddChordForm()
        {
            InitializeComponent();
			_bitmap = new Bitmap(noteBox.Width, noteBox.Height);
			_tempCoordinatesList = new List<Coordinates>();
			_draw = new Draw();
		}

       
        /// <summary>
        /// Закрытие формы и возвращение на главную без добавления аккорда
        /// </summary>
        private void Сancel_Click(object sender, EventArgs e)
        {
            Close();
        }

		/// <summary>
		/// При нажатии создает точку где зажимается аккорд. Записывает координаты во временный контейнер
		/// </summary>
		private void NoteBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.X >= 50 && e.X <= 240 && e.Y >= 50 && e.Y <= 250)
				_tempCoordinatesList.Add(_draw.Point(e.X, e.Y, _graphic));
		}

		/// <summary>
		/// Проверяет значения полей и инициализация локального класса со всеми значениями для передачи в форму просмотра аккордов
		/// </summary>
		private void AddChord_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nameInput.Text) && string.IsNullOrWhiteSpace(beginInput.Text))
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
						_tempCoordinatesList.ForEach(x => NewChord.SetFretsCoor(x));
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
			int xPosition = 70; //Точка начала отрисовки линий сетки по оси Х
			int yPosition = 55; //Точка начала отрисовки линий сетки по оси У
			_draw.DrawGrid(_bitmap, _graphic, noteBox, xPosition, yPosition);
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
			_graphic = noteBox.CreateGraphics();
			
		}

		/// <summary>
		/// Стирает все точки на сетке и очищает временный контейнер точек _tempCoordinatesList
		/// </summary>
		private void Clear_Click(object sender, EventArgs e)
		{
			noteBox.Refresh();
			_tempCoordinatesList.Clear();
		}

	}
}
