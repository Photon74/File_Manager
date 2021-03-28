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
        private static readonly string s = @":\";

        public static void TryParseComandLine(string str)
        {
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0)
            {
                throw new InvalidOperationException("Команда не может быть пустой (используйте 'help')!");
            }
            if (words.Length >= 1)
            {
                words[0] = words[0].ToLower();
                Comand = words[0] switch
                {
                    "ls" => Comands.Ls,
                    "cp" => Comands.Cp,
                    "rm" => Comands.Rm,
                    "inf" => Comands.Inf,
                    "help" => Comands.Help,
                    "exit" => Comands.Exit,
                    _ => throw new InvalidOperationException(
                        $"Команда {words[0]} не поддерживается (используйте 'help')!"),
                };
            }
            if (words.Length >= 2)
            {
                words[1] = words[1].ToLower();
                if (File.Exists(words[1]) || Directory.Exists(words[1]))
                {
                    SourcePath = words[1];
                }
                else
                {
                    throw new FileNotFoundException($"Такой папки или файла не существует!\n   {words[1]} - проверьте написание!");
                }
            }
            if(words.Length>=3)
            {
                words[2] = words[2].ToLower();
                if(words[2].Contains(s))
                {
                    DestPath = words[2];
                }
            }
        }
    }
}