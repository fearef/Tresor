using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReichlichTresor
{
    class Lock<T>
    {
        private List<T> arr = new List<T>(5);

       
        public T this[int i]
        {
            get { return arr[i]; }         
        }

        public Lock ()
        {

        }
    }
}
