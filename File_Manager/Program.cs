using System;
using System.IO;
using System.Text.Json;

namespace File_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Actions.Start();

            while (true)
            {
                Parser.TryParseComand(Console.ReadLine());
                if (Parser.Comand == Comands.Ls)
                    Actions.List();
                else if (Parser.Comand == Comands.Cp)
                    Actions.Copy();
                else if (Parser.Comand == Comands.Rm)
                    Actions.Delete();
                else if (Parser.Comand == Comands.Inf)
                    Actions.Info();
                else if (Parser.Comand == Comands.Help)
                    Actions.Help();
                else if (Parser.Comand == Comands.Exit)
                    Actions.Exit();
                else
                    throw new ArgumentOutOfRangeException();

                ConsoleWindow.Create();
            }
        }
    }
}