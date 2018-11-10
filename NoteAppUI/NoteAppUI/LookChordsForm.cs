using System;
using System.Windows.Forms;
using NoteApp;
using System.Collections.Generic;
using System.Drawing;

namespace NoteAppUI
{
    public partial class LookChordsForm : Form
    {
        public List<Chord> list = new List<Chord>();//
		Bitmap bitmap;								//
		Graphics g;									//
		Chord newChord = new Chord();               //


		/// <summary>
		/// 
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
		/// 
		/// </summary>
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		private void DeleteItemButton_Click(object sender, EventArgs e)
		{
			list.RemoveAt(list.FindIndex(x => x.Name == listOfChords.SelectedItem.ToString()));
			listOfChords.Items.RemoveAt(listOfChords.Items.IndexOf(listOfChords.SelectedItem.ToString()));
		}

		/// <summary>
		/// 
		/// </summary>
		private void LookChordsForm_Load(object sender, EventArgs e)
        {
            list.ForEach(x => { listOfChords.Items.Add(x.Name); });
		}

		/// <summary>
		/// 
		/// </summary>
		private void NoteBox_Paint(object sender, PaintEventArgs e)
		{
			g = noteBox.CreateGraphics();
		}

		private void ListOfChords_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listOfChords.SelectedItem != null)
			{
				if (list.Find(x => x.Name == listOfChords.SelectedItem.ToString()) != null)
				{
					noteBox.Refresh();
					Chord selectedChord = new Chord();
					selectedChord = list.Find(x => x.Name == listOfChords.SelectedItem.ToString());
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
