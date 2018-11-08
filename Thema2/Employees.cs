using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thema2
{
    static class Employees
    {
        static List<Employee> GetEmployees()
        {
            var array = new Employee[]{
            new Employee("Lisa", Gender.Female),
                new Employee("Marta", Gender.Female),
                new Employee("Angelika", Gender.Female),
                new Employee("Ulla", Gender.Female),
                new Employee("Svenja", Gender.Female),
                new Employee("Olivia", Gender.Female),
                new Employee("Lotte", Gender.Female),
                new Employee("Lucy", Gender.Female),
                new Employee("Klaus", Gender.Male),
                new Employee("Ralf", Gender.Male),
                new Employee("Lutz", Gender.Male),
                new Employee("Ingo",Gender.Male),
                new Employee("Franz",Gender.Male),
                new Employee("Uwe",Gender.Male),
                new Employee("Max",Gender.Male),
                new Employee("Moritz",Gender.Male),
                new Employee("Holger",Gender.Male),
                new Employee("Ben",Gender.Male),
                new Employee("Joe",Gender.Male),
                new Employee("Charlie", Gender.Male)};
            return array.ToList();
        }
    }
}
