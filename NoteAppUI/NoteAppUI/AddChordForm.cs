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
        
        /// <summary>
        /// 
        /// </summary>
        public AddChordForm()
        {
            
            InitializeComponent();
            noteBox.Image = new Bitmap(noteBox.Width, noteBox.Height);
            
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
                x = 55;
                y = 65;
                
            }
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteBox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteBox_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
