using Microsoft.AspNetCore.Mvc;

namespace BookStore.Components
{
    public class SearchComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
