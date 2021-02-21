using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback_functions
{
    class Checker
    {
        public bool Any(int[] nums)
        {
            foreach (int num in nums)
            {
                if (num > 3)
                {
                    return true;
                }  
            }
            return false;
        }

        public bool All(int[] nums)
        {
            int count = 0;
            foreach (int num in nums)
            {
                if (num > 3)
                {
                    count += 1;
                }
                if (count == nums.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
