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
        
        public Employee (string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
        }

        public override bool Equals(object obj)
        {
            try
            {
                return (((obj as Employee).Gender == this.Gender) && ((obj as Employee).Name == this.Name));
            }
            catch
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return (this.Name.GetHashCode());
        }
    }

    public enum Gender { Male, Female}
}
