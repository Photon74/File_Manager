using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace File_Manager
{
    public static class Actions
    {
        public static string CurrentDirectory { get; private set; }

        public static void Start()
        {
            string json = File.ReadAllText(@"C:\Users\Photo\RiderProjects\File_Manager\File_Manager\options.json");
            CurrentDirectory = JsonSerializer.Deserialize<string>(json);
            FileTree.CreateList(CurrentDirectory);
            ConsoleWindow.Create();
        }
        public static void List()      // разбиение списка файлов и директорий на страницы и его вывод
        {
            CurrentDirectory = Parser.SourcePath;
            FileTree.CreateList(Parser.SourcePath);
        }

        public static void Delete()    // удаление файла или каталога
        {
            if (Path.HasExtension(Parser.SourcePath))
            {
                File.Delete(Parser.SourcePath);
            }
            else
            {
                Directory.Delete(Parser.SourcePath, true);
            }
        }

        public static void Copy()      // копирование файла или каталога
        {
            if (Path.HasExtension(Parser.SourcePath))
            {
                File.Copy(Parser.SourcePath, Parser.DestPath);
            }
            else
            {
                Process proc = new Process
                {
                    StartInfo =
                    {
                        UseShellExecute = true,
                        FileName = @"C:\WINDOWS\system32\xcopy.exe",
                        Arguments = $"{Parser.SourcePath} {Parser.DestPath} /E /I"
                    }
                };
                proc.Start();
            }
        }

        public static void Info()    // вывод информации о файле или каталоге
        {
            ConsoleWindow.InfoText = $"Текущая директория \"{CurrentDirectory}\" содержит {Directory.GetDirectories(CurrentDirectory).Length} поддиректорий и {Directory.GetFiles(CurrentDirectory).Length} файлов (скрытые не показаны)";
        }

        public static void Help()    // вывод справочной информации
        {
            ConsoleWindow.InfoText = $@"Вывод дерева файловой системы:     ls C:\Source [-p1..n] - для постраничного вывода
 Копирование каталога:              cp C:\Source D:\Target\n
 Копирование файла:                 cp C:\source.txt D:\target.txt
 Удаление каталога рекурсивно:      rm C:\Source
 Удаление файла:                    rm C:\source.txt
 Вывод информации:                  inf C:\source.txt";
        }

        public static void Exit()      // выход из программы
        {
            string json = JsonSerializer.Serialize(CurrentDirectory);
            File.WriteAllText(@"C:\Users\Photo\RiderProjects\File_Manager\File_Manager\options.json", json);
            
            Environment.Exit(0);
        }
    }
}