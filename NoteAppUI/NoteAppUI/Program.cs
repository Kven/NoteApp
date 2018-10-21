using System;
using System.Windows.Forms;
using NoteApp;
using NoteAppUI;


namespace NoteAppUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());

            
            Chord am = new Chord("Am");
            ChordsList list = new ChordsList();
            list.Add(0, am);
            JsonFiles json = new JsonFiles();
            json.SaveFile(list);
        }
    }
}
