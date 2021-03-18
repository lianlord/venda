using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.enums;

namespace Venda.worker
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<Contract> Contracts { get; private set; }
        public Department Department { get; set; }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            Contracts = new();
        }

        public void AddContract(Contract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(Contract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            List<Contract> contracts = Contracts.FindAll(c => c.Date.Year == year && c.Date.Month == month);
            double soma = BaseSalary;
            contracts.ForEach(c => soma += c.TotalValue());
            return soma;
        }

        public override string ToString()
        {
            return $"Worker name: {Name}, level:{Level}, Department: {Department.Name}";
        }
    }
}
