// имаме подаване на 2та типа хора и роботи разбъркано
// как да ги добавим в лист който да ги помни правилно, няма как да е само Citizen няма как да е само Robot
// за това ще използваме интерфейс който има едното нещо което е еднакво и за 2та ID-то им

using BorderControl;

List<IIdentifiable> identifiers = new List<IIdentifiable>();

string input = Console.ReadLine();
while (input != "End")
{
    string[] data = input.Split();
    // тука правим една проста проверка за дължината на масива
    // ако тя е 3 то ще я добавим в клас Citizen, ако е 2 ще я добавим в клас Robot
    if (data.Length == 3) identifiers.Add(new Citizen(data[0], int.Parse(data[1]), data[2]));
    else if (data.Length == 2) identifiers.Add(new Robot(data[0], data[1]));

    input = Console.ReadLine();
}
string suffix = Console.ReadLine();
// въртим един цикъл който ще премине през всичките ID-та независимо от записаните Citizen или Robot
// ще провери дали имаме suffix-a и ако да ще изпише ID-то на робота или човека
foreach (IIdentifiable identifiable in identifiers)
{
    if (identifiable.Id.EndsWith(suffix)) Console.WriteLine(identifiable.Id);
}