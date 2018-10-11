using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DFSUsingQueue
{
    class DFSUsingStack
    {
        static void DirDFS(string startPath)
        {
            try
            {
                DirectoryInfo currentDir = new DirectoryInfo(startPath);
                Stack<DirectoryInfo> visited = new Stack<DirectoryInfo>();
                visited.Push(currentDir);
                while (visited.Count > 0)
                {
                    currentDir = visited.Pop();
                    Console.WriteLine(currentDir.FullName);
                    List<DirectoryInfo> children = currentDir.GetDirectories().ToList();
                    foreach (var dir in children)
                    {
                        visited.Push(dir);
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("DNF");
            }

        }
        static void Main(string[] args)
        {
            DirDFS(@"d:\dropbox\autohit");
        }
    }
}
