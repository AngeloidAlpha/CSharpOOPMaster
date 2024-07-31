namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            // применяне на нивата на сигурност public -> private -> protected -> constant
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentException($"{nameof(Name)} cannot be empty.");
                    this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < MinAge || value > MaxAge)
                    throw new ArgumentException($"{nameof(Age)} should be between {MinAge} and {MaxAge}.");
                this.age = value;
            }
        }
        // и 2та вида на записване са верни това е съкратения вид
        // public double ProductPerDay => this.CalculateProductPerDay();
        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }
        //този метод се използва само в този клас заради това ще го вдигнем до private
        private double CalculateProductPerDay()
        {
            return this.Age switch
            {
                <=3 => 1.5,
                <=7 =>2,
                <=11 => 1,
                _ => 0.75,
            };
            // това може да бъде изписано с експрешън 
            /*
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
            */
        }
    }
}
