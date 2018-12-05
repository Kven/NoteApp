using NoteApp;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
		/// <summary>
		/// Глобальный список аккордов
		/// </summary>
        List<Chord> _tempList = new List<Chord>();
        
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
        private void Look_chords_Click(object sender, EventArgs e)
		{
			LookChordsForm lookChords = new LookChordsForm();
			_tempList.ForEach(x => lookChords.List.Add(x));
			lookChords.ShowDialog();
		}

		private void Close_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}