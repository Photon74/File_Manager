using System;

namespace File_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 45;
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);

            Actions.StartApp();

            while (true)
            {
                try
                {
                    Parser.TryParseComandLine(Console.ReadLine());

                    if (Parser.Comand == Comands.Ls)
                    {
                        Actions.CreateListsOfFilesAndDirectories();
                        ConsoleWindow.InfoText = Actions.GetDefaultInfo();
                    }

                    else if (Parser.Comand == Comands.Cp)
                    {
                        Actions.CopyFileOrDirectory();
                        Actions.CreateListsOfFilesAndDirectories();
                        ConsoleWindow.InfoText = Actions.GetDefaultInfo();
                    }

                    else if (Parser.Comand == Comands.Rm)
                    {
                        ConsoleWindow.Draw();
                        Warning.Caution();
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            Actions.FileOrDirectory();
                        }
                        Actions.CreateListsOfFilesAndDirectories();
                        ConsoleWindow.InfoText = Actions.GetDefaultInfo();
                    }

                    else if (Parser.Comand == Comands.Inf)
                    {
                        ConsoleWindow.InfoText = Actions.GetAskedInfo();
                    }

                    else if (Parser.Comand == Comands.Help)
                    {
                        ConsoleWindow.InfoText = Actions.GetHelp();
                    }

                    else if (Parser.Comand == Comands.Exit)
                    {
                        Actions.ExitApp();
                    }

                    else
                        throw new ArgumentOutOfRangeException();
                }
                // При возникновении любого исключения, его текстовое сообщение выводится в область информации
                catch (Exception e)
                {
                    ConsoleWindow.InfoText = e.Message;
                }

                ConsoleWindow.Draw();
            }
        }
    }
}