using Framework.Selenium;
using OpenQA.Selenium;

namespace CLS.Pages
{
    public class ViewCasesPage : PageBase
	{
		public readonly ViewCasesPageMap Map;

		public ViewCasesPage()
		{
			Map = new ViewCasesPageMap();
		}
	}

	public class ViewCasesPageMap
	{
        public Element SearchTextbox => Driver.FindElement(By.CssSelector("//input[@type='search']"));
	}
}
