using System;
using Venda.enums;
using Venda.model;
using Venda.notification;
using Venda.worker;

namespace Venda
{
    class Program
    {
        static void Main(string[] args)
        {
            MockPost();
        }
        private static void MockPost()
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
