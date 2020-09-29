using System;
using Framework.Selenium;
using OpenQA.Selenium;

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
            Goto();
        }

        public static void Goto()
        {
            Driver.Goto("https://stg-webapps.mot.gov.sa/CLS/Case");
            Driver.Wait.Until(driver => !driver.FindElement(By.CssSelector("p.loadingTable")).Displayed);
        }
    }
}
