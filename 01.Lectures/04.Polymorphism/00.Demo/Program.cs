using _00.Demo;

public class Program
{
    static void Main(string[] args)
    {
        //Lamb recipe = new Lamb();
        IRecipe recipe = new Tiramisu();
        // за да извикаме метода създаваме нов готвач от клас Cheff
        // и го караме да направи метода Cook(който съдъеца recipe)
        // a recipe е вързан към IRecipe (където има 3те основни неща които трябва да знаем за рецептата (продукти, как се приготвя, и колко време)
        // като връща само данните които искаме да знаем за нея
        Cheff cheff = new();
        cheff.Cook(recipe);
        // по този начин като сме изкарали Cook метода в клас Cheff ние може да извикаме директно
        // класа Lamb lamb = new Lamb();
        Lamb lamb = new Lamb();
        cheff.Cook(lamb);
        // това е така защото iRecipe е имплементиран във всеки клас
        // идеята на полиморфизма е да създадем нещо което може да приеме много различни лица

        // ако наследим Musaka параметрите в VegetbleMusaka то може да извикаме това:
        Musaka musaka = new VegetableMusaka();
        cheff.Cook(musaka);
        // това ще работи защото наследниците могат напълно да заместват родителите
        // VegetableMusaka() наследи всички параметри вече описани в Musaka класа това е Полиморфизъм

        // има ситуации в които обаче нещата са нежелани например
        Pharmacist pharmacist = new();
        pharmacist.CreateMedicine(new CoughSyrup());
        pharmacist.CreateMedicine(lamb); //извиквам фармацефтас да прави агнешко

        // всичко в във C# наследява object
        // създаване на обект
        object obj = new VegetableMusaka();
        Musaka muska1 = new VegetableMusaka();

        // как да кастнем
        // IRecipe има само 3те си свои методи
        // VegetableMusaka ползва и методите в себе си и тези на родителите му
        // като вече го кастнем до тази променлива vegetableMusaka може да ползваме всичките методи дори тези на IRecipe

        IRecipe recipe1 = new VegetableMusaka();
        VegetableMusaka vegetableMusaka = (VegetableMusaka)recipe1;
        vegetableMusaka.PrintType();
        vegetableMusaka.PrintName();
        vegetableMusaka.GetIngridents();
        vegetableMusaka.Mix();
        vegetableMusaka.Prepare();
        // проверяване на типа с думичката is ако е да влизаме в скобите и кастваме
        if(recipe1 is VegetableMusaka)
        {
            ((VegetableMusaka)recipe1).PrintType();
            // защото наследи метода на родителя си Musaka може да ползваме и неговите методи
            ((VegetableMusaka)recipe1).PrintName();
        }

        // пример за кух интерфейс имплементацияю, може да го маркират като полиморфен обект 
        // (т.е. да се появява в няколко рецепти едновременнo)
        List<IVegetableRecipe> list = new();
        list.Add(vegetableMusaka);
        // успяваме веганската мусака но не и агнешкото на фурна
        // list.Add(lamb);

        IRecipe recipe2 = new VegetableMusaka();
        // ако поставим оператор в if(recipe2 == null) той може да бъде някъде overrided и да счупи логиката в последствие
        if (recipe2 is null)
        {
            Console.WriteLine("Recipe is missing");
        }
        else
        {
            Console.WriteLine("Revipe is not missing");
        }
        // да отсеем числата от 1 до 100 като вземем само тези които завършват на 1, 2, 3
        IEnumerable<int> numbers = Enumerable.Range(0, 100)
            .Where(x => x % 10 is var r && r >= 1 && r <= 3);
        // по-подробно горния ред
        IEnumerable<int> numbers2 = Enumerable.Range(0, 100)
            .Where
            (x => // 1 - 100
            {
                var number = x % 10; // вземане на остатъка
                return number >= 1 && number <= 3; // да върне само тези с остатък от 1 до 3
            }
            );
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }

        IRecipe recipeLamb = new Lamb();
        // Lamb lamb =(Lamb)recipeMusaka; // няма да успея да го кастна така
        // обаче може да направим кастване с as
        // то или ще успее да го кастне или ще върне null (за това проверките is са най-често с null)
        Lamb lambPotato = recipeLamb as Lamb;
        if (lambPotato is not null)
        {
            lambPotato.GetIngridents();
        }

        // Runtime полиморфизъм
        // погледни лекцията или упражненията

    }
    // логиката: не ме интересува как го прави а какво прави
    // в случая IRecipe прави рецептата
    // използваме тука полиморфичен обект
    // вземайки IRecipe recipe = "мога да сготвя каквото пожелая" new Musaka();
    // ние може да изкараме обаче метода Cook в колас Cheff
    /*
    private static void Cook(IRecipe recipe)
    {
        recipe.GetIngridents();
        recipe.Mix();
        recipe.Prepare();
    }
    */
    // private void Cook(Lamb recipe) е нестатичен метод и ще изисква обектна референция
    // може да го fix-нем като напишем static
    // така може да изпишем всяка рецепта в менюто ни обаче ако имаме 100 рецепти да напишем 100 метода поотделно които се повтарят е непрактично
    /*
    private static void Cook(Lamb recipe)
    {
        recipe.GetIngridents();
        recipe.Mix();
        recipe.Prepare();
    }
    private static void Cook(Musaka recipe)
    {
        recipe.GetIngridents();
        recipe.Mix();
        recipe.Prepare();
    }
    */
}