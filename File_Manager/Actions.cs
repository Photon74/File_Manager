using System;

namespace File_Manager
{
    public class Actions
    {
        public void List()      // разбиение списка файлов и директорий на страницы и его вывод
        {
            
        }

        public void Delete()    // удаление файла или каталога
        {
            
        }

        public void Copy()      // копирование файла или каталога
        {
            
        }

        public string Info()    // вывод информации о файле или каталоге
        {
            return "";
        }

        public string Help()    // вывод справочной информации
        {
            return $@"Вывод дерева файловой системы:     ls C:\Source [-p1..n] - для постраничного вывода
 Копирование каталога:              cp C:\Source D:\Target\n
 Копирование файла:                 cp C:\source.txt D:\target.txt
 Удаление каталога рекурсивно:      rm C:\Source
 Удаление файла:                    rm C:\source.txt
 Вывод информации:                  inf C:\source.txt";
        }

        public void Exit()      // выход из программы
        {
            // todo Save state to file
            Environment.Exit(0);
        }
    }
}