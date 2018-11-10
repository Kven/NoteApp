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
        /// <summary>
        /// 
        /// </summary>
        public Chord newChord = new Chord();
		Bitmap bitmap;
		Graphics g;

        /// <summary>
        /// 
        /// </summary>
        public AddChordForm()
        {
            InitializeComponent();
			bitmap = new Bitmap(noteBox.Width, noteBox.Height);
        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Сancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChordForm_Load(object sender, EventArgs e)
        {
			using (g = Graphics.FromImage(bitmap))
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
				x = 55;
				y = 65;
			}
			noteBox.Image = bitmap;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            name.Text = nameInput.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeginInput_TextChanged(object sender, EventArgs e)
        {
            begin.Text = beginInput.Text;
        }

		private void NoteBox_MouseDown(object sender, MouseEventArgs e)
		{
			int x = e.X - 7;
			int y = e.Y - 7;
			g.FillEllipse(Brushes.Black, x, y, 15, 15);
			newChord.SetFretsCoor(x, y);
			g.DrawString("" + e.X + " " + e.Y, DefaultFont, Brushes.Black, e.X, e.Y);
		}

		private void NoteBox_Paint(object sender, PaintEventArgs e)
		{
			g = noteBox.CreateGraphics();
			
		}

		private void Clear_Click(object sender, EventArgs e)
		{
			noteBox.Refresh();
		}
	}
}
