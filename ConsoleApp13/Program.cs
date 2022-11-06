//Миронова Анастасия 22-ИСП-2/1
//5.2 Вариант 4
//Уровень Сложный
Console.WriteLine("В зад*нной стр*ке за*енить каж*ый символ * числом, соо*ветствующим номер* по пор*дку");
string s = "В зад*нной стр*ке за*енить каж*ый символ * числом, соо*ветствующим номер* по пор*дку";
string result = string.Empty;
for (int i = 0; i < s.Length; i++)
    if (s[i].Equals('*'))
        result += i + 1;
    else
        result += s[i];


Console.Write(result);