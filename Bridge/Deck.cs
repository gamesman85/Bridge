namespace Bridge;

public class Deck
{
    private List<Card> _cards = new List<Card>();

    private static string ConvertNumberToName(int number)
    {
        if (number > 2 && number < 11)
            return number.ToString();
        else if (number == 11)
            return "J";
        else if (number == 12)
            return "Q";
        else if (number == 13)
            return "K";
        else if (number == 14)
            return "A";
        else if (number == 2)
            return "2";
        else
            return "";
    }

    public Deck()
    {
        string[] suits = { "♠", "♥", "♦", "♣" };
        string[] suitNames = { "Spades", "Hearts", "Diamonds", "Clubs" };
        
        for (int s = 0; s < 4; s++)
        {
            for (int r = 2; r <= 14; r++)
            {
                string rankName = ConvertNumberToName(r);
                _cards.Add(new Card(r, rankName, suits[s], suitNames[s]));
            }
        }
    }
}