using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_Manager
{
    class Parser
    {
        public static Comands Comand { get; private set; }
        public static string SourcePath { get; private set; }
        public static string DestPath { get; private set; }
        private static string s = @":\";

        public static void TryParseComand(string str)
        {
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if ((words.Length == 0) || (words.Length == 1 && (words[0] != "help" || words[0] != "exit")))
            {
                throw new InvalidOperationException("Неверная команда (используйте 'help')!");
            }
            if (words.Length >= 1)
            {
                Comand = words[0] switch
                {
                    "ls" => Comands.ls,
                    "cp" => Comands.cp,
                    "rm" => Comands.rm,
                    "inf" => Comands.inf,
                    "help" => Comands.help,
                    "exit" => Comands.exit,
                    _ => throw new InvalidOperationException($"Команда {words[0]} не поддерживается (используйте 'help')!"),
                };
            }
            if (words.Length >= 2)
            {
                if (File.Exists(words[1]) || Directory.Exists(words[1]))
                {
                    SourcePath = words[1];
                }
                else
                {
                    throw new FileNotFoundException("Такой папки или файла не существует!\n(первый  параметр)");
                }
            }
            if(words.Length>=3)
            {
                if(words[2].Contains(s))
                {
                    DestPath = words[2];
                }
            }
        }
    }
}