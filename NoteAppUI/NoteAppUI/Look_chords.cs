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
        public Look_chords()
        {
            InitializeComponent();
            //this.Load += new EventHandler(Form_Load);
        }
        /*
        // Блок скругления углов
        [DllImport("Gdi32.dll")]

        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("user32.dll")]

        public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        void Form_Load(object sender, EventArgs e)
        {
            IntPtr hRgn = CreateRoundRectRgn(7, 7, 425, 530, 30, 25);
            SetWindowRgn(this.Handle, hRgn, true);
        }
         //конец блока скругления
         */

        private void back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
            this.Close();
            
        }
       
    }
}
