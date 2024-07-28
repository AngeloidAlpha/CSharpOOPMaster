namespace Box;
public static class Program
{
    public static void Main(string[] args)
    {
        // искаме да видим за подадените ни данни
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        try
        {
            // създаваме кутия с тези параметри
            // ако създам кутията преди да съм погледнал параметрите си "try" в Box класа то ще ми ги валидира с негативни
            // и покаже грешка на ред който е с проверката
            Box box = new Box(length, width, height);
            // изписваме информацията за тази кутия
            Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.Volume():f2}");
        }
        // трябва да изпишем въпрос за негативни подадени данни (ще изпише грешка ако не го направим)
        // питаме с try ако всичко е валидно изпиши горните
        // в противен случай catch (да вземе дадения throw в параметър) и да достъпим неговото съобщение с e.Message
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}