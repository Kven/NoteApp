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

        public LookChordsForm()
        {
            InitializeComponent();
            noteBox.Image = new Bitmap(noteBox.Width, noteBox.Height);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Add_chord_Click(object sender, EventArgs e)
        {
            AddChordForm addChordForm = new AddChordForm();
            addChordForm.ShowDialog();
            Chord newChord = new Chord
            {
                Name = addChordForm.newChord.Name,
                Begin = addChordForm.newChord.Begin
            };
            if (newChord.Name != null)
            {
                list.Add(newChord);
                listOfChords.Items.Add(newChord.Name);
            }

            
        
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void LookChordsForm_Load(object sender, EventArgs e)
        {
            list.ForEach(x => { listOfChords.Items.Add(x.Name); });


            using (Graphics g = Graphics.FromImage(noteBox.Image))
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
            }
        }
    }
}
