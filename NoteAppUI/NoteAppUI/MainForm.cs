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
            this.Load += new EventHandler(MainMenu_Load);
        }

        [DllImport("Gdi32.dll")]

        public static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);

        [DllImport("user32.dll")]

        public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        void MainMenu_Load(object sender, EventArgs e)
        {
                IntPtr hRgn = CreateRoundRectRgn(7, 7, 425, 530, 30, 25);
                SetWindowRgn(this.Handle, hRgn, true);
        }
    }
}