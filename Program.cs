using HomeWork_Basic_11_L035;

Console.WriteLine(" ---- Home work 11 ----\n");

OtusDictionary dictionary = new OtusDictionary();

dictionary.Add(1, "Республика Адыгея ");
dictionary.Add(2, "Республика Башкортостан ");
dictionary.Add(3, "Республика Бурятия");
dictionary.Add(4, "Республика Алтай");
dictionary.Add(5, "Республика Дагестан");
dictionary[6] = "Республика Ингушетия";
dictionary[7] = "Кабардино-Балкарская Республика";
dictionary[8] = "Республика Калмыкия";
dictionary[9] = "Республика Карачаево-Черкесия";
dictionary[32] = "Республика Карелия";
dictionary[66] = "Свердловская область";
dictionary[69] = "Тверская область";

Console.WriteLine(dictionary.Get(1));
Console.WriteLine(dictionary.Get(2));
Console.WriteLine(dictionary.Get(3));
Console.WriteLine(dictionary.Get(4));
Console.WriteLine(dictionary.Get(5));
Console.WriteLine(dictionary[6]);
Console.WriteLine(dictionary[7]);
Console.WriteLine(dictionary[8]);
Console.WriteLine(dictionary[9]);
Console.WriteLine(dictionary[32]);
Console.WriteLine(dictionary[66]);
Console.WriteLine(dictionary[69]);