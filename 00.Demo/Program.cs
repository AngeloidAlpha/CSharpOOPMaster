// C#13 има Primary constructors
// public class Elf(string username, int level) : Hero (username, level)
// remove unnacesery usings (горе дет се появяват)
// Ctrl + R и после Ctrl + G 
// Ctrl + click -> go to definition - ще ни връща към описанието на метода в C#
// стилови преференции си ги създавамне на проектно ниво файл който после ще ни подсеща 
// как да си пишем кода за да е разбираем за екипа
// Ctrl + M + O закрива всичко
// Ctrl + M + E отваря всичко

using _00.Demo;

// Lab Lesson Encapsulation


Student student = new("Jurgen Klopp", 50);
// при капсулиран клас ще ни изпише грешка
// student.Name = "Jose Mourinho"; // public string Name { get; private set; }
// ще може да променим името на студента, но в доста случаи няма да искаме

// ще може да влезем и променим името на студента чрез метод в класа
// как ще променим годините на студента и видим дали е валидно?
try
{
    // защото Age е protected в Student вече мога да го достъпя само там от неговите наследници
    // student.Age = -151;
}
catch (Exception)
{
    Console.WriteLine("Tryed to change to an invalid Age");
}
// защото се опитахме да променим годините но не са валидни то не ги променихме
// по този начин капсулирахме до някаква степен кода
// даваме правилата на кода поради смисъла и контекста на използване
// за годините например трябва да не са по-малки от 18 години, да не са отрицателни, да не са прекалено големи и т.нат.

// искам да поставя оценки на нашия студент, но не всякакви а такива които аз искам
student.AddAvarageGrade("Math", 4.6);
student.AddAvarageGrade("BEL", 3.1);
// защото нямаме get и set тук няма да ни позволи да добавяме нещо невалидно което заобикаля условията ни
// student.AvarageGrades.Add("BEL", 15.20);
Console.WriteLine(student.Name);
// student.Age дава грешка защото е protected и няма да може да бъде извикан извън класа си и дъщерните класове
// Console.WriteLine(student.Age);
// за да изпишем годините може да създадем метод който да изписва на студента годините и да го извикаме него
student.PrintAvarageGrade();

Student studentCurrent = student.GetCurrent();

