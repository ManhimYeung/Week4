using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp;

public class Method
{
    
    public static int GetStones(int totalPounds)
    {
        if (totalPounds < 0) throw new ArgumentOutOfRangeException(totalPounds + " is negative, please enter a positive integer.");
        return totalPounds / 14;
    }

    public static int GetPounds(int totalPounds)
    {
        if (totalPounds < 0) throw new ArgumentOutOfRangeException(totalPounds + " is negative, please enter a positive integer.");
        return totalPounds % 14;
    }

}
