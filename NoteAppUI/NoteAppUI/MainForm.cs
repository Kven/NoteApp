using NoteApp;
using System;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Look_chords_Click(object sender, EventArgs e)
        {
            LookChordsForm look_chords = new LookChordsForm();
            look_chords.ShowDialog();
            
        }

        private void Add_chord_Click(object sender, EventArgs e)
        {
            AddChordForm add_chord = new AddChordForm();
            add_chord.ShowDialog();
    
        }


    }
}