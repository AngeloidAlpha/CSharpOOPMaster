namespace PlayersAndMonsters
{
    public class Hero
    {
        // this.Username използването на this е хубаво за да знаем че сочим към елемент на класа
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
