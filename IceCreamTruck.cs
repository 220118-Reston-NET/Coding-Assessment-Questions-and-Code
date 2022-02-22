using System;

public class Test
{
    // Complete the TwoKidsAndATruck function below.
    public static string TwoKidsAndATruck(int k1, int k2, int t){
        // Write your code here:
        return "";
    }
    
    public static void Main()
    {
        //INPUT [uncomment & modify if required]
        int runs = 0;
        string result = "";
        
        runs = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < runs; i++) {
            string[] xyz = Console.ReadLine().Split(' ');
 
            int x = Convert.ToInt32(xyz[0]);
 
            int y = Convert.ToInt32(xyz[1]);
 
            int z = Convert.ToInt32(xyz[2]);
 
            result = TwoKidsAndATruck(x, y, z);
            
            //OUTPUT [uncomment & modify if required]
            Console.WriteLine(result);
        }
    }
}