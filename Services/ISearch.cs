namespace SportApi.Services;
public interface ISearch
{
  Task<List<DataModel>> Search(string teamName);
}
