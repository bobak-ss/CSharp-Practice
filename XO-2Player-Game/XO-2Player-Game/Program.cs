using System;

namespace XO_2Player_Game
{
    class Program
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
        static void XO()
        {
            Console.Clear();
            Console.WriteLine("\n\t****** X-O ******");

            int[] PlayerA = new int[5];             // player A inputs
            int[] PlayerB = new int[5];             // player B inputs
            int[] usedFields = new int[99];         // saves used fields to prevent reusing the field 
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
                if (WinCheck(PlayerA))              // checks if the player wins it or not in every turn
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
                if (WinCheck(PlayerB))
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
        static bool WinCheck(int[] playerChoices)
        {
            for (int i = 0; i < 5; i++)
            {
                if (playerChoices[i] == 1) // *************************** 1
                {
                    for (int j = 0; j < 5; j++) // 1, 2, 3
                        if (playerChoices[j] == 2)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 3)
                                    return true;
                    for (int j = 0; j < 5; j++) // 1, 3, 2
                        if (playerChoices[j] == 3)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 2)
                                    return true;

                    for (int j = 0; j < 5; j++) // 1, 4, 7
                        if (playerChoices[j] == 4)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 7)
                                    return true;
                    for (int j = 0; j < 5; j++) // 1, 7, 4
                        if (playerChoices[j] == 7)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 4)
                                    return true;

                    for (int j = 0; j < 5; j++) // 1, 5, 9
                        if (playerChoices[j] == 5)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 9)
                                    return true;
                    for (int j = 0; j < 5; j++) // 1, 9, 5
                        if (playerChoices[j] == 9)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 5)
                                    return true;
                }

                if (playerChoices[i] == 3) // *************************** 3
                {
                    for (int j = 0; j < 5; j++) // 3, 2, 1
                        if (playerChoices[j] == 2)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 1)
                                    return true;
                    for (int j = 0; j < 5; j++) // 3, 1, 2
                        if (playerChoices[j] == 1)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 2)
                                    return true;

                    for (int j = 0; j < 5; j++) // 3, 6, 9
                        if (playerChoices[j] == 6)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 9)
                                    return true;
                    for (int j = 0; j < 5; j++) // 3, 9, 6
                        if (playerChoices[j] == 9)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 6)
                                    return true;

                    for (int j = 0; j < 5; j++) // 3, 5, 7
                        if (playerChoices[j] == 5)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 7)
                                    return true;
                    for (int j = 0; j < 5; j++) // 3, 7, 5
                        if (playerChoices[j] == 7)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 5)
                                    return true;
                }

                if (playerChoices[i] == 7) // *************************** 7
                {
                    for (int j = 0; j < 5; j++) // 7, 8, 9
                        if (playerChoices[j] == 8)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 9)
                                    return true;
                    for (int j = 0; j < 5; j++) // 7, 9, 8
                        if (playerChoices[j] == 9)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 8)
                                    return true;

                    for (int j = 0; j < 5; j++) // 7, 4, 1
                        if (playerChoices[j] == 4)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 1)
                                    return true;
                    for (int j = 0; j < 5; j++) // 7, 1, 4
                        if (playerChoices[j] == 1)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 4)
                                    return true;

                    for (int j = 0; j < 5; j++) // 7, 5, 3
                        if (playerChoices[j] == 5)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 3)
                                    return true;
                    for (int j = 0; j < 5; j++) // 7, 3, 5
                        if (playerChoices[j] == 3)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 5)
                                    return true;
                }

                if (playerChoices[i] == 9) // *************************** 9
                {
                    for (int j = 0; j < 5; j++) // 9, 8, 7
                        if (playerChoices[j] == 8)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 7)
                                    return true;
                    for (int j = 0; j < 5; j++) // 9, 7, 8
                        if (playerChoices[j] == 7)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 8)
                                    return true;

                    for (int j = 0; j < 5; j++) // 9, 6, 3
                        if (playerChoices[j] == 6)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 3)
                                    return true;
                    for (int j = 0; j < 5; j++) // 9, 3, 6
                        if (playerChoices[j] == 3)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 6)
                                    return true;

                    for (int j = 0; j < 5; j++) // 9, 5, 1
                        if (playerChoices[j] == 5)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 1)
                                    return true;
                    for (int j = 0; j < 5; j++) // 9, 1, 5
                        if (playerChoices[j] == 1)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 5)
                                    return true;
                }

                if (playerChoices[i] == 2) // *************************** 2
                {
                    for (int j = 0; j < 5; j++) // 2, 5, 8
                        if (playerChoices[j] == 5)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 8)
                                    return true;
                    for (int j = 0; j < 5; j++) // 2, 8, 5
                        if (playerChoices[j] == 8)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 5)
                                    return true;
                }

                if (playerChoices[i] == 4) // *************************** 4
                {
                    for (int j = 0; j < 5; j++) // 4, 5, 6
                        if (playerChoices[j] == 5)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 6)
                                    return true;
                    for (int j = 0; j < 5; j++) // 4, 6, 5
                        if (playerChoices[j] == 6)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 5)
                                    return true;
                }

                if (playerChoices[i] == 6) // *************************** 6
                {
                    for (int j = 0; j < 5; j++) // 6, 5, 4
                        if (playerChoices[j] == 5)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 4)
                                    return true;
                    for (int j = 0; j < 5; j++) // 6, 4, 5
                        if (playerChoices[j] == 4)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 5)
                                    return true;
                }

                if (playerChoices[i] == 8) // *************************** 8
                {
                    for (int j = 0; j < 5; j++) // 8, 5, 2
                        if (playerChoices[j] == 5)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 2)
                                    return true;
                    for (int j = 0; j < 5; j++) // 8, 2, 5
                        if (playerChoices[j] == 2)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 5)
                                    return true;
                }

                if (playerChoices[i] == 5) // *************************** 5
                {
                    for (int j = 0; j < 5; j++) // 5, 2, 8
                        if (playerChoices[j] == 2)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 8)
                                    return true;
                    for (int j = 0; j < 5; j++) // 5, 8, 2
                        if (playerChoices[j] == 8)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 2)
                                    return true;
                    for (int j = 0; j < 5; j++) // 5, 4, 6
                        if (playerChoices[j] == 4)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 6)
                                    return true;
                    for (int j = 0; j < 5; j++) // 5, 6, 4
                        if (playerChoices[j] == 6)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 4)
                                    return true;
                    for (int j = 0; j < 5; j++) // 5, 1, 9
                        if (playerChoices[j] == 1)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 9)
                                    return true;
                    for (int j = 0; j < 5; j++) // 5, 9, 1
                        if (playerChoices[j] == 9)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 1)
                                    return true;
                    for (int j = 0; j < 5; j++) // 5, 3, 7
                        if (playerChoices[j] == 3)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 7)
                                    return true;
                    for (int j = 0; j < 5; j++) // 5, 7, 3
                        if (playerChoices[j] == 7)
                            for (int z = 0; z < 5; z++)
                                if (playerChoices[z] == 3)
                                    return true;
                }
            }
            return false;
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

            Console.ReadLine();
        }
    }
}
