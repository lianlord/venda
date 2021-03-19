using System;
using System.Collections.Generic;
using Venda.employee;
using Venda.enums;
using Venda.notification;
using Venda.shape;
using Venda.worker;

namespace Venda
{
    class Program
    {
        static void Main(string[] args)
        {
            MockException();
        }

        public static void MockException() {
            double div = 0;
            try
            {
                var num = 6 / int.Parse("0");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                var num = 6 / int.Parse("a");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("SUCCES on exceptions");
            }
            
            try
            {
                div = 6 / 3;
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("SUCCES on division: "+div);
            }

            
        }

        public static void MockShape()
        {
            List<Shape> shapes = new();
            Shape rectagle = new Rectagle(Color.Red, 200, 300),
                circle = new Circle(Color.Green, 3);
            shapes.Add(rectagle);
            shapes.Add(circle);
            shapes.ForEach(shape => Console.WriteLine(shape+" area: "+shape.Area()));
        }

        public static void MockEmployee()
        {
            List<Employee> employees = new();
            Employee employee1 = new("Marcos", 50),
                employee2 = new("Sandra", 50),
                employee3 = new OutsourceEmployee("Carla",30,1.1);
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employee1.Hours = 8;
            employee2.Hours = 9;
            employee3.Hours = 7;
            employees.ForEach(employee => Console.WriteLine(employee + ", payment " + employee.Payment()));

        }
        public static void MockPost()
        {
            Post post = new(
                "Traveling to New Zeland",
                "I'm going to visit this wonderfull coutry"
                );
            post.AddComment(new("Have a nice trip"));
            post.AddComment(new("Wow that's awesome!"));
            post.Likes = 12;

            Post post2 = new("Good night guys", "See You Tomorrow");
            post2.AddComment(new("Good night"));
            post2.AddComment(new("Good night"));
            Console.WriteLine(post+"\n"+post2);


        }
        public static void MockWorcker()
        {
            Department department = new("Sales");
            Worker worker = new("Joshua", WorkerLevel.Junior, 1200, department);

            MockContracts(worker);
            Console.WriteLine(worker);
            Console.WriteLine("Income: " + worker.Income(2018, 08));
            Console.WriteLine("Contracts: " + worker.Contracts.Count);
        }

        public static void MockContracts(Worker worker)
        {
            worker.AddContract(new Contract(new DateTime(2018, 08, 20), 50, 20));
            worker.AddContract(new Contract(new DateTime(2018, 06, 13), 30, 18));
            worker.AddContract(new Contract(new DateTime(2018, 08, 25), 80, 10));
        }

    }
}
