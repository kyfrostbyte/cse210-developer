using System;

namespace Program
{
    class Program
    {
      static string userMove = "0";
        // Main Function test
        
        static void Main(string[] args)
        {
            List<string>spotList = createSpotList();
            printGrid(spotList); 
        }

        // Prints the 3x3 Grid
        static string printGrid(List<string>spotList)
        {
            Console.WriteLine($"{spotList[0]} | {spotList[1]} | {spotList[2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{spotList[3]} | {spotList[4]} | {spotList[5]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{spotList[6]} | {spotList[7]} | {spotList[8]}");
            string playerX = "X";
            string playerO = "O";
            bool gameOver = determineGameOutcome(spotList, playerX, playerO);
            bool gameTie = determineTie(spotList, playerX, playerO);
            if (gameOver == true)
            {
                Console.WriteLine("Game Over! Congrats to the victor! "); 
                while(gameOver == true)
                {
                    break;
                }
                return null;
            }
            else if(gameTie  == true)
            {
                Console.WriteLine("No more moves available, so it ends in a tie!");
                while(gameTie == true)
                {
                    break;
                }
                return null;
            }
            else
            {
                getInput(spotList);
                return null;
            }

        }
        //Creates a list of numbers to populate the 3x3 grid
        static List<string> createSpotList()
        {
            List<string> spotList = new List<string>();
            spotList.Add("1");
            spotList.Add("2");
            spotList.Add("3");
            spotList.Add("4");
            spotList.Add("5");
            spotList.Add("6");
            spotList.Add("7");
            spotList.Add("8");
            spotList.Add("9");
            return spotList;
        }

        // Gets input from user that determines which tic they would like to tac
        static void getInput(List<string>spotList)
        {
            if (userMove == "0")
            {
                Console.WriteLine("It is X's move. Please select a number 1-9: ");
                string userInput = Console.ReadLine();
                string spotTaken = availableMove(userInput, spotList);
                if(spotTaken == "True")
                {
                    Console.WriteLine($"Square {userInput} has already been taken.");
                    Console.WriteLine("Please select a different square.");
                    getInput(spotList);
                }
                else
                {
                    string teamLetter = determineTeam(userMove);
                    applyInput(userInput, teamLetter, spotList);
                    userMove = "1";
                    Console.WriteLine(" ");
                    printGrid(spotList);   
                }
            }
            else
            {
                Console.WriteLine("It is O's move. Please select a number 1-9: ");
                string userInput = Console.ReadLine();
                string spotTaken = availableMove(userInput, spotList);
                string teamLetter = determineTeam(userMove);
                applyInput(userInput, teamLetter, spotList);
                userMove = "0";
                Console.WriteLine(" ");
                printGrid(spotList);
            }
        }

        // Determines whether an X or O hould be pasted on the Grid
        static string determineTeam (string userMove)
        {   if (userMove == "0")
            {
                string teamLetter = "X";
                return teamLetter;
            }
            else
            {
                string teamLetter ="O";
                return teamLetter;
            }
        }

        // Takes the users input and places their letter on the corresponding cell
        static string applyInput(string userInput, string teamLetter, List<string>spotList)
        {
            if (userInput == "1")
            {   
                for(int i=0;i<spotList.Count;i++)
                {
                    if(spotList[0].Contains("1"))
                    spotList[0] = teamLetter;
                }
                return spotList[0];
            }
            else if (userInput == "2")
            {
                for(int i=0;i<spotList.Count;i++)
                {
                    if(spotList[1].Contains("2"))
                    spotList[1] = teamLetter;
                }
                return spotList[1];
            }
            else if (userInput == "3")
            {
                for(int i=0;i<spotList.Count;i++)
                {
                    if(spotList[2].Contains("3"))
                    spotList[2] = teamLetter;
                }
                return spotList[2];
            }
            else if (userInput == "4")
            {
                for(int i=0;i<spotList.Count;i++)
                {
                    if(spotList[3].Contains("4"))
                    spotList[3] = teamLetter;
                }
                return spotList[3];
            }
            else if (userInput == "5")
            {
                for(int i=0;i<spotList.Count;i++)
                {
                    if(spotList[4].Contains("5"))
                    spotList[4] = teamLetter;
                }
                return spotList[4];
            }
            else if (userInput == "6")
            {
                for(int i=0;i<spotList.Count;i++)
                {
                    if(spotList[5].Contains("6"))
                    spotList[5] = teamLetter;
                }
                return spotList[5];
            }
            else if (userInput == "7")
            {
                for(int i=0;i<spotList.Count;i++)
                {
                    if(spotList[6].Contains("7"))
                    spotList[6] = teamLetter;
                }
                return spotList[6];
            }
            else if (userInput == "8")
            {
                for(int i=0;i<spotList.Count;i++)
                {
                    if(spotList[7].Contains("8"))
                    spotList[7] = teamLetter;
                }
                return spotList[7];
            }
            else if (userInput == "9")
            {
                for(int i=0;i<spotList.Count;i++)
                {
                    if(spotList[8].Contains("9"))
                    spotList[8] = teamLetter;
                }
                return spotList[8];
            }    
            else
            {
                Console.WriteLine("Invalid input. Please type a number.");
                return null;
            }
        }

