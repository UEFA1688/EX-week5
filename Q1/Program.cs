using System;
class user{
    public static void Main(string[] args)
    {
        Console.WriteLine("INPUT NUMBER");
        int input = int.Parse(Console.ReadLine());

            print(input);
    }
    static void print(int n)
    {
        if(n > 0)
        {
            print(n - 1);
            Console.WriteLine("Hamlet");
        }
        return;
    }
}