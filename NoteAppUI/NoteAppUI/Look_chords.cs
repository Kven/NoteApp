using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NoteApp;

namespace NoteAppUI
{
    public partial class Look_chords : Form
    {
        private ChordsList List = new ChordsList();

        public Look_chords()
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
    }
}
