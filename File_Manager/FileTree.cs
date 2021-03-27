using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace File_Manager
{
    public class FileTree
    {
        public static List<DirectoryInfo> DirectoryList = new List<DirectoryInfo>();
        public static List<FileInfo> FileList = new List<FileInfo>();

        public static void CreateList(string currentDirectory)
        {
            DirectoryInfo path = new DirectoryInfo(currentDirectory);

            DirectoryList = (from d in path.GetDirectories()
                where !d.Name.StartsWith('.')
                where d.Name.Length < 20
                select d).ToList();

            FileList = (from f in path.GetFiles("*.*")
                where !f.Name.StartsWith('.')
                where f.Name.Length < 20
                select f).ToList();
        }

    }
}