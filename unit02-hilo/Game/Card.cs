using System;

namespace Hilo
{
  public class Card
  {
    public Card()
    {

    }

// Generates a card with a random value between 1 and 13
    public int GenerateCard()
    {
        Random random = new Random();
        int value = random.Next(1,14);
        return value;
    }
  }
}