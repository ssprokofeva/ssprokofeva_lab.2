using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sstum
{
    //задание 1. Выведите на экран информацию о каждом типе данных в виде:Тип данных – максимальное значение – минимальное значение
 Console.WriteLine("задание 1");
 Console.WriteLine($"int: {int.MaxValue} - {int.MinValue}");
 Console.WriteLine($"long: {long.MaxValue} - {long.MinValue}");
 Console.WriteLine($"short: {short.MaxValue} - {short.MinValue}");
 Console.WriteLine($"byte: {byte.MaxValue} - {byte.MinValue}");
 Console.WriteLine($"double: {double.MaxValue} - {double.MinValue}");
 Console.WriteLine($"float: {float.MaxValue} - {float.MinValue}");
 Console.WriteLine($"decimal: {decimal.MaxValue} - {decimal.MinValue}");
 Console.WriteLine($"char: '{char.MaxValue}' - '{char.MinValue}'");
 Console.WriteLine($"bool: {true} - {false}");
}

//задание 2. Напишите программу, в которой принимаются данные пользователя в виде имени,города, возраста и PIN-кода.Далее сохраните все значение в соответствующей
//переменной, а затем распечатайте всю информацию в правильном формате.
Console.WriteLine("Задание 2"); Console.WriteLine("Введите ваше имя");
string name = Console.ReadLine(); Console.WriteLine("Введите ваш город");
string city = Console.ReadLine(); Console.WriteLine("Введите возраст");
string age = Console.ReadLine(); Console.WriteLine("Введите PIN-код");
string pin = Console.ReadLine(); Console.WriteLine($"Ваше имя: {name}, ваш город: {city}, ваш возраст: {age}, ваш PIN-код: {pin}");
  
//задание 3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.
Console.WriteLine("задание 3");
Console.Write("Введите строку: ");
string input = Console.ReadLine();
string result = string.Concat(str.Select(c => (char)(char.ToLower(c) ^ char.ToUpper(c) ^ c)));
Console.WriteLine("Преобразованная строка: " + result);
    }

// задание 4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.
Console.WriteLine("Введите строку: ");
string stroka = Console.ReadLine();
Console.WriteLine("Введите подстроку: ");
string podstroka = Console.ReadLine();
int count = new Regex(podstroka).Matches(stroka).Count;
Console.WriteLine(count);
// задание 5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
//покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена(normPrice),скидка в Duty Free(salePrice) и стоимость отпуска(holidayPrice).Например, если бутылка
//обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10 %, вы сэкономите 1 фунт стерлингов на каждой бутылке.Если ваш отпуск стоит 500 фунтов
//стерлингов, ответ, который вы должны вернуть, будет 500.Все входные данные будут целыми числами.Пожалуйста, верните целое число.Округлить в меньшую сторону.
// Ввод данных от пользователя.
    Console.WriteLine("задание 5.");
    Console.Write("Введите стандартную цену бутылки (normPrice): ");
    int normPrice = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите скидку в дьюти фри (salePrice в процентах): ");
    int salePrice = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите стоимость отпуска (holidayPrice): ");
    int holidayPrice = Convert.ToInt32(Console.ReadLine());
   double discount = normPrice * (salePrice / 100.0);
   Console.WriteLine($"Необходимое количество бутылок: {bottles}");
}


//Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского счета(текущий и сберегательный).Создать переменную типа перечисления, присвоить ей
//значение и вывести это значение на печать.
Console.WriteLine("упражанение 3.1");
enum AccountType
{
    Текущий, 
    Сберегатльный
}
/// <summary>
/// тип счета
/// </summary>
public int Number;
/// <summary>
/// тип счета
/// </summary>
public string Type;
/// <summary>
/// баланс
/// </summary>
public double Balance;
}
// Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском
//счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
//значениями и напечатать результат.
Console.WriteLine("упражнение 3.2");
BankAccount mybank = new BankAccount();
mybank.Number = 567234987;
mybank.Type = "текущий";
mybank.Balance = 123;
Console.WriteLine($"Номер счёта:{mybank.Number}, тип счёта:{mybank.Type}, баланс счёта:{mybank.Balance}");
//Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
//распечатать.
Console.WriteLine("домашнее задание 3.1");
BackgroundWorker worker = new BackgroundWorker();
worker .Name = "Софья";
worker.VUZ = VUZ.КГУ;
Console.WriteLine($"Имя работника:{worker.Name}, ВУЗ:{worker.Vuz}");
}
