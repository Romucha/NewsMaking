using NewsMaking.AsconNews.Models;
using System.Diagnostics;
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

  public async Task<IEnumerable<NewsModel>> GetNews()
  {  
   List<NewsModel> list = new List<NewsModel>();
   foreach (var path in await GetNewsPaths()) 
   {
    list.Add(await GetNewsModelFromUri(path));
   }
   return list;
  }

  public Task<PersonalNewsModel> GetPersonalNews()
  {
   throw new NotImplementedException();
  }

  private async Task<IEnumerable<string>> GetNewsPaths()
  {
   var content = new FormUrlEncodedContent(new Dictionary<string, string>()
   {
    { "Operation", "GetNews" }
   });
   var res = await _httpClient.PostAsync("", content);
   if (res.IsSuccessStatusCode)
   {
    var newsRaw = await res.Content.ReadAsStringAsync();
    return newsRaw.Split('*', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
   }
   return null;
  }

  private async Task<NewsModel> GetNewsModelFromUri(string uri)
  {
   return await _httpClient.GetFromJsonAsync<NewsModel>(uri);
  }
 }
}
