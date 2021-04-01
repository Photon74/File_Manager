# File_Manager

## Простейший консольный файловый менеджер

<table class="memberdecls">
<tr ><td colspan="2"><h2 >
Классы</h2></td></tr>
<tr><td align="right" valign="top">class &#160;</td><td valign="bottom"><b>Actions</b></td></tr>
<tr><td>&#160;</td><td>В классе реализованы все команды, выполняемые программой <br /></td></tr>
<tr><td colspan="2">&#160;</td></tr>
<tr><td align="right" valign="top">class &#160;</td><td class="memItemRight" valign="bottom"><b>ConsoleWindow</b></td></tr>
<tr><td>&#160;</td><td class="mdescRight">Построение графического интерфейса и запонение его информацией <br /></td></tr>
<tr><td colspan="2">&#160;</td></tr>
<tr><td align="right" valign="top">class &#160;</td><td class="memItemRight" valign="bottom">FileTree</td></tr>
<tr><td>&#160;</td><td class="mdescRight">Создается два списка: файлы и поддиректории в текущей директории  <br /></td></tr>
<tr><td colspan="2">&#160;</td></tr>
<tr><td align="right" valign="top">class &#160;</td><td class="memItemRight" valign="bottom">Parser</td></tr>
<tr><td>&#160;</td><td class="mdescRight">Введенная пользователем строка делится непосредственно на саму команду и ее параметры  <br /></td></tr>
<tr><td colspan="2">&#160;</td></tr>
<tr><td align="right" valign="top">class &#160;</td><td class="memItemRight" valign="bottom"> Program </td></tr>
<tr><td colspan="2">&#160;</td></tr>
<tr><td align="right" valign="top">class &#160;</td><td class="memItemRight" valign="bottom">Warning</td></tr>
<tr><td>&#160;</td><td class="mdescRight">Выводит окно с предупреждением при удалении файла или каталога  <br /></td></tr>
<tr><td colspan="2">&#160;</td></tr>
</table>

<table>
<tr>
<td colspan="2"><h2>Перечисление</h2></td></tr>
<tr ><td align="right" valign="top">enum class &#160;</td>
<td valign="bottom"> Comands </td>
</tr>
  <tr></tr>
<tr><td>Ls</td> <td><p>Вывод дерева файловой системы </p>
</td></tr>
<tr><td>Cp</td><td><p>Копирование каталога или файла </p>
</td></tr>
<tr><td></a>Rm</td><td><p>Удаление каталога или файла </p>
</td></tr>
<tr><td></a>Inf</td><td><p>Вывод информации о каталоге или файле </p>
</td></tr>
<tr><td></a>Help</td><td><p>Справка </p>
</td></tr>
<tr><td></a>Exit</td><td><p>Выход из программы </p>
</td></tr>
</table>
