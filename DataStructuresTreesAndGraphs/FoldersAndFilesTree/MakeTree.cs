using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure;
using System.IO;

namespace FoldersAndFilesTree
{
    class MakeTree
    {
        //public static void GetSubfoldersAndFiles(Folder root)
        //{
        //    DirectoryInfo directory = new DirectoryInfo(root.Name);

        //    List<DirectoryInfo> childrenDirs = directory.GetDirectories().ToList();
        //    root.ChildFolders = new Folder[childrenDirs.Count];
        //    for (int i = 0; i < childrenDirs.Count; i++)
        //    {
        //        root.ChildFolders[i] = new Folder(childrenDirs[i].FullName);
        //        GetSubfoldersAndFiles(root.ChildFolders[i]);
        //    }

        //    List<FileInfo> childrenFiles = directory.GetFiles().ToList();
        //    root.Files = new File[childrenFiles.Count];
        //    for (int i = 0; i < childrenFiles.Count; i++)
        //    {
        //        root.Files[i] = new File(childrenFiles[i].Name, childrenFiles[i].Length);                
        //    }
        //}


        public static void Main()
        {
            Folder root = new Folder(@"..\..");
            //GetSubfoldersAndFiles(root); // this goes into the constructor of class Folder!!!

            root.ChildFolders[2].PrintFilesAndFolders();
            Console.WriteLine();

            root.PrintFilesAndFolders();
            Console.WriteLine();

            Console.WriteLine(root.ChildFolders[2].Name + "\\" + root.ChildFolders[2].Files[0].Name);
            Console.WriteLine();


        }
    }
}
