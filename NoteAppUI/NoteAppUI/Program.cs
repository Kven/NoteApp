using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Class;


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

            
            Chord Am = new Chord("Am");
            ChordsList List = new ChordsList();
            List.Add(0,Am);
            JsonFiles Json = new JsonFiles();
            Json.SaveFile(List);
        }
    }
}
