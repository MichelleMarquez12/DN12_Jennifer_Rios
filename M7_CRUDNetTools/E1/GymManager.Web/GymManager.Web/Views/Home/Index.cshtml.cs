using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;

namespace GymManager.Web.Views.Home
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IStringLocalizer<IndexModel> _localizer;
        private readonly IHtmlLocalizer<IndexModel> _htmlLocalizer;

        public IndexModel(ILogger<IndexModel> logger, IStringLocalizer<IndexModel> localizer, IHtmlLocalizer<IndexModel> htmlLocalizer)
        {
            _logger = logger;
            _localizer = localizer;
            _htmlLocalizer = htmlLocalizer;
        }

        public void OnGet()
        {
            ViewData["ResultMessage"] = _localizer.GetString("SuccessMessage");
        }
    }
}
