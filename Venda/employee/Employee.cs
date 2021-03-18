using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda.employee
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; protected set; }

        public Employee(string name, double valuePerHour)
        {
            Name = name;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
        public override string ToString()
        {
            return $"Employ name: {Name} ";
        }
    }
}
