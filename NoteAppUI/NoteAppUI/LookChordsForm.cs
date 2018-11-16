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


        public bool firstOpen = true;
        public bool needCreate = true;

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
			
			//---------------------------
			using (g = Graphics.FromImage(bitmap))
			{
				Pen pen = new Pen(Color.Black, 2);
				int x1 = 31;
				int y = 6;
				//вертикальные линии
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x1, y, x1, y + 200);
					x1 += 30;
				}
				//горизонтальные
				x1 = 30;
				for (int i = 0; i < 6; i++)
				{
					g.DrawLine(pen, x1, y, x1 + 152, y);
					y += 40;
				}
				x1 = 55;
				y = 65;
			}
			noteBox.Image = bitmap;
			//------------------------------
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
            if (newChord.Name != null)
            {
                list.Add(newChord);
                listOfChords.Items.Add(newChord.Name);
            }
			newChord.Frets = addChordForm.newChord.Frets;
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

		    if (firstOpen)
		    {
		        DialogResult result;
		        result = MessageBox.Show("Создать новую библиотеку?", "", MessageBoxButtons.YesNo);
		        if (result == DialogResult.Yes)
		        {
		            SaveFileDialog sfDialog = new SaveFileDialog
					{
						Filter = ".txt",
						DefaultExt = ".txt"
					};
		            sfDialog.ShowDialog();
		            Json.SaveFile(list, sfDialog.FileName);
		        }
		        else
		        {
					OpenFileDialog ofDialog = new OpenFileDialog
					{
						DefaultExt = ".txt"
					};
					ofDialog.ShowDialog();
		            var fromFile = Json.ReadFile(ofDialog.FileName);
		            list.AddRange(fromFile);
		        }
		    }
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
						g.FillEllipse(Brushes.Black, (int)selectedChord.Frets[i].GetValue(0) - 34, (int)selectedChord.Frets[i].GetValue(1) - 46, 15, 15);
					}
				}
			}
			else
			{
				listOfChords.SelectedIndex = 0;
			}
		}
	}
}
