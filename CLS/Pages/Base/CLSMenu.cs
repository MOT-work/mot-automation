using Framework.Selenium;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace CLS.Pages
{
    public class CLSMenu
    {
         public readonly CLSMenuMap Map;

        public CLSMenu()
        {
            Map = new CLSMenuMap();
        }

        public void GotoAddCasePage()
        {
            Driver.Wait.Until(ExpectedConditions.ElementToBeClickable(Map.AddCasesLink.FoundBy));
            Map.AddCasesLink.Click();
        }

        public void GotoViewCasesPage()
        {
            Driver.Wait.Until(ExpectedConditions.ElementToBeClickable(Map.ViewCasesLink.FoundBy));
            Map.ViewCasesLink.Click();
        }
    }
    public class CLSMenuMap
    {
        public Element ViewCasesLink => Driver.FindElement(By.XPath("//a[contains(@href,'/CLS/Case')]"), "View Cases Link");
        public Element AddCasesLink => Driver.FindElement(By.CssSelector("//a[contains(@href,'/CLS/Case/Create')]"), "Add Cases Link");
        public Element NotificationsLink => Driver.FindElement(By.CssSelector("//a[contains(@href,'/CLS/Notifications')]"), "Notifications Link");
        public Element UpcommingAppointmentsLink => Driver.FindElement(By.CssSelector("//a[contains(@href,'/CLS/Session/UpcomingAppointment')]"), "Upcoming Appointments Link");
        public Element MissedAppointmentsLink => Driver.FindElement(By.CssSelector("//a[contains(@href,'/CLS/Session/PastAppointment')]"), "Missed Appointments Link");
        public Element SessionsLink => Driver.FindElement(By.CssSelector("//a[contains(@href,'/CLS/Session')][3]"), "Sessions Link");
        public Element MandateSessionsLink => Driver.FindElement(By.CssSelector("//a[contains(@href,'/CLS/AttendeesList')]"), "Mandate Sessions Link");
        public Element AdvancedSearchLink => Driver.FindElement(By.CssSelector("//a[contains(@href,'/CLS/SearchPanel')]"), "Advanced Search Link");
        public Element UsersManagementLink => Driver.FindElement(By.CssSelector("//a[contains(@href,'/CLS/Administration')]"), "User Management Link");
    }
}
