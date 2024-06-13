namespace ForeachLoop;

internal class Program
{
    static void Main(string[] args)
    {
        // List<int> myList = new List<int>
        //{
        //    1,2,3
        //};

        //foreach (int item in myList)
        //{
        //    var myConst = 10;

        //}

        int[] nbrs =
        {
        754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
        187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
        460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
        690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
        435, 643, 809, 874, 906, 620, 328, 369, 426, 561
        };
        int max = 0; //nbrs.Max()
        int min = 1000; //nbrs.Min()
        int sum = 0;
        int length = nbrs.Length;

        foreach (int num in nbrs)
        {
            sum += num;
            //Console.WriteLine(sum);
            if (max < num)
            {
                max = num;
            }
            //We need to do another if so one number gets checked for both conditions
            if (min > num)
            {
                min = num;
            }
        }
        int avg = sum / length;


        Console.WriteLine($"Highest: {max}, Lowest: {min}, Average: {avg}");
    }
}
