using NewsMaking.AsconNews.Models;
using System.Diagnostics;
using System.Net.Http.Json;
using Newtonsoft.Json;

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
   foreach (var path in await GetNewsPaths(new Dictionary<string, string>()
   {
    { "Operation", "GetNews" }
   }))
   {
    list.Add(await GetNewsModelFromUri(path));
   }
   return list;
  }

  public async Task<IEnumerable<NewsModel>> GetPersonalNews(Guid UserID)
  {
   var content = new Dictionary<string, string>()
   {
    { "AgentID", $"{UserID.ToString().ToUpper()}" },
    { "Operation", "GetPersonalNews" }
   };
   List<NewsModel> list = new List<NewsModel>();
   foreach (var path in await GetNewsPaths(content, "/personalnews.php"))
   {
    list.Add(await GetNewsModelFromUri(path));
   }
   return list;
  }

  private async Task<IEnumerable<string>> GetNewsPaths(Dictionary<string, string> contentParams, string additionalAddress = "")
  {
   var content = new FormUrlEncodedContent(contentParams);
   var res = await _httpClient.PostAsync(additionalAddress, content);
   if (res.IsSuccessStatusCode)
   {
    var newsRaw = await res.Content.ReadAsStringAsync();
    return newsRaw.Split('*', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
   }
   return null;
  }

  private async Task<NewsModel> GetNewsModelFromUri(string uri)
  {
   var res = await _httpClient.GetAsync(uri);
   var rawJson = await res.Content.ReadAsStringAsync();
   return JsonConvert.DeserializeObject<NewsModel>(rawJson, new JsonSerializerSettings()
   {
    DateFormatString = "dd.MM.yyyy HH:mm zzz"
   });
  }
 }
}
