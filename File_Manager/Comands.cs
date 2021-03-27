using System;
using System.Collections.Generic;
using System.Text;

namespace File_Manager
{
    [Flags]
    enum Comands
    {
        ls, // Вывод дерева файловой системы
        cp, // Копирование каталога или файла
        rm, // Удаление каталога или файла
        inf, // Вывод информации
        help, // Справка
        exit // Выход из программы
    }
}