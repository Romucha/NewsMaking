using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
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

  private void onChange(ChangeEventArgs e)
  {
   _input = e.Value.ToString();
  }

  private async Task onKeyUp(KeyboardEventArgs e)
  {
   if (e.Code == "Enter" || e.Code == "NumpadEnter")
   {
    if (Guid.TryParse(_input, out _id))
    {
     await updatePersonalNews();
     StateHasChanged();
    }
   }
  }

  private async Task updatePersonalNews()
  {
   _personalnews = await _asconService.GetPersonalNews(_id);
  }
 }
}
