# Лабораторная работа 'Телефонный справочник' (C#, Command pattern)

Необходимо реализовать консольную программу с функциональностью телефонного справочника.

В консоли программа принимает следующие команды:

*Добавить +79058023741 Голубятников Т.В.*<br />
*Добавить 02 Полиция*<br />
*Добавить 04 Служба газа*

Эта команда добавляет в справочник соответствующее телефону ФИО. Телефон не содержит пробелов.

*Найти 02*<br />
*Найти Служба газа*<br />
*Найти газ*

Эта команда выводит всех абонентов, номер телефона или имя которых содержит приведённый текст.

*Удалить 02*<br />
*Удалить Голубятников Т.В.*

Эта команда удаляет запись, телефон или название которой строго соответствует аргументу.

*Выход*

Эта команда сообщает системе что нужно прекратить принимать команды и завершить выполнение приложения.

При реализации этой программы необходимо создать

1.	Интерфейс или абстрактный класс команды **ICommand**. Класс команды содержит один метод: выполнить команду, в качестве аргументов принимает строку, которая вызвала выполнение команды<br />
2.	Интерфейс или абстрактный класс хранилища телефонов **IPhoneStorage** с тремя методами:<br />
a.	**Add(<класс данных>)**<br />
b.	**Remove(<класс данных>)**<br />
c.	**Enumerate()** – процедура перечисления всех имеющиеся в хранилище телефонов. Тип возвращаемого значения – **IEnumerable<класс данных>**.<br />
3.	Фасадный класс цикла обработки команд **CommandLoop** который содержит единственный публичный метод **DoLoop()**, который выполняется до тех пор, пока не будет вызвана команда *Выход*. Содержит внутри себя экземпляры классов фабрики команд и хранилища телефонов.<br />
4.	Класс данных который содержит два строковых поля: номер телефона и название абонента<br />
5.	Фабрику команд **CommandFactory**, которая принимает строку для выполнения и объект типа **IPhoneStorage**, а возвращает объект команды.
Фабрика читает первую часть строки и выбирает конкретную реализацию команды. Команды могут обратиться к экземпляру реализующему **IPhoneStorage** для работы со списком телефонов. Для сообщения циклу **CommandLoop** о том, что чтение команд необходимо прекратить и завершить **DoLoop()** команда *Выход* должна бросать исключение типа **RequireLoopStopException** (класс исключения нужно создать), которое должно обрабатываться в **DoLoop()**.<br />
6.	4 класса реализующих команды *Добавить*, *Найти*, *Удалить* и *Выход*.
