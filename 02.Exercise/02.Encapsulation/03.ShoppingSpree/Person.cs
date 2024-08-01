using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private decimal _money;
        private readonly List<Product> _products;
        public Person(string name, decimal money)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty");
            this.Name = name;
            this.Money = money;
            this._products = new List<Product>();
            // създаваме си инстанцията и я преизползваме
            // тук го достъпваме само като го четем като при интерфейса
            this.Products = this._products.AsReadOnly();
        }
        public string Name { get; }
        public decimal Money { 
            get => this._money; 
            // Проверяваме дали парите са по-малко от 0 и присвояваме новата сума която ще изплюе метода
            private set 
            { 
                if (value < 0) throw new ArgumentException("Money cannot be negative"); 
                this._money = value;
            } 
        }
        // не искаме да ползваме List защото може да правим промени по съдържанието му
        // public List<Product> AllProducts { get; }
        // за да не го променяме отвънка ще използваме интерфейси от следващата лекция
        public IReadOnlyCollection<Product> Products { get; }

        // за да пресметнем парите оставащи на човека ще създадем private set 
        // правим го така защото ние не излизаме от класа Person
        // създаваме метод който връща само true/false купето/некупено и според това ще изпишем после 2те съобщения
        public bool Purchase(Product product)
        {
            if (product.Cost > this.Money) return false;
            this._products.Add(product);
            this.Money -= product.Cost;
            return true;
        }
        // създаваме override метод за презаписване на резултата който искаме 
        // има 2 варианта ако няма продукти и ако има
        // започваме с името и прикачваме към него празно място с тире, после в 2та случая или добавяме че няма купено или
        // започваме да редим един след друг продуктите разделени с ", " 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append(" - ");

            if (this.Products.Count == 0) sb.Append("Nothing bought");
            else sb.Append(string.Join(", ", this.Products.Select(p => p.Name)));

            return sb.ToString();
        }
    }
}
