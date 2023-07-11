using Microsoft.AspNetCore.Components;
using NewsMaking.AsconNews.Pages;

namespace NewsMaking.AsconNews.Components
{
 public partial class NewsComponent
 {
  [Parameter]
  public Models.NewsModel news { get; set; }
 }
}
