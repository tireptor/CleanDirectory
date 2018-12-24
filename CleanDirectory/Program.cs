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
            string[] myFolders = { @"E:\" }; // Déclarer les répertoires à parcourir dans ce tableau.

            FolderProcess.SearchFilesInFolders(myFolders);
            Console.WriteLine("Processus terminé !");
            Console.ReadKey();
        }
    }
}
