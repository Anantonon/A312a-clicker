using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A312a_clicker
{
    public static class Save
    {
        public static void SaveGame(string wordnr, string antonnr)
        {
            string[] stuff = { wordnr, antonnr };

            System.IO.File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), stuff);
        }
    }
}
