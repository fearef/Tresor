using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thema2
{
    class Program
    {
        const int PEOPLE_AMOUNT_IN_GROUP = 5;
        static void Main(string[] args)
        {
            List<Employee> group = new List<Employee>(5);
            for (int i=0;i<EmployeesGroup.GetEmployeesBaseCollection.Count;i++)
            {
                var currentCol = EmployeesGroup.GetEmployeesBaseCollection;
                group.Add(currentCol[i]);
                currentCol.RemoveAt(i);
                //hier fortsetzen
            }
        }

        private EmployeesGroup BuildGroup( int amountMale, int amountFemale, List<Employee> baseCollection)
        {
            if ((amountFemale < 1) || (amountMale < 1) || (amountMale + amountFemale > baseCollection.Count)) return null;
            EmployeesGroup group = new EmployeesGroup();
            for (int i=0;i<amountFemale;i++)
            {
                group.Add(baseCollection.Where(x => x.Gender == Gender.Female).ElementAt(i));
            }
            for (int i = 0; i < amountMale;i++)
            {
                group.Add(baseCollection.Where(x => x.Gender == Gender.Male).ElementAt(i));
            }
            return group;
        }


       
    }
}
