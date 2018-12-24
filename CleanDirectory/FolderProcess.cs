﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanDirectory
{
    abstract class FolderProcess
    {
        // Parcours des fichier d'un répertoire et de ses sous répertoire.
        public static void SearchFilesInFolders(string[] args)
        {
            foreach (string path in args)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    ProcessFile(path);
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessDirectory(path);
                }
                else
                {
                    Console.WriteLine("{0} is not a valid file or directory.", path);
                }
            }
        }
        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            // On récupère les info de notre fichier
            FileInfo file = new FileInfo(path);
            // On remplace les caractères non souhaités.
            string newFileName =  StringProcess.escape(file.Name);
            // On renomme le fichier
            file.Rename(newFileName);
            Console.WriteLine("Processed file '{0}'.", path);
        }
    }
}
