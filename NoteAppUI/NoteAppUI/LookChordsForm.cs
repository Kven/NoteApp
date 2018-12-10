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
		/// Список аккордов
		/// </summary>
		private ListOfChords _listOfChords;

        /// <summary>
		/// Инструмент для создания графики
		/// </summary>
		private Graphics _graphic;

		/// <summary>
		/// Экземпляр отрисовщика
		/// </summary>
		private Draw _draw;

		int xGridBeginPosition = 31; //
		int yGridBeginPosition = 6; //

		/// <summary>
		/// Инициализая формы, инициализация битмапа, и отрисовка сетки
		/// </summary>
		public LookChordsForm()
		{
		    InitializeComponent();
			_listOfChords = new ListOfChords();
		    var bitmap = new Bitmap(gridPictureBox.Width, gridPictureBox.Height);
			_draw = new Draw();
			_draw.DrawGrid(bitmap, _graphic, gridPictureBox, xGridBeginPosition, yGridBeginPosition);
		}

		/// <summary>
		/// Закрывает текущую форму и возвращает на главную форму
		/// </summary>
        private void Back_Click(object sender, EventArgs e)
		{

		    if (MessageBox.Show("Сохранить перед выходом?", "", MessageBoxButtons.YesNo) == DialogResult.No)
		    Close();
		    else
		    {
		        Save_Click(sender, e);
		        Close();
		    }
		}

		/// <summary>
		/// Добавляет аккорд в глобальный список, и добавляет визуально в список аккордов 
		/// </summary>
        private void Add_chord_Click(object sender, EventArgs e)
		{
		    ListOfChordNamesListBox.SelectedIndex = -1;
            AddChordForm addChordForm = new AddChordForm();
            addChordForm.ShowDialog();
			if (addChordForm.NewChord != null)
            {
                _listOfChords.Chords.Add(addChordForm.NewChord);
				addChordForm.Close();
                ListOfChordNamesListBox.Items.Add(_listOfChords.Chords[_listOfChords.Chords.Count-1].Name);
            }
		}

		/// <summary>
		/// Удаляет выделенный аккорд из глобального и визуального списка
		/// </summary>
		private void DeleteItemButton_Click(object sender, EventArgs e)
		{
		    if (MessageBox.Show("Точно удалить?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
		    {
		        _listOfChords.Chords.RemoveAt(_listOfChords.Chords.FindIndex(x =>
		            x.Name == ListOfChordNamesListBox.SelectedItem.ToString()));
		        ListOfChordNamesListBox.Items.RemoveAt(
		            ListOfChordNamesListBox.Items.IndexOf(ListOfChordNamesListBox.SelectedItem.ToString()));
		    }
		}

		/// <summary>
		/// При закрузке формы добавляет в визуальный список названия аккордов из глобального
		/// </summary>
		private void LookChordsForm_Load(object sender, EventArgs e)
		{ 
			_listOfChords.Chords.ForEach(x => { ListOfChordNamesListBox.Items.Add(x.Name); });
        }

		/// <summary>
		/// Вызывается при рисовании точек на пикчебоксе
		/// </summary>
		private void NoteBox_Paint(object sender, PaintEventArgs e)
		{
			_graphic = gridPictureBox.CreateGraphics();
		}

		/// <summary>
		/// При изменении выделенного аккорда в визуальном списке отображает на картинке его зажатые лады, название и начальный лад 
		/// при удалении аккорда, идет смена активного элемента и значение устантанавливается в нулевое положение (иначе null)
		/// </summary>
		private void ListOfChords_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ListOfChordNamesListBox.SelectedItem != null)
			{
				if (_listOfChords.Chords.Find(x => x.Name == ListOfChordNamesListBox.SelectedItem.ToString()) != null  )
				{
					gridPictureBox.Refresh();
					Chord selectedChord = _listOfChords.Chords.Find(x => x.Name == ListOfChordNamesListBox.SelectedItem.ToString());
					chordNameLabel.Text = ListOfChordNamesListBox.SelectedItem.ToString();
					chordBeginFretLabel.Text = _listOfChords.Chords.Find(x => x.Name == ListOfChordNamesListBox.SelectedItem.ToString()).BeginFret.ToString();
					int count = selectedChord.Points.Count;
					for (int i = 0; i < count; i++)
					{
						_draw.DrawPoint(_graphic, selectedChord.Points[i].X, selectedChord.Points[i].Y);
					}
				}
			}
			else
			{
				ListOfChordNamesListBox.SelectedIndex = -1;
				chordBeginFretLabel.Text = "";
				chordNameLabel.Text = "";
				gridPictureBox.Refresh();
			}
		}

		/// <summary>
		/// Открывает форму открытия файла и десериализует его в список аккордов
		/// </summary>
		private void Open_Click(object sender, EventArgs e)
		{
			ListOfChordNamesListBox.Items.Clear();
			_listOfChords.Chords.Clear();
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Файл библиотека (*.nlb)|*.nlb|Все файлы (*.*)|*.*"
			};
			openFileDialog.ShowDialog();
			if (!string.IsNullOrWhiteSpace(openFileDialog.FileName))
			{
			    nameOfCurrentLibraryLabel.Text = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('\\') + 1,
			        openFileDialog.FileName.Length - openFileDialog.FileName.LastIndexOf('\\') - 5);
				var fromFile = Serialize.ReadFile(openFileDialog.FileName);
				_listOfChords = fromFile;
				_listOfChords.Chords.ForEach(x => { ListOfChordNamesListBox.Items.Add(x.Name); });
			}
		}

		/// <summary>
		/// Очищает все, создаёт пустую рабочую среду
		/// </summary>
		private void New_Click(object sender, EventArgs e)
		{
			ListOfChordNamesListBox.Items.Clear();
			_listOfChords.Chords.Clear();
		}

		/// <summary>
		/// Сохраняет список аккордов в файл путем сериализации
		/// </summary>
		private void Save_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "Файл библиотека (*.nlb)|*.nlb"
			};
			saveFileDialog.ShowDialog();
			if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
			{
			    nameOfCurrentLibraryLabel.Text = saveFileDialog.FileName.Substring(saveFileDialog.FileName.LastIndexOf('\\') + 1,
			        saveFileDialog.FileName.Length - saveFileDialog.FileName.LastIndexOf('\\') - 5);
                Serialize.SaveFile(_listOfChords, saveFileDialog.FileName);
			}
		}

	}
}
