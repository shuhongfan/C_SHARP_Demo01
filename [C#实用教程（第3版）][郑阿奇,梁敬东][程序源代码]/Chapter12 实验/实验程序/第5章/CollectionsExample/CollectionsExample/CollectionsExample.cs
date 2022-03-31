﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsExample
{
    public class Fruit
    {
        public virtual string Name
        {
            get
            {
                return( "Fruit" );
            }
        }
    }
    public class Apple : Fruit
    {
        public override string Name
        {
            get
            {
                return( "Apple" );
            }
        }
    }
    public class Banana : Fruit
    {
        public override string Name
        {
            get
            {
                return( "Banana" );
            }
        }
    }
    public class FruitBasket : IEnumerable
    {
        static int Max = 10;
        Fruit[] basket = new Fruit[Max];
        int count = 0;
        internal Fruit this[int index]
        {
            get
            {
                return( basket[index] );
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
                return(count);
            }
        }
        public void Add( Fruit fruit )
        {
            if( count > Max)
            {
                Console.WriteLine("超出水果篮容量!");
            }
            basket[count++] = fruit;
        }
        public IEnumerator GetEnumerator()
        {
            return( new FruitBasketEnumerator(this));
        }
    }
    public class FruitBasketEnumerator : IEnumerator
    {
        FruitBasket fruitBasket;
        int index;
        public void Reset()
        {
            index = -1;
        }
        public object Current
        {
            get
            {
                return(fruitBasket[index]);
            }
        }
        public bool MoveNext()
        {
            if (++index >= fruitBasket.Count)
                return (false);
            else
                return (true);
        }
        internal FruitBasketEnumerator(FruitBasket fruitBasket)
        {
            this.fruitBasket = fruitBasket;
            Reset();
        }
    }
    class CollectionsExample
    {
        static void Main(string[] args)
        {
            FruitBasket fruitBasket = new FruitBasket();
            Console.WriteLine("Adding a Banana");
            fruitBasket.Add(new Banana());
            Console.WriteLine("Adding an Apple");
            fruitBasket.Add(new Apple());
            Console.WriteLine("");
            Console.WriteLine("The basket is holding:");
            foreach (Fruit fruit in fruitBasket)
            {
                Console.WriteLine("  a(n) " + fruit.Name);
            }
            Console.Read();
        }
    }
}
