using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Ce programme permet de renommer tous les fichiers d'un répertoire. */
namespace CleanDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFolders =  ReadFromFile.ReadAllLine();
            if (myFolders.Length < 1)
            {
                Console.WriteLine("Il faut créer dans le même répertoire que cet exécutable un fichier directory_path.txt avec au minimum un chemin de répertoire à parcourir.");
                Console.ReadKey();
                return;
            }
            FolderProcess.SearchFilesInFolders(myFolders);
            Console.WriteLine("Processus terminé !");
            Console.ReadKey();
        }
    }
}
