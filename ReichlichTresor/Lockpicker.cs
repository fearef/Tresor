using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReichlichTresor
{
    class Lockpicker
    {

        public static void PickLock (Lock locker)
        {
           
            //Amount of combos
            int combinationsCount = 0;
            var timer=System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < Math.Pow(10,locker.GetLock.Length); i++)
            {
                var myI = i.ToString();
                while (myI.Length < locker.GetLock.Length) myI = myI.Insert(0, "0");
                var stArray=myI.Select(x => x.ToString());
                if(
                    !stArray.Contains("4")&&
                   !stArray.Contains("0")&&
                    (new HashSet<string>(stArray).Count()==3)
                    )
                {
                   if( TryLock(locker, stArray.Select(x => Int32.Parse(x)).ToArray()))
                    {
                        Console.WriteLine($"Lock broken!\n Combinations tried: {combinationsCount}\n Seconds: {timer.Elapsed.Seconds}\n Correct combination: {myI}");
                       
                    }
                    combinationsCount++;
                }
               
            }
           
        }

       

        private static bool TryLock (Lock myLock, int[] combination)
        {
            if (myLock.GetLock.Length != combination.Length) throw new ArgumentException();
            for (int i = 0; i < combination.Length; i++)
            {
                if (combination[i] != myLock[i]) return false;
            }
            return true;
        }
    }
}
