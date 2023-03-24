using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var cars = new List<Cars>
            {
                new Cars()
                {
                    TypeOfCar = "BMW",
                    Model = "Q200",
                    Year = 2016,
                    Color = "Red"
                },
                new Cars()
                {
                    TypeOfCar = "Audi",
                    Model = "RH94",
                    Year = 2012,
                    Color = "White"
                },
                new Cars()
                {
                    TypeOfCar = "Lexus",
                    Model = "A2000",
                    Year = 2023,
                    Color = "Black"
                },
            };

            var buyers = new List<Buyer>
            {
                new Buyer()
                {
                    ModelOfCar = "BMW",
                    Name = "Oleksiy",
                    Phone = 0632549535
                },
                new Buyer()
                {
                    ModelOfCar = "Lexus",
                    Name = "Ivan",
                    Phone = 0978569845
                },
                new Buyer()
                {
                    ModelOfCar = "Jeep",
                    Name = "Vlad",
                    Phone = 0995851569
                },
            };

            var query = from car in cars
                join bayer in buyers
                    on car.TypeOfCar equals bayer.ModelOfCar
                orderby bayer.Name
                select new
                {
                    Name = bayer.Name,
                    Phone = bayer.Phone,
                    Car = car.TypeOfCar,
                    Model = car.Model,
                    Year = car.Year,
                    Color = car.Color
                };

            foreach (var info in query)
            {
                Console.WriteLine($"{info.Name} придбав {info.Car}-{info.Model}, {info.Year} року, у кольорі {info.Color}." +
                                  $" Номер телефону покупця {info.Phone}");
            }

            Console.ReadKey();
        }
    }
}
