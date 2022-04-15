using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class sy5_1
    {
        static void Main(String[] args)
        {
            FruitBasket fruitBasket = new FruitBasket();
            Console.WriteLine("Adding an Apple:");
            fruitBasket.Add(new Apple());
            Console.WriteLine("Adding an Banana:");
            fruitBasket.Add(new Banana());
            Console.WriteLine("Adding an Orange:");
            fruitBasket.Add(new Orange());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Adding a Apple");
                fruitBasket.Add(new Apple());
            }

            Console.WriteLine();
            Console.WriteLine("The basket is holding:");
            foreach (Fruit fruit in fruitBasket)
            {
                Console.WriteLine(" 装入水果： " + fruit.Name);
            }

            Console.Read();
        }
    }

    public class Fruit
    {
        public virtual string Name
        {
            get
            {
                return ("Fruit");
            }
        }
    }

    public class Orange : Fruit
    {
        public override string Name
        {
            get
            {
                return "Orange";
            }
        }
    }

    public class Apple : Fruit
    {
        public override string Name
        {
            get
            {
                return ("Apple");
            }
        }
    }

    public class Banana : Fruit
    {
        public override string Name
        {
            get
            {
                return ("Banana");
            }
        }
    }

    public class FruitBasket : IEnumerable
    {
        private static int Max = 10;
        private Fruit[] basket = new Fruit[Max];
        private int count = 0;

        internal Fruit this[int index]
        {
            get
            {
                return basket[index];
            }
            set
            {
                basket[index] = value;
            }
        }

        internal int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(Fruit fruit)
        {
            if (count>=Max)
            {
                Console.WriteLine("超出水果篮容量！");
                return;
            }

            basket[count++] = fruit;
        }

        public IEnumerator GetEnumerator()
        {
            return new FruitBasketEnumerator(this);
        }
    }

    public class FruitBasketEnumerator : IEnumerator
    {
        private FruitBasket fruitBasket;
        private int index;


        public bool MoveNext()
        {
            if (++index>=fruitBasket.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current {
            get
            {
                return fruitBasket[index];
            }
        }

        internal FruitBasketEnumerator(FruitBasket fruitBasket)
        {
            this.fruitBasket = fruitBasket;
            Reset();
        }
    }
}
