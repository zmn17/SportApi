namespace SportApi.Services;
public class Player
{
  public string Name { get; set; } = null!;
  public int Age { get; set; }
  public string Position { get; set; } = null!;
  public string Footed { get; set; } = null!;
  public string Nationality { get; set; } = null!;
  public string NationalTeam { get; set; } = null!;
  public int MatchsPlayed { get; set; }
  public int Goals { get; set; }
  public int Assists { get; set; }
}
