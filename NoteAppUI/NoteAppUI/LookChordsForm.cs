using System;
using System.Windows.Forms;
using NoteApp;
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

		/// <summary>
		/// Инициализая формы, инициализация битмапа, и отрисовка сетки
		/// </summary>
		public LookChordsForm()
		{
		    InitializeComponent();

			_listOfChords = new ListOfChords();

			_draw = new Draw();

			Bitmap bitmap = new Bitmap(GridPictureBox.Width, GridPictureBox.Height);
			int xGridBeginPosition = 31; //Точка начала отрисовки линий сетки по оси Х
			int yGridBeginPosition = 6; //Точка начала отрисовки линий сетки по оси У
			_draw.DrawGrid(bitmap, _graphic, GridPictureBox, xGridBeginPosition, yGridBeginPosition);

			_listOfChords.Chords.ForEach(x => { ListOfChordNamesListBox.Items.Add(x.Name); });
		}

		/// <summary>
		/// Закрывает текущую форму и возвращает на главную форму
		/// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
		{
		    if (MessageBox.Show("Сохранить перед выходом?", "Закрытие формы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				Close();
		    else
		    {
		        SaveLibraryButton_Click(sender, e);
		        Close();
		    }
		}

		/// <summary>
		/// Добавляет аккорд в глобальный список, и добавляет визуально в список аккордов 
		/// </summary>
        private void AddChordButton_Click(object sender, EventArgs e)
		{
            AddChordForm addChordForm = new AddChordForm();
            addChordForm.ShowDialog();
			if (addChordForm.NewChord != null)
            {
                _listOfChords.Chords.Add(addChordForm.NewChord);
				addChordForm.Close();
                ListOfChordNamesListBox.Items.Add(_listOfChords.Chords[_listOfChords.Chords.Count-1].Name);
				ListOfChordNamesListBox.SelectedIndex = ListOfChordNamesListBox.Items.Count - 1;
			}
		}

		/// <summary>
		/// Удаляет выделенный аккорд из глобального и визуального списка
		/// </summary>
		private void DeleteChordButton_Click(object sender, EventArgs e)
		{
		    if (MessageBox.Show("Точно удалить?", "Удаление аккорда", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
		    {
		        _listOfChords.Chords.RemoveAt(_listOfChords.Chords.FindIndex(x => 
					x.Name == ListOfChordNamesListBox.SelectedItem.ToString()));

				ListOfChordNamesListBox.Items.RemoveAt(
					ListOfChordNamesListBox.Items.IndexOf(ListOfChordNamesListBox.SelectedItem.ToString()));
		    }
		}

		/// <summary>
		/// При изменении выделенного аккорда в визуальном списке отображает на картинке его зажатые лады, название и начальный лад 
		/// при удалении аккорда, идет смена активного элемента и значение устантанавливается в нулевое положение (иначе null)
		/// </summary>
		private void ListOfChordNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ListOfChordNamesListBox.SelectedItem != null)
			{
				if (_listOfChords.Chords.Find(x => x.Name == ListOfChordNamesListBox.SelectedItem.ToString()) != null  )
				{
					_graphic = GridPictureBox.CreateGraphics();
					GridPictureBox.Refresh();

					Chord selectedChord = _listOfChords.Chords.Find(x => x.Name == ListOfChordNamesListBox.SelectedItem.ToString()); // Временный класс для работы с ним

					ChordNameLabel.Text = ListOfChordNamesListBox.SelectedItem.ToString();
					ChordBeginFretLabel.Text = _listOfChords.Chords.Find(x => x.Name == ListOfChordNamesListBox.SelectedItem.ToString()).BeginFret.ToString();

					for (int i = 0; i < selectedChord.Points.Count; i++)
					{
						_draw.DrawPoint(_graphic, selectedChord.Points[i].X, selectedChord.Points[i].Y);
					}
				}
			}
			else
			{
				ListOfChordNamesListBox.SelectedIndex = -1;
				ChordBeginFretLabel.Text = "";
				ChordNameLabel.Text = "";
				GridPictureBox.Refresh();
			}
		}

		/// <summary>
		/// Открывает форму открытия файла и десериализует его в список аккордов
		/// </summary>
		private void OpenLibraryButton_Click(object sender, EventArgs e)
		{
			ListOfChordNamesListBox.Items.Clear();
			_listOfChords.Chords.Clear();

			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Файл библиотеки (*.nlb)|*.nlb|Все файлы (*.*)|*.*"
			};
			openFileDialog.ShowDialog();

			if (!string.IsNullOrWhiteSpace(openFileDialog.FileName))
			{
			    NameOfCurrentLibraryLabel.Text = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('\\') + 1,
			        openFileDialog.FileName.Length - openFileDialog.FileName.LastIndexOf('\\') - 5);

				var fromFile = Serialize.ReadFile(openFileDialog.FileName);

				_listOfChords = fromFile;
				_listOfChords.Chords.ForEach(x => { ListOfChordNamesListBox.Items.Add(x.Name); });
			}
		}

		/// <summary>
		/// Очищает все, создаёт пустую рабочую среду
		/// </summary>
		private void CreateNewLibraryButton_Click(object sender, EventArgs e)
		{
			ListOfChordNamesListBox.Items.Clear();
			_listOfChords.Chords.Clear();
		}

		/// <summary>
		/// Сохраняет список аккордов в файл путем сериализации
		/// </summary>
		private void SaveLibraryButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "Файл библиотеки (*.nlb)|*.nlb"
			};
			saveFileDialog.ShowDialog();

			if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
			{
			    NameOfCurrentLibraryLabel.Text = saveFileDialog.FileName.Substring(saveFileDialog.FileName.LastIndexOf('\\') + 1,
			        saveFileDialog.FileName.Length - saveFileDialog.FileName.LastIndexOf('\\') - 5);

                Serialize.SaveFile(_listOfChords, saveFileDialog.FileName);
			}
		}


	}


}
