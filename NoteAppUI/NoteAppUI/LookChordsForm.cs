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

        private void back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
            this.Close();
            
        }

        private void add_chord_Click(object sender, EventArgs e)
        {
            Chord newChord = new Chord("Am7");
            BrowseChord.Items.Add(newChord.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
