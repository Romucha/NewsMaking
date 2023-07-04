using Microsoft.AspNetCore.Components;
using NewsMaking.AsconNews.Models;
using NewsMaking.AsconNews.Services;
using Newtonsoft.Json;

namespace NewsMaking.AsconNews.Pages
{
    public partial class News
    {
        [Inject]
        private IAsconService _asconService { get; set; }

        private IEnumerable<NewsModel> _news;

        protected override async Task OnInitializedAsync()
        {
            _news = await _asconService.GetNews();
            await base.OnInitializedAsync();
        }
    }
}
