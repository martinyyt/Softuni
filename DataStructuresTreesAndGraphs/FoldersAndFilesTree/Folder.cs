using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure;
using System.IO;

namespace FoldersAndFilesTree
{
    class Folder
    {
        private string name;
        private File[] files;
        private Folder[] childFolders;

        private Folder(string name, File[] files, Folder[] childFolders) // is this useful??
        {
            this.name = name;
            this.files = files;
            this.childFolders = childFolders;
        }
        public Folder(string name)
        {
            //this.name = name;
            this.name = new DirectoryInfo(name).FullName; // to be sure to get the fullname of the folder if given relative path!!!
            this.childFolders = null;
            this.files = null;
            this.GetSubfoldersAndFiles();
        }


        public string Name { get => name; set => name = value; }
        public File[] Files { get => files; set => files = value; }
        public Folder[] ChildFolders { get => childFolders; set => childFolders = value; }

        private void GetSubfoldersAndFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(this.Name);

            List<DirectoryInfo> childrenDirs = directory.GetDirectories().ToList();
            this.ChildFolders = new Folder[childrenDirs.Count];
            for (int i = 0; i < childrenDirs.Count; i++)
            {
                this.ChildFolders[i] = new Folder(childrenDirs[i].FullName);
                childFolders[i].GetSubfoldersAndFiles();
            }

            List<FileInfo> childrenFiles = directory.GetFiles().ToList();
            this.Files = new File[childrenFiles.Count];
            for (int i = 0; i < childrenFiles.Count; i++)
            {
                this.Files[i] = new File(childrenFiles[i].Name, childrenFiles[i].Length);
            }
        }

        public void PrintFilesAndFolders()
        {
            Stack<Folder> folders = new Stack<Folder>();
            folders.Push(this);
            Folder currentFolder = null;
            while (folders.Count>0)
            {
                currentFolder = folders.Pop();
                Console.WriteLine(currentFolder.Name);
                foreach (var file in currentFolder.Files)
                {
                    Console.WriteLine(file.Name+" / fileSize: "+file.Size);
                }
                foreach (var child in currentFolder.ChildFolders)
                {
                    folders.Push(child);
                }
            }
        }
        public long GetTotalSizeOfFiles()
        {
            long totalSize = 0;
            Stack<Folder> folders = new Stack<Folder>();
            folders.Push(this);
            Folder currentFolder = null;
            while (folders.Count > 0)
            {
                currentFolder = folders.Pop();                
                foreach (var file in currentFolder.Files)
                {
                    totalSize+=file.Size;
                }
                foreach (var child in currentFolder.ChildFolders)
                {
                    folders.Push(child);
                }
            }
            return totalSize;
        }
    }
}
