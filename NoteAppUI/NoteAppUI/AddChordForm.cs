﻿using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;
using System.Collections.Generic;

namespace NoteAppUI
{
	public partial class AddChordForm : Form
    {
		/// <summary>
		/// Локальный экземпляр класса для передачи данных из формы в форму
		/// </summary>
		public Chord NewChord;

		/// <summary>
		/// Экземпляр класса-отрисовки
		/// </summary>
		private Draw _draw;

		/// <summary>
		/// Контейнер для временного хранения точек (структуры координат)
		/// </summary>
		private List<Coordinates> _tempCoordinatesList;

		System.Text.RegularExpressions.Regex _regularForName = new System.Text.RegularExpressions.Regex(@"^[A-Z]{1,10}"); //регулярное выражение - шаблон для проверки вводимого названия аккорда

		/// <summary>
		/// Создаем битмап для рисования на нем сетки
		/// </summary>
		private Bitmap _bitmap;

		/// <summary>
		/// Инструмент для отрисовки сетки и точек
		/// </summary>
		private Graphics _graphic;

        /// <summary>
        /// Инициализация формы, битмапа, временного контейнера точек и инструмента отрисовки
        /// </summary>
        public AddChordForm()
        {
            InitializeComponent();
			_bitmap = new Bitmap(GridPictureBox.Width, GridPictureBox.Height);
			_tempCoordinatesList = new List<Coordinates>();
			_draw = new Draw();
		}

       
        /// <summary>
        /// Закрытие формы и возвращение на главную без добавления аккорда
        /// </summary>
        private void Сancel_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Закрыть форму создания аккорда?", "Закрытие формы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Close();
		}

		/// <summary>
		/// При нажатии создает точку где зажимается аккорд. Записывает координаты во временный контейнер
		/// </summary>
		private void NoteBox_MouseDown(object sender, MouseEventArgs e)
		{
			_graphic = GridPictureBox.CreateGraphics();
			if (e.X >= 50 && e.X <= 240 && e.Y >= 50 && e.Y <= 250)
				_tempCoordinatesList.Add(_draw.Point(e.X, e.Y, _graphic));
		}

		/// <summary>
		/// Проверяет значения полей и инициализация локального класса со всеми значениями для передачи в форму просмотра аккордов
		/// </summary>
		private void AddChord_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(NameInputTextBox.Text) && string.IsNullOrWhiteSpace(BeginFretInputTextBox.Text))
			{
				MessageBox.Show("Введите название и начальный лад");
			}
			else
			{
				if (_regularForName.IsMatch(NameInputTextBox.Text))
				{
					if (int.TryParse(BeginFretInputTextBox.Text, out int bg) && bg >= 1 && bg <= 12)
					{
						NewChord = new Chord(NameInputTextBox.Text, bg);
						_tempCoordinatesList.ForEach(x => NewChord.AddPoint(x));
						Hide();
					}
					else
					{ 
						MessageBox.Show("Некорректный начальный лад");
					}
				}
				else
				{
					MessageBox.Show("Введено некорректное название");
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
			_draw.DrawGrid(_bitmap, _graphic, GridPictureBox, xPosition, yPosition);
        }

        /// <summary>
        /// Показывает название аккорда над сеткой аккорда в тот момент, когда вводится символ
        /// </summary>
        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            NameOnBoxLabel.Text = NameInputTextBox.Text;
        }

		/// <summary>
		/// Показывает начальный лад напротив первого лада в тот момент, когда вводится символ
		/// </summary>
		private void BeginInput_TextChanged(object sender, EventArgs e)
        {
			if (int.TryParse(BeginFretInputTextBox.Text, out int value))
				BeginFretOnBoxLabel.Text = BeginFretInputTextBox.Text;
        }

		/// <summary>
		/// Стирает все точки на сетке и очищает временный контейнер точек _tempCoordinatesList
		/// </summary>
		private void Clear_Click(object sender, EventArgs e)
		{
			GridPictureBox.Refresh();
			_tempCoordinatesList.Clear();
		}


	}


}
