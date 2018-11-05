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
    public partial class AddChordForm : Form
    {

        public Chord newChord = new Chord();

        public AddChordForm()
        {
            InitializeComponent();
        }

        private void Сancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddChord_Click(object sender, EventArgs e)
        {
            newChord.Name = nameInput.Text;
            if (int.TryParse(beginInput.Text, out int bg))
            {
                if (bg >= 0 && bg <= 12)
                {
                    newChord.Begin = bg;
                }
                else
                {
                    MessageBox.Show("Не правильный лад");
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не число");
            }
            this.Close();
        }


        


    }
}
