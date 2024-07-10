namespace SportApi.Services;
public class DataModel
{
  public string TeamName { get; set; } = null!;
  public string Competition { get; set; } = null!;
  public string Season { get; set; } = null!;
  public string PositionInTable { get; set; } = null!;
  public List<OppositeTeam> Opponents { get; set; } = new List<OppositeTeam>();
  public DateTime MatchDate { get; set; }
  public string Venue { get; set; } = null!;
  public int MatchWeek { get; set; }
  public List<Player> XI { get; set; } = new List<Player>();
  public List<Player> Subs { get; set; } = new List<Player>();
}
