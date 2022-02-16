using System;
using System.Globalization;

namespace Utilizando_Interface_IComparable.Entities
{
    internal class Employees : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employees(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ",  " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employees))
            {
                throw new ArguemtnException("Compartion error: argument is not Employee");
            }
            Employees other = (Employees)obj;
            return Salary.CompareTo(other.Salary);
        }
    }
}
