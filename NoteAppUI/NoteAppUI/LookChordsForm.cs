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
		public List<Chord> List = new List<Chord>();

        /// <summary>
		/// Инструмент для создания графики
		/// </summary>
		Graphics _g;

		/// <summary>
		/// Инициализая формы, инициализация битмапа, и нарисование сетки
		/// </summary>
		public LookChordsForm()
		{
		    InitializeComponent();
		    var bitmap = new Bitmap(noteBox.Width, noteBox.Height);
			Draw.DrawGrid(bitmap, _g, noteBox, 31, 6);
		}

		/// <summary>
		/// Закрывает текущую форму и возвращает на главную форму
		/// </summary>
        private void Back_Click(object sender, EventArgs e)
        {
            Close(); 
        }

		/// <summary>
		/// Добавляет аккорд в глобальный список, и добавляет визуально в список аккордов 
		/// </summary>
        private void Add_chord_Click(object sender, EventArgs e)
        {
            AddChordForm addChordForm = new AddChordForm();
            addChordForm.ShowDialog();
			if (addChordForm.NewChord != null)
            {
                List.Add(addChordForm.NewChord);
				addChordForm.Close();
                listOfChords.Items.Add(List[List.Count-1].Name);
            }
		}

		/// <summary>
		/// Удаляет выделенный аккорд из глобального и визуального списка
		/// </summary>
		private void DeleteItemButton_Click(object sender, EventArgs e)
		{
			List.RemoveAt(List.FindIndex(x => x.Name == listOfChords.SelectedItem.ToString()));
			listOfChords.Items.RemoveAt(listOfChords.Items.IndexOf(listOfChords.SelectedItem.ToString()));
		}

		/// <summary>
		/// При закрузке формы добавляет в визуальный список названия аккордов из глобального
		/// </summary>
		private void LookChordsForm_Load(object sender, EventArgs e)
		{ 
			List.ForEach(x => { listOfChords.Items.Add(x.Name); });
        }

		/// <summary>
		/// Вызывается при рисовании точек на пикчебоксе
		/// </summary>
		private void NoteBox_Paint(object sender, PaintEventArgs e)
		{
			_g = noteBox.CreateGraphics();
		}

		/// <summary>
		/// При изменении выделенного аккорда в визуальном списке отображает на картинке его зажатые лады, название и начальный лад 
		/// при удалении аккорда, идет смена активного элемента и значение устантанавливается в нулевое положение (иначе null)
		/// </summary>
		private void ListOfChords_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listOfChords.SelectedItem != null)
			{
				if (List.Find(x => x.Name == listOfChords.SelectedItem.ToString()) != null  )
				{
					noteBox.Refresh();
					Chord selectedChord = List.Find(x => x.Name == listOfChords.SelectedItem.ToString());
					chordName.Text = listOfChords.SelectedItem.ToString();
					chordBegin.Text = List.Find(x => x.Name == listOfChords.SelectedItem.ToString()).Begin.ToString();
					int count = selectedChord.Frets.Count;
					for (int i = 0; i < count; i++)
					{
						_g.FillEllipse(Brushes.Black, selectedChord.Frets[i].Item1 - 40, selectedChord.Frets[i].Item2 - 49, 15, 15);
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
			List.Clear();
			OpenFileDialog ofDialog = new OpenFileDialog
			{
				Filter = "Файл библиотека (*.nlb)|*.nlb|Все файлы (*.*)|*.*"
			};
			ofDialog.ShowDialog();
			if (!string.IsNullOrWhiteSpace(ofDialog.FileName))
			{
			    label_libname.Text = ofDialog.FileName.Substring(ofDialog.FileName.LastIndexOf('\\') + 1,
			        ofDialog.FileName.Length - ofDialog.FileName.LastIndexOf('\\') - 5);
				var fromFile = Serializator.ReadFile(ofDialog.FileName);
				List.AddRange(fromFile);
				List.ForEach(x => { listOfChords.Items.Add(x.Name); });
			}
		}

		/// <summary>
		/// Очищает все, создаёт пустую рабочую среду
		/// </summary>
		private void New_Click(object sender, EventArgs e)
		{
			listOfChords.Items.Clear();
			List.Clear();
		}

		/// <summary>
		/// Сохраняет список аккордов в файл путем сериализации
		/// </summary>
		private void Save_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfDialog = new SaveFileDialog
			{
				Filter = "Файл библиотека (*.nlb)|*.nlb"
			};
			sfDialog.ShowDialog();
			if (!string.IsNullOrWhiteSpace(sfDialog.FileName))
			{
			    label_libname.Text = sfDialog.FileName.Substring(sfDialog.FileName.LastIndexOf('\\') + 1,
			        sfDialog.FileName.Length - sfDialog.FileName.LastIndexOf('\\') - 5);
                Serializator.SaveFile(List, sfDialog.FileName);
			}
		}

	}
}
