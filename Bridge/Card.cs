namespace Bridge;

public class Card
{
    private readonly int _rankNumber;
    private readonly string _rankName;
    private readonly string _suitSymbol;
    private readonly string _suitName;

    public Card(int rankNumber, string rankName, string suitSymbol, string suitName)
    {
        _rankNumber = rankNumber;
        _rankName = rankName;
        _suitSymbol = suitSymbol;
        _suitName = suitName;
    }

    public int RankNumber
    {
        get => _rankNumber;
    }
    
    public string RankName
    {
        get => _rankName;
    }

    public string SuitSymbol
    {
        get => _suitSymbol;
    }

    public string SuitName
    {
        get => _suitName;
    }
}