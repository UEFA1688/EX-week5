
public class user {
     
        static int cal(int[] input, int n)
    {
        int result = input[0];
        for (int i = 1; i < n; i++){
            result = Anssum(input[i], result);
 
            if(result == 1)
            {
               return 1;
            }
        }
 
        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("INPUT NUMBER");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] input = new int[x]; 

        for (int i = 0; i < x; i++){
             input[i] = Convert.ToInt32(Console.ReadLine());
        }
        int n = input.Length;
        Console.WriteLine(" ");
        Console.WriteLine("Answer : "+cal(input, n));
    }

    static int Anssum(int a, int b)
    {
        if (a == 0)
            return b;
        return Anssum(b % a, a);
    }


}