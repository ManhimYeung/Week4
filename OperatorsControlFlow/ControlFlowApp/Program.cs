namespace ControlFlowApp;

public class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int> { 10, 6, 22, -17, 5 };

        Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
        Console.WriteLine("Highest for loop: " + LoopTypes.HighestForLoop(nums));
        Console.WriteLine("Highest do while loop: " + LoopTypes.HighestDoWhileLoop(nums));
        Console.WriteLine("Highest while loop: " + LoopTypes.HighestWhileLoop(nums));

    }

    public static string GetGrade(int mark)
    {
        // if var grade = mark and that is >= 65, return "pass"
        return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail"; // can check if mark is possible integer as well
    }

    public static string Priority(int level)
    {
        string priority = "Code ";
        switch (level)
        {
            case 0:
                priority += "Green";
                break;
            case 1:
                priority += "Amber";
                break;
            case 2:
                priority += "Blue";
                break;
            case 3:
                priority += "Red";
                break;
            default:
                priority = "error";
                break;
        }
        return priority;
    }
}