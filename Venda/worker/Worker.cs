using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.enums;

namespace Venda.worker {
    class Worker {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Contract Contract { get; private set; }
        public Department Department { get; set; }

        public void SetContract(Contract contract) {
            Contract = contract;
        }

        public void RemoveContract() {
            Contract = null;
        }

        public double Income(int year, int month) {
            return 0;
        }
    }
}
