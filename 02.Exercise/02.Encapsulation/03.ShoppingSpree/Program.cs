using _03.ShoppingSpree;

public class Program
{
    static void Main(string[] args)
    {
        // трябва да създадем хората, да имаме подредбата им като ги изписваме накрая и да си ги запишем
        Dictionary<string, Person> peopleMap = new Dictionary<string, Person>();
        List<Person> peopleInOrder = new List<Person>();
        // тук ще запишем продуктите ни по същия начин
        Dictionary<string, Product> productMap = new Dictionary<string, Product>();

        // Получаваме грешка че имаме отрицателни числа за да изпишем отговор че отрицателни не може да получим 
        // правим try catch ситуация
        try
        {
            string[] peopleInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] data = peopleInfo[i].Split('=');
                Person currentPerson = new Person(data[0], decimal.Parse(data[1]));
                peopleMap[currentPerson.Name] = currentPerson;
                peopleInOrder.Add(currentPerson);
            }
            string[] productInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productInfo.Length; i++)
            {
                string[] data = productInfo[i].Split('=');

                Product currentProduct = new Product(data[0], decimal.Parse(data[1]));
                productMap[currentProduct.Name] = currentProduct;
            }
        }
        catch (ArgumentException e)
        {
            //трябва да прекратим програмата 
            Console.WriteLine(e.Message);
            return; 
        }
        
        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] data = command.Split();
            string personName = data[0], productName = data[1];
            
            Person person = peopleMap[personName];
            Product product = productMap[productName];

            if (person.Purchase(product))
            {
                Console.WriteLine($"{person.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{person.Name} can't afford {product.Name}");
            }
            command = Console.ReadLine();
        }
        foreach (Person person in peopleInOrder)
        {
            Console.WriteLine(person);
        }
    }
}