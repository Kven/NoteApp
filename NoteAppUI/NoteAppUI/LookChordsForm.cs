using System;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class LookChordsForm : Form
    {
        private ChordsList List = new ChordsList();

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
            Chord newChord = new Chord("Am7");
            BrowseChord.Items.Add(newChord.Name);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
