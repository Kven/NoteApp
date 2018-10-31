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


            Chord am = new Chord("Am");
            Chord bm = new Chord("Bm");
            ChordsList list = new ChordsList();
            list.chordsList.Add(am);
            list.chordsList.Add(bm);
            Json json = new Json();
            json.SaveFile(list.chordsList);
            ChordsList list2 = new ChordsList();
            list2.chordsList = json.ReadFile();




        }

        private void Look_chords_Click(object sender, EventArgs e)
        {
            LookChordsForm look_chords = new LookChordsForm();
            //look_chords.Owner = this;
            look_chords.Show();
            //this.Hide();
            this.CenterToScreen();
        }

        private void Add_chord_Click(object sender, EventArgs e)
        {
            AddChordForm add_chord = new AddChordForm();
            add_chord.Owner = this;
            add_chord.Show();
            this.Hide();
            this.CenterToScreen();
        }


    }
}