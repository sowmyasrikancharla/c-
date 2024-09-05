using System;

class P2
{   
    // Corrected method signature to public and static
    public static int findKey(int input1, int input2, int input3)
    {
        int[] a1 = new int[3];
        int[] a2 = new int[3];
        a2[0] = input1;
        a2[1] = input2;
        a2[2] = input3;
        
        int c = 0;
        int result = 0;
        while (c <= 3) // Changed condition from c <= 3 to c < 3
        {
            for (int i = 0; i < 3; i++)
            {
                int r = a2[i] % 10;
                a2[i] = a2[i] / 10; // Corrected variable name from arr to a2
                a1[i] = r;
            }
            
            int max = a1[0]; // Corrected variable initialization
            int min = a1[0]; // Corrected variable initialization
            int temp = 0;
            foreach (int x in a1)
            {
                if (x > max)
                {
                    temp = max;
                    max = x;
                }
                if (x < min) // Changed condition from x < max to x < min
                {
                    temp = min;
                    min = x;
                }
            }
            
            c++;
            int diff = max - min;
            result = result * 10 + diff;
        }
        
        int ans = 0;
        while (result > 0)
        {
            int rem = result % 10;
            result = result / 10;
            ans = ans * 10 + rem;
        }
        
        return ans;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[3];

        Console.Write("Enter input1: ");
        arr[0] = Convert.ToInt32(Console.ReadLine());
        if (arr[0] >= 1000 && arr[0] <= 9999)
        {
            Console.Write("Enter input2: ");
            arr[1] = Convert.ToInt32(Console.ReadLine());
            if (arr[1] >= 1000 && arr[1] <= 9999)
            {
                Console.Write("Enter input3: ");
                arr[2] = Convert.ToInt32(Console.ReadLine());
                if (arr[2] >= 1000 && arr[2] <= 9999)
                {
                   int r111= P2.findKey(arr[0], arr[1], arr[2]); // Corrected method call to use class name P2
		   Console.WriteLine(r111);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
