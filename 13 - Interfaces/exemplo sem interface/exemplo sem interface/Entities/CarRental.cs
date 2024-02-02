using System;

namespace exemplo_sem_interface.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        // lincando as classes:
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
