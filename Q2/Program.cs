using System;
class user{
    public static void Main(string[] args)
    {
        Console.WriteLine("INPUT NUMBER");
        int input = Convert.ToInt32(Console.ReadLine());

            int  i;
            int[] ans = new int[input]; 
        for (i = 0; i < input; i++)
            {
              ans[i] =  (i+i+1) * (i+i+1);
            }
        Console.WriteLine("amount of blocks required : " + ans.Sum());
       

    }
}
