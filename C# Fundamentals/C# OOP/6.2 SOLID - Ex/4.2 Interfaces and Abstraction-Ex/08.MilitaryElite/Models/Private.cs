﻿namespace _08.MilitaryElite.Models
{
    using _08.MilitaryElite.Contracts;

    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"Salary: {this.Salary:f2}";
        }
    }
}
