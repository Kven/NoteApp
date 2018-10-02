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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void Look_chords_Click(object sender, EventArgs e)
        {
            Look_chords look_chords = new Look_chords();
            look_chords.Owner = this;
            look_chords.Show();
            this.Hide();
            this.CenterToScreen();
        }

        private void Add_chord_Click(object sender, EventArgs e)
        {
            Add_chord add_chord = new Add_chord();
            add_chord.Owner = this;
            add_chord.Show();
            this.Hide();
            this.CenterToScreen();
        }
    }
}