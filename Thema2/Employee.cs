using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thema2
{
    class Employee
    {
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        
        Employee (string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
        }
        
    }

    public enum Gender { Male, Female}
}
