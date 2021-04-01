using System;
using System.Collections.Generic;
using System.Text;

namespace File_Manager
{
    /// <summary>
    /// Выводит окно с предупреждением при удалении файла или каталога
    /// </summary>
    class Warning
    {
        public static void Caution()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2);
            Console.Beep(40, 250);
            Console.Write(new string('-', 26));
            Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2 + 1);
            Console.Write("|      Вы уверены?       |");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2 + 2);
            Console.Write(@"|'Нет'(Esc) / 'Да'(Enter)|");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2 + 3);
            Console.Write(new string('-', 26));
            Console.ResetColor();
            Console.SetCursorPosition(1, Console.BufferHeight - 1);
            Console.Write(Actions.CurrentDirectory + " >");
            Console.Beep(50, 500);
        }
    }
}
