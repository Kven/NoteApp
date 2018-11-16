using System;
using System.Windows.Forms;
using NoteApp;
using System.Collections.Generic;
using System.Drawing;

namespace NoteAppUI
{
    public partial class LookChordsForm : Form
    {
		/// <summary>
		/// Поле для принятия списка из главной формы - глобальный список аккордов
		/// </summary>
		public List<Chord> list = new List<Chord>();

        /// <summary>
		/// Создаем битмап для размещения на нем сетки
		/// </summary>
		Bitmap bitmap;
		
		/// <summary>
		/// Инструмент для создания графики
		/// </summary>
		Graphics g;

		/// <summary>
		/// Экземпляр для принятия из формы создания аккорда
		/// </summary>
		Chord newChord = new Chord();


		/// <summary>
		/// Инициализая формы, инициализация битмапа, и нарисование сетки
		/// </summary>
		public LookChordsForm()
		{
			InitializeComponent();
		    bitmap = new Bitmap(noteBox.Width, noteBox.Height);
			Draw.DrawGrid(bitmap, g, noteBox, 31, 6);
		}

		/// <summary>
		/// Закрывает текущую форму и возвращает на главную форму
		/// </summary>
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

		/// <summary>
		/// Добавляет аккорд в глобальный список, и добавляет визуально в список аккордов 
		/// </summary>
        private void Add_chord_Click(object sender, EventArgs e)
        {
            AddChordForm addChordForm = new AddChordForm();
            addChordForm.ShowDialog();
			newChord.Name = addChordForm.newChord.Name;
			newChord.Begin = addChordForm.newChord.Begin;
			newChord.Frets = addChordForm.newChord.Frets;
			if (!string.IsNullOrWhiteSpace(newChord.Name))
            {
                list.Add(newChord);
                listOfChords.Items.Add(newChord.Name);
            }
		}

		/// <summary>
		/// Удаляет выделенный аккорд из глобального и визуального списка
		/// </summary>
		private void DeleteItemButton_Click(object sender, EventArgs e)
		{
			list.RemoveAt(list.FindIndex(x => x.Name == listOfChords.SelectedItem.ToString()));
			listOfChords.Items.RemoveAt(listOfChords.Items.IndexOf(listOfChords.SelectedItem.ToString()));
		}

		/// <summary>
		/// При закрузке формы добавляет в визуальный список названия аккордов из глобального
		/// </summary>
		private void LookChordsForm_Load(object sender, EventArgs e)
		{ 
			list.ForEach(x => { listOfChords.Items.Add(x.Name); });
        }

		/// <summary>
		/// Вызывается при рисовании точек на пикчебоксе
		/// </summary>
		private void NoteBox_Paint(object sender, PaintEventArgs e)
		{
			g = noteBox.CreateGraphics();
		}

		/// <summary>
		/// При изменении выделенного аккорда в визуальном списке отображает на картинке его зажатые лады, название и начальный лад 
		/// при удалении аккорда, идет смена активного элемента и значение устантанавливается в нулевое положение (иначе null)
		/// </summary>
		private void ListOfChords_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listOfChords.SelectedItem != null)
			{
				if (list.Find(x => x.Name == listOfChords.SelectedItem.ToString()) != null)
				{
					noteBox.Refresh();
					Chord selectedChord = new Chord();
					selectedChord = list.Find(x => x.Name == listOfChords.SelectedItem.ToString());
					chordName.Text = listOfChords.SelectedItem.ToString();
					chordBegin.Text = list.Find(x => x.Name == listOfChords.SelectedItem.ToString()).Begin.ToString();
					int count = selectedChord.Frets.Count;
					for (int i = 0; i < count; i++)
					{
						g.FillEllipse(Brushes.Black, (int)selectedChord.Frets[i].GetValue(0) - 40, (int)selectedChord.Frets[i].GetValue(1) - 49, 15, 15);
					}
				}
			}
			else
			{
				listOfChords.SelectedIndex = -1;
				chordBegin.Text = "";
				chordName.Text = "";
				noteBox.Refresh();
			}
		}

		/// <summary>
		/// Открывает форму открытия файла и десериализует его в список аккордов
		/// </summary>
		private void Open_Click(object sender, EventArgs e)
		{
			listOfChords.Items.Clear();
			list.Clear();
			OpenFileDialog ofDialog = new OpenFileDialog
			{
				Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
			};
			ofDialog.ShowDialog();
			if (!string.IsNullOrWhiteSpace(ofDialog.FileName))
			{
				var fromFile = Json.ReadFile(ofDialog.FileName);
				list.AddRange(fromFile);
				list.ForEach(x => { listOfChords.Items.Add(x.Name); });
			}
		}

		/// <summary>
		/// Очищает все, создаёт пустую рабочую среду
		/// </summary>
		private void New_Click(object sender, EventArgs e)
		{
			listOfChords.Items.Clear();
			list.Clear();
		}

		/// <summary>
		/// Сохраняет список аккордов в файл путем сериализации
		/// </summary>
		private void Save_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfDialog = new SaveFileDialog
			{
				Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
			};
			sfDialog.ShowDialog();
			if (!string.IsNullOrWhiteSpace(sfDialog.FileName))
			{
				Json.SaveFile(list, sfDialog.FileName);
			}
		}
	}
}
