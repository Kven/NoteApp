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
            if (nameInput.Text == "")
            {
                MessageBox.Show("Введите название аккорда");
            }
            else
            {
                newChord.Name = nameInput.Text;
            }

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
                else if (beginInput.Text == "")
                {
                    MessageBox.Show("Введите начальный лад");
                }
            if (beginInput.Text != "" && nameInput.Text != "")
                this.Close();
        }

      
        private void AddChordForm_Load(object sender, EventArgs e)
        {
            noteBox.Image = new Bitmap(noteBox.Width,noteBox.Height);
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
