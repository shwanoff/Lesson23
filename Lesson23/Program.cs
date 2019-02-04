using System;

namespace Lesson23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // Создать Анонимный тип, Tuple и ValueTuple значения.
            // ValueTuple использовать в качестве акгумента метода и 
            // в качестве возвращаемого значения.

            var product = new
            {
                Name = "Milk",
                Energy = 10
            };

            Console.WriteLine(product);
            Console.WriteLine(product.Energy);
            Console.WriteLine(product.Name);

            var eat = new Eat()
            {
                Name = "Meat"
            };

            var product2 = new
            {
                eat.Name,
                Energy = 200
            };

            Console.WriteLine(product2);

            Tuple<int, string> tuple = new Tuple<int, string>(5, "Привет");
            Console.WriteLine(tuple.Item1);

            var tuple2 = (5, "Привет");
            var tuple3 = (Name: "Tomato", Energy: 20);
            tuple3.Energy = 60;

            var result = GetData();
            Console.WriteLine(result.Name);
            Console.ReadLine();
        }

        public static (int Number,  string Name, bool Flag) GetData()
        {
            var number = 7821;// метод получения данных
            var name = Guid.NewGuid().ToString(); // метод получения данных
            bool b = number > 500; // проверка уловия

            return (number, name, b);
        }
    }
}
