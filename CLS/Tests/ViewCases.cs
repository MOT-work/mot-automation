using System;
using Framework.Selenium;
using NUnit.Framework;
using Tests.Base;
using CLS.Pages;

namespace Tests
{
    [TestFixture, Parallelizable]
    public class ViewCases : TestBase
    {
        [Test, Parallelizable, Category("ViewCases")]
        public void Laywer_view_cases()
        {
            Pages.Goto();
            Pages.AddCase.Goto();
            Pages.AddCase.ClickCard("Regular Season");
            //Pages.AddCase.SaveCaseWithoutFill();
            //Assert.That(Pages.ServiceStatus.ServiceOnline("Game"));
        }
    }
}
