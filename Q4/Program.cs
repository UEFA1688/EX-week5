public class user {
   

    public static void Main(string[] args)
    {
        int floor, i, x;

            Console.Write("Input Number : ");
            floor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            for (i = 1; i <= floor; i++) {
    
                for (x = 1; x <= floor - i; x++) {
                    Console.Write(" ");
                }

                for (x = 1; x <= (2 * i - 1); x++) {
                    if (i < floor) {
                        if (x == 1 || x == (2 * i - 1)) {
                            Console.Write("#");
                        } else {
                            Console.Write(" ");
                        }
                    }
                    else {
                        Console.Write("#");
                    }
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
