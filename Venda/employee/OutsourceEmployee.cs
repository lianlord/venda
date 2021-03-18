using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda.employee
{
    class OutsourceEmployee : Employee
    {
        public double AditionalCharge { get; set; }
        public OutsourceEmployee(string name, double valuePerHour, double aditionalCharge) 
            : base(name, valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() * ( 1 + AditionalCharge);
        }

        public override string ToString()
        {
            return $"Outsourced Employee, name {Name}";
        }
    }
}
