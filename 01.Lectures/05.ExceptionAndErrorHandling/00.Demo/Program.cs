using System;

int[] numbers = new int[3];

// ето две системни тип грешки
// numbers[5] = 240;
// System.Console.WriteLine(numbers[5]);
// като стигнем до такава грешка програмата забива
// как да се опазим от системна грешка?
try
{
    throw new ArgumentException();
    // тук имаме грешка
    numbers[5] = 240;
    // стига до тук и започва да търси в кода ни catch аргумент
    Console.WriteLine("This line will not be displayed"); // няма да изпише това
}
// скача на catch и изпълнява неговия изписан код
catch (Exception ex)
{
    Console.WriteLine("Something went wrong");
    Console.WriteLine(ex.Message); // изписва default massage - каква е грешката
    Console.WriteLine(ex.StackTrace); // тук изписва къде е грешката
}
// така ще видим този код
Console.WriteLine("End of Program");

// на принципа на stack се разрешават проблеми с Exception-ите
// започва от най-вътрешния метод в най-вътрешния клас и си работи излизането нагоре