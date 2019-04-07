using System;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
		/// <summary>
		/// Инициализация главной формы и дессериализация файла в глобальный список аккордов (импорт)
		/// </summary>
        public MainForm()
        {
            InitializeComponent();

        }

		/// <summary>
		/// Создается форма просмотра аккордов, туда передается глобальный списко аккордов
		/// </summary>
        private void ShowChordsButton_Click(object sender, EventArgs e)
		{
			LookChordsForm lookChords = new LookChordsForm();
			lookChords.ShowDialog();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}


	}


}