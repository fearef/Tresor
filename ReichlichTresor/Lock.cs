using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReichlichTresor
{
    class Lock
    {
        private readonly int[] constCombo= {7,3,7,9,3};
        private readonly int[] lockCombo;

        public int this [int i]
        {
            get { return lockCombo[i]; }         
        }

        public int[] GetLock { get { return lockCombo; } }

        public Lock(int[] combination=null)
        {
            if (combination != null) lockCombo = combination;
            else lockCombo = constCombo;
        }
      
        

        
    }
}
