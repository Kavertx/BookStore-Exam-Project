using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Admin.Components
{
    public class AdminMainComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
