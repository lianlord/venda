using System;
using Venda.enums;
using Venda.model;
using Venda.worker;

namespace Venda {
    class Program {
        static void Main(string[] args) {
            MockWorcker();
        }

        public static void MockWorcker()
        {
            Department department = new("Sales");
            Worker worker = new("Joshua", WorkerLevel.Junior,1200,department);
           
            MockContracts(worker);
            Console.WriteLine(worker);
            Console.WriteLine("Income: "+worker.Income(2018,08));
        }

        public static void MockContracts(Worker worker) {
            worker.AddContract(new Contract(new DateTime(2018,08,20),50, 20));
            worker.AddContract(new Contract(new DateTime(2018,06,13),30, 18));
            worker.AddContract(new Contract(new DateTime(2018,08,25),80, 10));
        }
        
    }
}
