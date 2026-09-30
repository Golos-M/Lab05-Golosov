int dayNumber = 7;
switch (dayNumber){
    case 6 or 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}

Console.WriteLine();

int score = 78;
switch (score){
    case >= 0 and < 50:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 50 and < 70:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 70 and < 85:
        Console.WriteLine("Хорошо");
        break;
    case >= 85 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}

Console.WriteLine();

int score = 78;
string result = score switch {
    >= 85 => "Отлично",
    >= 70 => "Хорошо",
    >= 50 => "Удовлетворительно",
    >= 0 => "Неудовлетворительно",
    _ => "Некорректный балл"
};
Console.WriteLine(result);



int t = 20;
string c = t switch {
    < 0 => "Мороз",
    >= 0 and <= 14 => "Прохладно",
    >= 15 and <= 24 => "Комфортно",
    >= 25 and <= 34 => "Жарко",
    >= 35 => "Очень жарко",
    _ => "Некорректная температура"
};
Console.WriteLine(c);



string role = "user";
string result = role switch {
    "admin" => "Полный доступ",
    not "admin" => "Ограниченный доступ"
};
Console.WriteLine(result);



string a = "teacher";
string b = a switch {
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    _ => "Ограниченный доступ"
};
Console.WriteLine(b);



int age = 20;
bool hasTicket = true;
switch (age){
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}



int age = 20;
bool hasTicket = true;
if (age >= 18 && hasTicket)
{
    Console.WriteLine("Вход разрешён");
}
else if (age >= 18 && !hasTicket)
{
    Console.WriteLine("Нет билета");
}
else
{
    Console.WriteLine("Возраст не подходит");
}



int level = 2;
switch (level)
{
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}


//Задача А
int month = 3;
string season = month switch {
    1 or 12 or 2 => "Зима",
    3 or 4 or 5 => "Весна",
    6 or 7 or 8 => "Лето",
    9 or 10 or 11 => "Осень",
    _ => "Неверный месяц"
};
Console.WriteLine(season);



//Задача Б
int age = 25;
string category = age switch {
    < 0 => "Ошибка",
    >= 0 and <= 6 => "Ребёнок",
    >= 7 and <= 17 => "Подросток",
    >= 18 and <= 64 => "Взрослый",
    >= 65 => "Пенсионер"
};
Console.WriteLine(category);