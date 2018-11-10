using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	public partial class AddChordForm : Form
    {
        /// <summary>
        /// Локальный экземпляр класса
        /// </summary>
        public Chord newChord = new Chord();

		/// <summary>
		/// Создаем битмап для рисования на нем сетки
		/// </summary>
		Bitmap bitmap;

		/// <summary>
		/// Инструмент для рисования
		/// </summary>
		Graphics g;

        /// <summary>
        /// Инициализация формы и инициализация битмапа
        /// </summary>
        public AddChordForm()
        {
            InitializeComponent();
			bitmap = new Bitmap(noteBox.Width, noteBox.Height);
        }

       
        /// <summary>
        /// Закрытие формы и возвращение на главную без добавления аккорда
        /// </summary>
        private void Сancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Проверяет значения полей и добавляет аккорд в глобальный список
        /// </summary>
        private void AddChord_Click(object sender, EventArgs e)
        {
            if (nameInput.Text == "")
            {
                MessageBox.Show("Введите название аккорда");
            }
            else
            {
                newChord.Name = nameInput.Text;
            }

            if (int.TryParse(beginInput.Text, out int bg))
                {
                    if (bg >= 0 && bg <= 12)
                    {
                        newChord.Begin = bg;
                    }
                    else
                    {
                        MessageBox.Show("Не правильный лад");
                    }
                }
                else if (beginInput.Text == "")
                {
                    MessageBox.Show("Введите начальный лад");
                }
            if (beginInput.Text != "" && nameInput.Text != "")
                this.Close();
        }

        /// <summary>
        /// При поялвении формы создает сетку аккорда
        /// </summary>
        private void AddChordForm_Load(object sender, EventArgs e)
        {
			using (g = Graphics.FromImage(bitmap))
			{
				Pen pen = new Pen(Color.Black, 2);
				int x = 70;
				int y = 55;
				//вертикальные линии
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x, y, x, y + 200);
					x += 30;
				}
				//горизонтальные
				x = 69;
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x, y, x + 152, y);
					y += 40;
				}
				x = 55;
				y = 65;
			}
			noteBox.Image = bitmap;
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
		/// При нажатии создает точку где зажимается аккорд. Записывает координаты в массив ладов аккорда
		/// </summary>
		private void NoteBox_MouseDown(object sender, MouseEventArgs e)
		{
			int x = e.X - 7;
			int y = e.Y - 7;
			g.FillEllipse(Brushes.Black, x, y, 15, 15);
			newChord.SetFretsCoor(x, y);
		}
		
		/// <summary>
		/// Вызывается при рисовании точек
		/// </summary>
		private void NoteBox_Paint(object sender, PaintEventArgs e)
		{
			g = noteBox.CreateGraphics();
		}

		/// <summary>
		/// Стирает все точки на сетке
		/// </summary>
		private void Clear_Click(object sender, EventArgs e)
		{
			noteBox.Refresh();
		}
	}
}
