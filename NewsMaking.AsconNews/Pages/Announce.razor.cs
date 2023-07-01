using Microsoft.AspNetCore.Components;
using NewsMaking.AsconNews.Models;
using NewsMaking.AsconNews.Services;

namespace NewsMaking.AsconNews.Pages
{
 public partial class Announce
 {
  [Inject]
  private IAsconService _asconService { get; set; }

  private AnnounceModel _currentAnnounce { get; set; }

  protected override async Task OnInitializedAsync()
  {
   _currentAnnounce = await _asconService.GetAnnounce();
  }
 }
}
