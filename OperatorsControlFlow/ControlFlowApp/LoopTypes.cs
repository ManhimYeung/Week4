using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowApp
{
    public static class LoopTypes
    {
        internal static int HighestDoWhileLoop(List<int> nums)
        {
            int highest = 0;
            int count = 0;
            do
            {
                if (nums[count] > highest) highest = nums[count];

                count++;
            } while (count < nums.Count);

            return highest;
        }

        internal static int HighestForEachLoop(List<int> nums)
        {
            int highest = 0;
            foreach (int i in nums)
                if ( i > highest ) highest = i;

            return highest;
        }

        internal static int HighestForLoop(List<int> nums)
        {
            int highest = Int32.MinValue;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest) highest = nums[i]; 
            }
            return highest;
        }

        internal static int HighestWhileLoop(List<int> nums)
        {
            int highest = 0;
            int count = 0;
            while (count < nums.Count)
            {
                if (nums[count] > highest) highest = nums[count];
                count++;
            }


            return highest; 
        }
    }
}
