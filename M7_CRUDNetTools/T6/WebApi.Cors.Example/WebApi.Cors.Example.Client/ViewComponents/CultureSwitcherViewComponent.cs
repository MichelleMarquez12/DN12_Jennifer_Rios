using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApi.Cors.Example.Client.Models;

namespace WebApi.Cors.Example.Client.ViewComponents
{
	public class CultureSwitcherViewComponent : ViewComponent
	{
		private readonly IOptions<RequestLocalizationOptions> localizationOptions;

		public CultureSwitcherViewComponent(IOptions<RequestLocalizationOptions> localizationOptions) =>
			this.localizationOptions = localizationOptions;

		public IViewComponentResult Invoke()
		{
			var cultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();

			var model = new CultureSwitcherModel
			{
				SupportedCultures = localizationOptions.Value.SupportedUICultures.ToList(),
				CurrentUICulture = cultureFeature.RequestCulture.UICulture
			};
			return View(model);
		}
	}
}
