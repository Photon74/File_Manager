using System;
using System.Collections.Generic;
using System.Text;

namespace File_Manager
{
    static class ConsoleWindow
    {
        public static string InfoText { get; set; }
        
        public static void Create()
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 45;
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            Console.Clear();

            Console.SetCursorPosition(4, 1);
            Console.Write("Directories List" + "                  " + "Files List");
            Console.SetCursorPosition(2, 2);
            Console.Write("====================" + "            " + "====================");
            Console.SetCursorPosition(2, Console.BufferHeight - 10);
            Console.Write("Info");
            for (int i = 1; i < Console.BufferWidth; i++)
            {
                Console.SetCursorPosition(i, Console.BufferHeight - 9);
                Console.Write('═');
            }
            for (int i = 1; i < Console.BufferWidth; i++)
            {
                Console.SetCursorPosition(i, Console.BufferHeight - 2);
                Console.Write('═');
            }
            
            for (int i = 0; i < FileTree.DirectoryList.Count; i++)
            {
                Console.SetCursorPosition(3, i + 3);
                Console.WriteLine(FileTree.DirectoryList[i].Name);
            }

            for (int i = 0; i < FileTree.FileList.Count; i++)
            {
                Console.SetCursorPosition(35, i + 3);
                Console.Write(FileTree.FileList[i].Name);
            }

            Actions.Info();
            Console.SetCursorPosition(3, Console.WindowHeight - 8);
            Console.Write(InfoText);
        }
    }
}