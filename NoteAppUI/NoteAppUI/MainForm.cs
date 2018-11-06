using NoteApp;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        List<Chord> List = new List<Chord>();
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void Look_chords_Click(object sender, EventArgs e)
        {
            LookChordsForm look_chords = new LookChordsForm
            {
                list = List
            };
            look_chords.ShowDialog();
            List = look_chords.list;
            
        }

        private void Add_chord_Click(object sender, EventArgs e)
        {
            AddChordForm add_chord = new AddChordForm();
            add_chord.ShowDialog();
            List.Add(add_chord.newChord);
    
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Json.SaveFile(List);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            List = Json.ReadFile();
        }
    }
}