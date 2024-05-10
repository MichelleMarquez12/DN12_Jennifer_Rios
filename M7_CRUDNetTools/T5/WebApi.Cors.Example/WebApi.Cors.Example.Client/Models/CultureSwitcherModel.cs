using System.Globalization;

namespace WebApi.Cors.Example.Client.Models
{
	public class CultureSwitcherModel
	{
		public CultureInfo CurrentUICulture { get; set; }

		public List<CultureInfo> SupportedCultures { get; set; }
	}
}
