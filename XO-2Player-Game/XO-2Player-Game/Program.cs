using System;

namespace XO_2Player_Game
{
    class playGround
    {
        public bool?[] node = new bool?[9];

        public bool userInput(bool player, int place)
        {
            if (node[place] == null)
            {
                node[place] = player;
                return true;
            }
            else
                return false;
        }
        
    }
    class Game
    {
        /**
            Runs the game and user interface!(UI)
            * players play by typing numbers from 1 to 9
              each number represents a field in the grid
              the grid is organized just as the same as right numerial keyboard
              on every normal keyboard
            * saves player inputs into a array of 5
              then examines player A & player B inputs to find the winner
            
            @params: none
            @retruns: none
        */
        public void play()
        {
            Console.Clear();
            Console.WriteLine("\n\t****** X-O ******");

            playGround plyGrnd = new playGround();
            int choice;
            bool valid = false;
            string input;
            for (int i = 0; i < 5; i++)
            {
                // player A :=: true
                do
                {
                    Console.Write("Player A: ");
                    input = Console.ReadLine();
                    Int32.TryParse(input, out choice);      // changes input type from string to int
                    if (plyGrnd.userInput(true, choice-1) == false)
                    {
                        Console.WriteLine("This field is used! try again: ");
                        valid = false;
                    }
                    else
                        valid = true;
                } while (valid == false);
                if (check(true, choice-1, plyGrnd))
                {
                    Console.WriteLine("\n\tPlayer A is the Winner!");
                    break;
                }

                // player B :=: false
                do
                {
                    Console.Write("Player B: ");
                    input = Console.ReadLine();
                    Int32.TryParse(input, out choice);      // changes input type from string to int
                    if (plyGrnd.userInput(false, choice-1) != true)
                    {
                        Console.WriteLine("This field is used! try again: ");
                        valid = false;
                    }
                    else
                        valid = true;
                } while (valid == false);
                if (check(false, choice-1, plyGrnd))
                {
                    Console.WriteLine("\n\tPlayer B is the Winner!");
                    break;
                }
            }
            
        }

        /**
            checks if the game has a winner every time it's been called
            * checks by going throw every possible way of winning in X-O

            @params: an array of player choices to check
            @returns: true if the player wins false if not
        */
        public bool check(bool player, int place, playGround plyGrnd)
        {
            if (place == 0)
            {
                if (plyGrnd.node[1] == player && plyGrnd.node[2] == player)
                    return true;
                else if (plyGrnd.node[3] == player && plyGrnd.node[6] == player)
                    return true;
                else if (plyGrnd.node[4] == player && plyGrnd.node[8] == player)
                    return true;
                else
                    return false;

            }
            else if (place == 6)
            {
                if (plyGrnd.node[3] == player && plyGrnd.node[0] == player)
                    return true;
                else if (plyGrnd.node[7] == player && plyGrnd.node[8] == player)
                    return true;
                else if (plyGrnd.node[4] == player && plyGrnd.node[2] == player)
                    return true;
                else
                    return false;

            }
            else if (place == 2)
            {
                if (plyGrnd.node[1] == player && plyGrnd.node[0] == player)
                    return true;
                else if (plyGrnd.node[5] == player && plyGrnd.node[8] == player)
                    return true;
                else if (plyGrnd.node[4] == player && plyGrnd.node[6] == player)
                    return true;
                else
                    return false;

            }
            else if (place == 8)
            {
                if (plyGrnd.node[6] == player && plyGrnd.node[7] == player)
                    return true;
                else if (plyGrnd.node[5] == player && plyGrnd.node[2] == player)
                    return true;
                else if (plyGrnd.node[4] == player && plyGrnd.node[0] == player)
                    return true;
                else
                    return false;

            }
            else
                return false;
        }
        
    }
    class Program
    {
        static void Main()
        {
            int SelectedOption = 0;
            string input;
            bool valid = false;

            Console.WriteLine("\n\t****** WELCOME TO X-O ******");
            Console.Write("\n\tType '1' to start the game with your friend, or ");
            input = Console.ReadLine();
            Console.WriteLine();
            Int32.TryParse(input, out SelectedOption);

            while (valid == false)
            {
                switch (SelectedOption)
                {
                    case 1:
                        Game g = new Game();
                        g.play();
                        Console.WriteLine("Try Again? type 'yes' or 'no': ");
                        input = Console.ReadLine();
                        if (input == "yes" || input == "YES" || input == "Yes")
                            valid = false;
                        if (input == "no" || input == "NO" || input == "No")
                            valid = true;
                        break;
                    default:
                        Console.Write("\tInvalid Input try again: ");
                        input = Console.ReadLine();
                        Int32.TryParse(input, out SelectedOption);
                        break;
                }
            }


            Console.WriteLine("\n\n\t Thank you for playing. Bye :-]");
            Console.ReadKey();
        }
    }
}
