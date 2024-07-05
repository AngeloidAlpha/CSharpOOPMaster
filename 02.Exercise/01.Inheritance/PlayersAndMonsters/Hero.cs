namespace PlayersAndMonsters
{
    public class Hero
    {
        // C#13 има Primary constructors
        // public class Elf(string username, int level) : Hero (username, level)
        // remove unnacesery usings (горе дет се появяват)
        // Ctrl + R и после Ctrl + G 
        // this.Username използването на this е хубаво за да знаем че сочим към елемент на класа
        // стилови преференции си ги създавамне на проектно ниво файл който после ще ни подсеща 
        // как да си пишем кода за да е разбираем за екипа
        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }

        public string Username { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
