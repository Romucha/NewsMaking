using NewsMaking.AsconNews.Models;

namespace NewsMaking.AsconNews.Services
{
 public interface IAsconService
 {
  Task<IEnumerable<NewsModel>> GetNews();

  Task<AnnounceModel> GetAnnounce();

  Task<PersonalNewsModel> GetPersonalNews();
 }
}
