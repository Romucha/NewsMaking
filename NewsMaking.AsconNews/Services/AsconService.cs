using NewsMaking.AsconNews.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace NewsMaking.AsconNews.Services
{
 public class AsconService : IAsconService
 {
  private readonly HttpClient _httpClient;
  public AsconService(HttpClient httpClient)
  {
   _httpClient = httpClient;
  }
  public async Task<AnnounceModel> GetAnnounce()
  {
   string req = "/patchstorage/ascon.cc.announce/announce.json";
   return await _httpClient.GetFromJsonAsync<AnnounceModel>(req);
  }

  public Task<IEnumerable<NewsModel>> GetNews()
  {
   throw new NotImplementedException();
  }

  public Task<PersonalNewsModel> GetPersonalNews()
  {
   throw new NotImplementedException();
  }
 }
}
