using System;
using System.Windows.Forms;
using NoteApp;
using System.Collections.Generic;

namespace NoteAppUI
{
    public partial class LookChordsForm : Form
    {
        public List<Chord> list = new List<Chord>();

        public LookChordsForm()
        {
            InitializeComponent();
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
            list.Add(newChord);
            listOfChords.Items.Add(newChord.Name);

            
        
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void LookChordsForm_Load(object sender, EventArgs e)
        {
            list.ForEach(x =>
            {
                listOfChords.Items.Add(x.Name);
            });
        }
    }
}
