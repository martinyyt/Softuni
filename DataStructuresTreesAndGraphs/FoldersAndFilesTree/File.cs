using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructure;
using System.IO;

namespace FoldersAndFilesTree
{
    class File
    {
        private string name;
        private long size;

        public File(string name, long size)
        {
            this.name = name;
            this.size = size;
        }

        public string Name { get => name; set => name = value; }
        public long Size { get => size; set => size = value; }

    }
}
