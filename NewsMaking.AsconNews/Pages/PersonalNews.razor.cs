using Microsoft.AspNetCore.Components;
using NewsMaking.AsconNews.Models;
using NewsMaking.AsconNews.Services;

namespace NewsMaking.AsconNews.Pages
{
 public partial class PersonalNews
 {
  [Inject]
  private IAsconService _asconService { get; set; }

  private IEnumerable<NewsModel> _personalnews;

  private Guid _id;

  private string _input = "";

  private async Task onIdChanged()
  {
   if (Guid.TryParse(_input, out _id))
   {
    await updatePersonalNews();
    StateHasChanged();
   }
  }

  private async Task updatePersonalNews()
  {
   _personalnews = await _asconService.GetPersonalNews(_id);
  }
 }
}
