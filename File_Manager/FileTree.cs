using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace File_Manager
{
    /// <summary>
    /// Создается два списка: файлы и поддиректории в текущей директории
    /// </summary>
    public class FileTree
    {
        public static List<DirectoryInfo> DirectoryList = new List<DirectoryInfo>();
        public static List<FileInfo> FileList = new List<FileInfo>();
        
        /// <summary>
        /// В списки не включаются имена начинающиеся с '.' или длиннее 30-ти символов
        /// </summary>
        /// <param name="directory">Текущая директория</param>
        public static void CreateList(string directory)
        {
            DirectoryInfo path = new DirectoryInfo(directory);
            
            DirectoryList = (from d in path.GetDirectories()
                where !d.Name.StartsWith('.')
                where d.Name.Length < 30
                select d).ToList();

            FileList = (from f in path.GetFiles("*.*")
                where !f.Name.StartsWith('.')
                where f.Name.Length < 30
                select f).ToList();
        }

    }
}