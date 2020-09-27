using System;
using Framework.Selenium;

namespace CLS.Pages
{
    public static class Pages
    {
        [ThreadStatic] public static ViewCasesPage ViewCase;

        [ThreadStatic] public static AddCasePage AddCase;


        public static void Init()
        {
            ViewCase = new ViewCasesPage();
            AddCase = new AddCasePage();
        }

        public static void Goto()
        {
            //Driver.Goto("https://stg-webapps.mot.gov.sa/CLS");
            Driver.Goto("https://watch.na.lolesports.com/standings");
            //Driver.Wait.Until(driver => ViewCase.Map.SearchTextbox.Displayed);
        }
    }
}
