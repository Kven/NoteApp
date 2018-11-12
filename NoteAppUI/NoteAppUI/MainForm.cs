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
        List<Chord> List = new List<Chord>();
        
		/// <summary>
		/// Инициализация главной формы и дессериализация файла в глобальный список аккордов (импорт)
		/// </summary>
        public MainForm()
        {
            InitializeComponent();
			List = Json.ReadFile();	
		}

		/// <summary>
		/// Создается форма просмотра аккордов, туда передается глобальный списко аккордов
		/// </summary>
        private void Look_chords_Click(object sender, EventArgs e)
        {
            LookChordsForm look_chords = new LookChordsForm
            {
                list = List
            };
            look_chords.ShowDialog();
            List = look_chords.list;   
        }

		/// <summary>
		/// Создается форма создания аккордов, и принимается оттуда новый аккорд, и сразу добавляется в глобальный список
		/// </summary>
        private void Add_chord_Click(object sender, EventArgs e)
        {
            AddChordForm add_chord = new AddChordForm();
            add_chord.ShowDialog();
            if (add_chord.newChord.Name != null)
            {
                List.Add(add_chord.newChord);
            }
        }

		/// <summary>
		/// Перед закрытием формы сохраняет в файл глобальный список аккордов (экспорт)
		/// </summary>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Json.SaveFile(List);
		}
	}
}