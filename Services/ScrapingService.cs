using Microsoft.Playwright;

namespace SportApi.Services;

public class ScrapingService : ISearch
{
  private readonly List<DataModel> data = new List<DataModel>();

  public List<DataModel> Data => data;

  ///<summary>
  /// Retrieves data about the Team
  /// </summary>
  /// <param name="teamName"></param>
  public async Task<List<DataModel>> Search(string teamName)
  {
    try
    {
      // Initialize Playwrite
      var playwright = await Playwright.CreateAsync();
      // Launch a browser
      var browser = playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
      // Open a new page
      var page = await browser.NewPageAsync();
    }
    catch (Exception e)
    {

    }
  }
}
