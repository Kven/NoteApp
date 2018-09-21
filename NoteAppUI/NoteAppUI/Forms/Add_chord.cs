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
    public partial class Add_chord : Form
    {
        public Add_chord()
        {
            InitializeComponent();
            //this.Load += new EventHandler(Form_Load);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
            this.Close();
        }

        public void line()
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.Red), 10, 10, 100, 100);
        }

        private void Add_chord_Shown(object sender, EventArgs e)
        {
            line();
        }
    }















    /*
[DllImport("Gdi32.dll")]

public static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);

[DllImport("user32.dll")]

public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

void Form_Load(object sender, EventArgs e)
{
   IntPtr hRgn = CreateRoundRectRgn(7, 7, 425, 530, 30, 25);
   SetWindowRgn(this.Handle, hRgn, true);
}
//конец блока скругления углов
*/
}
