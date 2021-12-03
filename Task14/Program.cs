using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    //Моделирование объектов реального мира при помощи классов

    //Создание экземпляров классов Cat  и Dog, проверка их работоспособности
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Console.WriteLine(cat.ShowInfo());
            Dog dog = new Dog();
            Console.WriteLine(dog.ShowInfo());

            Console.ReadKey();
        }
    }
    
    //Создание общего абстрактного класса Animal для описания животных
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string GetName();
        public abstract string Say();
        public string ShowInfo()
        {
            return (Name + " говорит: \"" + Say() + "\"");
        }
    }

    // Создание производного класса Cat от базового класса Animal
    class Cat : Animal
    {
        string name = "Кошка";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string GetName()
        {
            return Name;
        }
        public override string Say()
        {
            return "Мяу";
        }
    }

    // Создание производного класса Dog от базового класса Animal
    class Dog : Animal
    {
        string name="Собака";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string GetName()
        {
            return Name;
        }
        public override string Say()
        {
            return "Гав";
        }
    }
}
