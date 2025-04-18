namespace Bridge;

public class Player
{
    private readonly string _name;
    private List<Card> _hand;

    public Player(string name)
    {
        _name = name;
        _hand = new List<Card>();
    }
    
    public string Name
    {
        get => _name;
    }
}