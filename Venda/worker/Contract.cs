
using System;

namespace Venda.worker {
    public class Contract {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue() {
            return ValuePerHour * Hours;
        }
    }
}