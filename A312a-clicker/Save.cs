using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A312a_clicker
{
    public static class Save
    {
        public static void SaveGame(
            string [] stuff)
        {
            //string[] stuff = {words, anton, lasse, casper, mads, ezzi, thue};

            using (StreamWriter sw = new StreamWriter("savegame1.txt"))
            {
                foreach(string item in stuff)
                {
                    sw.WriteLine(item);
                }
            }

            //File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), stuff);
        }
        public static string[] LoadGame()
        {
            string[] stuff = new string[7];
            string input;
            int i;
            using(StreamReader sr = new StreamReader("savegame1.txt"))
            {
                for (i = 0; (input = sr.ReadLine()) != null && i < 7; ++i)
                {
                    stuff[i] = input;
                }
            }
            return stuff;
        }
        public static void SaveOrLoadSuccessful(bool WasItASave)
        {
            string Success;
            if (WasItASave)
            {
                Success = "Game successfully saved!";
            }
            else
            {
                Success = "Game successfully loaded!";
            }
            string caption = "Success!";

            MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(Success, caption, buttons);
        }
    }
}
