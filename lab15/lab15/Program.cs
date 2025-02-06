class lab15
{
    static void Main(string[] args)
    {
        ChocolateDivision();
    }

    static void ChocolateDivision()
    {
        int totalBars = 4;
        int piecesPerBar = 28;
        int totalPieces = totalBars * piecesPerBar;
        int piecesForUser = 5;
        int piecesToShare = totalPieces - piecesForUser;
        int friends = 7;
        int piecesPerFriend = piecesToShare / friends;
        Console.WriteLine(piecesPerFriend + " piece per friend");
    }
}