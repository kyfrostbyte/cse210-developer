using System;

namespace Hilo
{
  class Director
  {
    Card card = new Card();
    public int playerScore = 300;
    public int points = 0;
    bool _isPlaying = true;
    string userInput = "";

    
    public Director()
    {

    }

// Loops through the functions to run the game, until _isPlaying is set to false, in which case the program ends
    public void StartGame()
    {   int _firstCard = card.GenerateCard();
        int _secondCard = card.GenerateCard();
        while (_isPlaying)
        {
            GetInput(_firstCard);
            ApplyInput(_firstCard, _secondCard);
            ContinuePlaying();
            _firstCard = _secondCard;
            _secondCard = card.GenerateCard();
        }
        Console.WriteLine("Thanks for playing!");
    }

// Gets input from user, asking them their prediction for Higher or Lower
    public void GetInput(int _firstCard)
    {
        Console.WriteLine($"The Card is: {_firstCard}");
        Console.WriteLine("Higher or Lower? (h/l) ");
        userInput = Console.ReadLine();
    }

// Compares the value of the second card to the first card User Input. Changes score respectively
    public void ApplyInput(int _firstCard, int _secondCard)
    {
      if (!_isPlaying)
      {
          return;
      }
      Console.WriteLine($"The Next Card Was: {_secondCard}");
      if(userInput == "h")
      {
        if(_secondCard > _firstCard)
        {
          points = 100;
          Console.WriteLine("Correct! +100 Points!");
          
        }
        else
        {
          points = -75;
          Console.WriteLine("Incorrect! -75 Points!");
        }
      }
      else
        if(_secondCard < _firstCard)
        {
          points = 100;
          Console.WriteLine("Correct! +100 Points!");
        }
        else
        {
          points = -75;
          Console.WriteLine("Incorrect! -75 Points!");
        }
      playerScore += points;
      Console.WriteLine($"Current Score: {playerScore}");
      Console.WriteLine("");
    }


// Asks user if they would like to play again. If yes, program loops again. If no, program ends.
    public void ContinuePlaying()
    {
      if(playerScore > 0)
      {
        Console.WriteLine("Would you like to play again? (y/n) ");
        string continuePlaying = Console.ReadLine();
        _isPlaying = (continuePlaying == "y");
      }
      else
      {
        Console.Write("You have run out of points!");
        _isPlaying = false;
      }
    }
  }
}