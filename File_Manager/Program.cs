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

            Actions.Start();
            Actions.

            while (true)
            {
                try
                {
                    Parser.TryParseComandLine(Console.ReadLine());

                    if (Parser.Comand == Comands.Ls)
                    {
                        Actions.CreateLists();
                        ConsoleWindow.InfoText = Actions.DefaultInfo();
                    }

                    else if (Parser.Comand == Comands.Cp)
                    {
                        Actions.Copy();
                        Actions.CreateLists();
                        ConsoleWindow.InfoText = Actions.DefaultInfo();
                    }

                    else if (Parser.Comand == Comands.Rm)
                    {
                        ConsoleWindow.Draw();
                        Warning.Caution();
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            Actions.Delete();
                        }
                        Actions.CreateLists();
                        ConsoleWindow.InfoText = Actions.DefaultInfo();
                    }

                    else if (Parser.Comand == Comands.Inf)
                    {
                        ConsoleWindow.InfoText = Actions.Info();
                    }

                    else if (Parser.Comand == Comands.Help)
                    {
                        ConsoleWindow.InfoText = Actions.Help();
                    }

                    else if (Parser.Comand == Comands.Exit)
                    {
                        Actions.Exit();
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