        // Checks to see if users move will overwrite a preexisting move
        static string availableMove(string userInput, List<string> spotList)
        {
            int res;
            res = Convert.ToInt32(userInput);
            int checkListIndex = res - 1;
            for(int i=0;i<spotList.Count;i++)
                {
                    while(spotList[checkListIndex].Contains($"{userInput}"))
                    {
                        return null;
                    }
                    string playerX = "X";
                    string playerO = "O";
                    bool gameOver = determineGameOutcome(spotList, playerX, playerO);
                    bool gameTie = determineTie(spotList, playerX, playerO);
                    if (gameOver == true)
                    {
                        Console.WriteLine("Game Over! Congrats to the victor! "); 
                        break;
                    }
                    else if(gameTie  == true)
                    {
                        Console.WriteLine("No more moves available, so it ends in a tie!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This square is taken");
                        getInput(spotList);
                        break;
                    }
                }
                return spotList[0];
            return null ;

        }

        //Determines if a player has won the game
        static bool determineGameOutcome(List<string>spotList, string playerX, string playerO)
        {
            bool isWinner = false;

            if ((spotList[0] == playerX && spotList[1] == playerX && spotList[2] == playerX)
                || (spotList[3] == playerX && spotList[4] == playerX && spotList[5] == playerX)
                || (spotList[6] == playerX && spotList[7] == playerX && spotList[8] == playerX)
                || (spotList[0] == playerX && spotList[3] == playerX && spotList[6] == playerX)
                || (spotList[1] == playerX && spotList[4] == playerX && spotList[7] == playerX)
                || (spotList[2] == playerX && spotList[5] == playerX && spotList[8] == playerX)
                || (spotList[0] == playerX && spotList[4] == playerX && spotList[8] == playerX)
                || (spotList[2] == playerX && spotList[4] == playerX && spotList[6] == playerX)
                )
            {
                isWinner = true;
            }
            else if ((spotList[0] == playerO && spotList[1] == playerO && spotList[2] == playerO)
                || (spotList[3] == playerO && spotList[4] == playerO && spotList[5] == playerO)
                || (spotList[6] == playerO && spotList[7] == playerO && spotList[8] == playerO)
                || (spotList[0] == playerO && spotList[3] == playerO && spotList[6] == playerO)
                || (spotList[1] == playerO && spotList[4] == playerO && spotList[7] == playerO)
                || (spotList[2] == playerO && spotList[5] == playerO && spotList[8] == playerO)
                || (spotList[0] == playerO && spotList[4] == playerO && spotList[8] == playerO)
                || (spotList[2] == playerO && spotList[4] == playerO && spotList[6] == playerO)
                )
            {
                isWinner = true;
                
            }
            return isWinner; 
        }

        static bool determineTie(List<string>spotList, string playerX, string playerO)
        {
            bool isTie = false;
            
            if((spotList[0] == playerO || spotList[0] == playerX) && (spotList[1] == playerO || spotList[1] == playerX) &&
               (spotList[2] == playerO || spotList[2] == playerX) && (spotList[3] == playerO || spotList[3] == playerX) &&
               (spotList[4] == playerO || spotList[4] == playerX) && (spotList[5] == playerO || spotList[5] == playerX) &&
               (spotList[6] == playerO || spotList[6] == playerX) && (spotList[7] == playerO || spotList[7] == playerX) &&
               (spotList[8] == playerO || spotList[8] == playerX)
                )
            {
                isTie = true;
                
            }
            return isTie;
        }

    }
}
