using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CleanDirectory
{
    abstract class ReadFromFile
    {
        public static string[] ReadAllLine()
        {
            string[] emptyArray = { "" };
            // Récupère le chemin du répertoire à parcourir dans le fichier texte : directory_path.txt.
            FileInfo file = new FileInfo("directory_path.txt");
            if ( ! file.Exists)
            {
                Console.WriteLine("Le fichier directory_path.txt est introuvable à la racine de l'exécutable !");
                return emptyArray;
            }
            string[] lines = System.IO.File.ReadAllLines(file.Name);
            return lines;
        }
    }
}
