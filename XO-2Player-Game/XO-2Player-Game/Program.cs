using System;

namespace XO_2Player_Game
{
    class Program
    {
        /**
            checks given wining scenario

            @params: array of player choices
            @returns: true if the scenario exist and given player is the winner
        */
        static bool check(ref int[] choices, int secondChoice, int thirdChoice)
        {
            for (int i = 0; i < 5; i++)
                if (choices[i] == secondChoice)
                    for (int j = 0; j < 5; j++)
                        if (choices[j] == thirdChoice)
                            return true;
            return false;
        }

        /**
            checks if the game has a winner every time it's been called
            * checks by going throw every possible way of winning in X-O

            @params: an array of player choices to check
            @returns: true if the player wins false if not
        */
        static bool WinCheck(ref int[] playerChoices)
        {
            for (int i = 0; i < 5; i++)
            {
                if (playerChoices[i] == 1) // *************************** 1
                {
                    if (check(ref playerChoices, 2, 3)) // 1, 2, 3
                        return true;
                    
                    if (check(ref playerChoices, 3, 2)) // 1, 2, 3
                        return true;
                    
                    if (check(ref playerChoices, 4, 7)) // 1, 4, 7
                        return true;

                    if (check(ref playerChoices, 7, 4)) // 1, 7, 4
                        return true;
                    
                    if (check(ref playerChoices, 5, 9)) // 1, 5, 9
                        return true;

                    if (check(ref playerChoices, 9, 5)) // 1, 9, 5
                        return true;
                }

                if (playerChoices[i] == 3) // *************************** 3
                {
                    if (check(ref playerChoices, 2, 1)) // 3, 2, 1
                        return true;
                    
                    if (check(ref playerChoices, 1, 2)) // 3, 1, 2
                        return true;
                    
                    if (check(ref playerChoices, 6, 9)) // 3, 6, 9
                        return true;

                    if (check(ref playerChoices, 9, 6)) // 3, 9, 6
                        return true;
                    
                    if (check(ref playerChoices, 5, 7)) // 3, 5, 7
                        return true;

                    if (check(ref playerChoices, 7, 5)) // 3, 7, 5
                        return true;
                }

                if (playerChoices[i] == 7) // *************************** 7
                {
                    if (check(ref playerChoices, 8, 9)) // 7, 8, 9
                        return true;

                    if (check(ref playerChoices, 9, 8)) // 7, 9, 8
                        return true;
                    
                    if (check(ref playerChoices, 4, 1)) // 7, 4, 1
                        return true;
                    
                    if (check(ref playerChoices, 1, 4)) // 7, 1, 4
                        return true;
                    
                    if (check(ref playerChoices, 5, 3)) // 7, 5, 3
                        return true;

                    if (check(ref playerChoices, 3, 5)) // 7, 3, 5
                        return true;
                }

                if (playerChoices[i] == 9) // *************************** 9
                {
                    if (check(ref playerChoices, 8, 7)) // 9, 8, 7
                        return true;
                    
                    if (check(ref playerChoices, 7, 8)) // 9, 7, 8
                        return true;
                    
                    if (check(ref playerChoices, 6, 3)) // 9, 6, 3
                        return true;

                    if (check(ref playerChoices, 3, 6)) // 9, 3, 6
                        return true;
                    
                    if (check(ref playerChoices, 5, 1)) // 9, 5, 1
                        return true;

                    if (check(ref playerChoices, 1, 5)) // 9, 1, 5
                        return true;
                }

                if (playerChoices[i] == 2) // *************************** 2
                {
                    if (check(ref playerChoices, 5, 8)) // 2, 5, 8
                        return true;

                    if (check(ref playerChoices, 8, 9)) // 2, 8, 9
                        return true;
                }

                if (playerChoices[i] == 4) // *************************** 4
                {
                    if (check(ref playerChoices, 5, 6)) // 4, 5, 6
                        return true;

                    if (check(ref playerChoices, 6, 5)) // 4, 6, 5
                        return true;
                }

                if (playerChoices[i] == 6) // *************************** 6
                {
                    if (check(ref playerChoices, 5, 4)) // 6, 5, 4
                        return true;

                    if (check(ref playerChoices, 8, 9)) // 6, 4, 5
                        return true;
                }

                if (playerChoices[i] == 8) // *************************** 8
                {
                    if (check(ref playerChoices, 5, 2)) // 8, 5, 2
                        return true;

                    if (check(ref playerChoices, 8, 9)) // 8, 2, 5
                        return true;
                }

                if (playerChoices[i] == 5) // *************************** 5
                {
                    if (check(ref playerChoices, 2, 8)) // 5, 2, 8
                        return true;
                    
                    if (check(ref playerChoices, 8, 2)) // 5, 8, 2
                        return true;

                    if (check(ref playerChoices, 4, 6)) // 5, 4, 6
                        return true;
                    
                    if (check(ref playerChoices, 6, 4)) // 5, 6, 4
                        return true;

                    if (check(ref playerChoices, 1, 9)) // 5, 1, 9
                        return true;

                    if (check(ref playerChoices, 6, 4)) // 5, 9, 1
                        return true;

                    if (check(ref playerChoices, 6, 4)) // 5, 3, 7
                        return true;

                    if (check(ref playerChoices, 6, 4)) // 5, 7, 3
                        return true;
                }
            }
            return false;
        }

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
        static void XO()
        {
            Console.Clear();
            Console.WriteLine("\n\t****** X-O ******");

            int[] PlayerA = new int[5];             // player A inputs
            int[] PlayerB = new int[5];             // player B inputs
            int[] usedFields = new int[9];         // saves used fields to prevent reusing the field 
            int counter = 1;                        // usedFields counter
            string input;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Player A: ");
                input = Console.ReadLine();
                Int32.TryParse(input, out PlayerA[i]);      // changes input type from string to int
                bool valid = true;
                do
                {
                    // checks if inputed field number is used or not.(is filled already?)
                    for (int j = counter - 1; j >= 0; j--)
                    {
                        if (usedFields[j] == PlayerA[i])
                        {
                            valid = false;
                            Console.WriteLine("This field is used! try again: ");
                            input = Console.ReadLine();
                            Int32.TryParse(input, out PlayerA[i]);
                            break;
                        }
                        else
                            valid = true;
                    }
                } while (valid == false);

                usedFields[counter] = PlayerA[i];   // if the input is OK push it in usedFields
                counter++;
                if (WinCheck(ref PlayerA))              // checks if the player wins it or not in every turn
                {
                    Console.WriteLine("\n\tPlayer A is the Winner!");
                    break;
                }

                // everything happened for Player A also happens to Player B
                Console.Write("Player B: ");
                input = Console.ReadLine();
                Int32.TryParse(input, out PlayerB[i]);
                valid = true;
                do
                {
                    for (int j = counter - 1; j >= 0; j--)
                    {
                        if (usedFields[j] == PlayerB[i])
                        {
                            valid = false;
                            Console.Write("This field is used! try again: ");
                            input = Console.ReadLine();
                            Int32.TryParse(input, out PlayerB[i]);
                            break;
                        }
                        else
                            valid = true;
                    }
                } while (valid == false);
                usedFields[counter] = PlayerB[i];
                counter++;
                if (WinCheck(ref PlayerB))
                {
                    Console.WriteLine("\n\tPlayer B is the Winner!");
                    break;
                }
            }
        }

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
                        XO();           // starts game function

                        Console.WriteLine("Try Again? type 'yes' or 'no': ");
                        input = Console.ReadLine();
                        if( input == "yes" || input == "YES" || input == "Yes" )
                            valid = false;
                        if( input == "no" || input == "NO" || input == "No" )
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
        }
    }
}
