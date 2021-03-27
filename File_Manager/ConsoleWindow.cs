using System;
using System.Collections.Generic;
using System.Text;

namespace File_Manager
{
    class ConsoleWindow
    {

        public static void Create()
        {
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
        }
    }
}