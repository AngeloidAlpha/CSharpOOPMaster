using Telephony;

string[] phoneNumbers = Console.ReadLine().Split();
string[] websites = Console.ReadLine().Split();

// в случая тези класове са само за да могат да изпишат методите в тях
SmartPhone smartPhone = new SmartPhone();
StationaryPhone stationaryPhone = new StationaryPhone();

// правим 2 цикъла да преминем през всички номера
foreach (string phoneNumber in phoneNumbers)
{
    // питаме тея номера дали съдържат други символи освен цифри ако да да изпишем че е грешен
    // ако е верен и е според броя цифри то да извикаме създадения клас и неговия метод (а метода е присвоен от празния метод на интерфейса)
    if (phoneNumber.Any(s => !char.IsDigit(s))) Console.WriteLine("Invalid number!");
    else if (phoneNumber.Length == 10) Console.WriteLine(smartPhone.Call(phoneNumber));
    else if (phoneNumber.Length == 7) Console.WriteLine(stationaryPhone.Call(phoneNumber));
}

foreach (string website in websites)
{
    // същото и тук само че с проверката за сайтове
    if (website.Any(s => char.IsDigit(s))) Console.WriteLine("Invalid URL!");
    else Console.WriteLine(smartPhone.Browse(website));
}