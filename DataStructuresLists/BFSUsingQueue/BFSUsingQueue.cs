using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BFSUsingQueue
{
    class BFSUsingQueue
    {
        static void DirBFS(string startDir)
        {
            try
            {
                DirectoryInfo currentDir = new DirectoryInfo(startDir);
                List<DirectoryInfo> children = currentDir.GetDirectories().ToList();
                Queue<DirectoryInfo> visited = new Queue<DirectoryInfo>();
                visited.Enqueue(currentDir);

                while (visited.Count > 0)
                {
                    currentDir = visited.Dequeue();
                    Console.WriteLine(currentDir.FullName);
                    children = currentDir.GetDirectories().ToList();
                    foreach (var dir in children)
                    {
                        visited.Enqueue(dir);
                    }                    
                }
            }
            catch (System.UnauthorizedAccessException)
            {
                Console.WriteLine("no access");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("wrong path");
            }
        }
        static void Main(string[] args)
        {
            DirBFS(@"D:\Work");
        }
    }
}
