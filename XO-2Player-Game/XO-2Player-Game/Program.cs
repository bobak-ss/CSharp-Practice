using System;

namespace XO_2Player_Game
{
    class Program
    {
        static void Main()
        {
            int SelectedOption = 0;
            string input;
            bool valid = false;

            Console.WriteLine("\n\t****** WELCOME TO X-O ******");
            Console.Write("\n\tType '1' to start the game with your friend: ");
            input = Console.ReadLine();
            Console.WriteLine();
            Int32.TryParse(input, out SelectedOption);

            while (valid == false)
            {
                switch (SelectedOption)
                {
                    case 1:
                        XO();// start game function
                        valid = true;
                        Console.WriteLine("OK!");
                        break;
                    default:
                        Console.Write("\tInvalid Input try again: ");
                        input = Console.ReadLine();
                        Int32.TryParse(input, out SelectedOption);
                        break;
                }
            }


            Console.WriteLine("Finish!");

            Console.ReadLine();
        }

        static void XO()
        {
            Console.Clear();
            Console.WriteLine("\n\t****** X-O ******");

            int[] PlayerA = new int[5];
            int[] PlayerB = new int[5];
            string input;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Player A: ");
                input = Console.ReadLine();
                Int32.TryParse(input, out PlayerA[i]);


                Console.Write("Player B: ");
                input = Console.ReadLine();
                Int32.TryParse(input, out PlayerB[i]);
            }
        }

        static bool WinCheck(int[] playerChoices)
        {
            return false;
        }
    }
}
