

// Бих искал да използвам класовете от друг проект как да го направя?
// using _00.Demos няма да ми позволи въпреки че съществува
// трябва да отворя в проекта който ще го ползвам
// дясно копче на проекта ми Add -> Project Reference -> 00.Demos
// така вече излиза using _00.Demo; без проблеми
using _00.Demo;

Student student = new("Steve G", 19); // 12
Console.WriteLine(student.Name);
Console.WriteLine(student.Age);
student.PrintAvarageGrade();
// ако я пуснем така даже ще ни изпрати в другия проект при правилата за +18 годишен студент
// ще изпише грещка за да добавим валиден студент

// Encapsulation 
// Енкапсулацията скрива имплементацията
// намалявеа сложноста на кода
// структурните промени остават локални
// Mutable and Immutable обекти
// IReadOnlyCollection е immutable не може да види много неща от въшния свят