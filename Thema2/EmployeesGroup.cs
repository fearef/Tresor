using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thema2
{
     class EmployeesGroup:List<Employee>
    {
        static public List<Employee> GetEmployeesBaseCollection
        {
            get
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

        public override bool Equals(object obj)
        {
            try
            {
                var other = obj as EmployeesGroup;
                foreach (var item in other)
                {
                    if(this.Contains(item)==false)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }                 
        }

        public override int GetHashCode()
        {
            return string.Join("", this.Select(x => x.Name)).GetHashCode();
        }
    }
}
