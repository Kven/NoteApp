using System;
using System.Windows.Forms;
using NoteApp;
using System.Collections.Generic;
using System.Drawing;

namespace NoteAppUI
{
    public partial class LookChordsForm : Form
    {
        public List<Chord> list = new List<Chord>();
		Bitmap bitmap;
		Graphics g;
		Chord newChord = new Chord();



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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

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

		private void DeleteItemButton_Click(object sender, EventArgs e)
		{

		}

		private void LookChordsForm_Load(object sender, EventArgs e)
        {
            list.ForEach(x => { listOfChords.Items.Add(x.Name); });
		}

		private void NoteBox_Paint(object sender, PaintEventArgs e)
		{
			g = noteBox.CreateGraphics();
		}

		private void NoteBox_MouseDown(object sender, MouseEventArgs e)
		{
			int x = e.X - 7;
			int y = e.Y - 7;
			g.DrawString("" + e.X+ " " + e.Y, DefaultFont, Brushes.Black, e.X, e.Y);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			int count = newChord.Frets.Count;
			for (int i = 0; i < count; i++)
			{
				
				g.FillEllipse(Brushes.Black, (int)newChord.Frets[i].GetValue(0) - 34, (int)newChord.Frets[i].GetValue(1) - 46, 10, 10);
			}
			
		}
	}
}
