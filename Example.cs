using System;

namespace InformationSystemsEngineering.DesignPatterns.TemplateMethod
{
    abstract class AbstractClass
    {
        // Шаблонный метод определяет скелет алгоритма.
        public void TemplateMethod()
        {
            this.Sauce();
            this.RequiredOperation1();
            this.Meat();
            this.RequiredOperation2();
            this.Salad();
            this.RequiredOperation3();
        }

        protected void Sauce()
        {
            Console.WriteLine("Sauce");
        }

        protected void Meat()
        {
            Console.WriteLine("Meat");
        }

        protected void Salad()
        {
            Console.WriteLine("Salad");
        }

        protected abstract void RequiredOperation1();

        protected abstract void RequiredOperation2();

        protected abstract void RequiredOperation3();

    }

    class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("Put a ketchup into burger");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("Put a beef into burger");
        }

        protected override void RequiredOperation3()
        {
            Console.WriteLine("Put a tomato into burger");
        }
    }

    class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("Put a mustard into hotdog");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("Put a sosige into hotdog");
        }

        protected override void RequiredOperation3()
        {
            Console.WriteLine("Put a pepper into hotdog");
        }
    }

    class Client
    {

        public static void ClientCode(AbstractClass abstractClass)
        {
            // ...
            abstractClass.TemplateMethod();
            // ...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make a burger:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Make a hotdog:");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}