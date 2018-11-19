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
        List<Chord> tempList = new List<Chord>();
        
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
			LookChordsForm look_chords = new LookChordsForm();
			tempList.ForEach(x => look_chords.list.Add(x));
			look_chords.ShowDialog();
		}

		private void Close_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Создается форма создания аккордов, и принимается оттуда новый аккорд, и сразу добавляется в глобальный список
		/// </summary>
		//private void Add_chord_Click(object sender, EventArgs e)
		//{
		//    AddChordForm add_chord = new AddChordForm();
		//    add_chord.ShowDialog();
		//    if (!string.IsNullOrEmpty(add_chord.newChord.Name))
		//    {
		//        tempList.Add(add_chord.newChord);
		//    }
		//}

	}
}