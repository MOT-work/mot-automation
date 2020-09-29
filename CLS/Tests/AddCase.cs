using System;
using Framework.Selenium;
using NUnit.Framework;
using Tests.Base;
using CLS.Pages;

namespace Tests
{
    [TestFixture, Parallelizable]
    public class AddCase : TestBase
    {
        [Test, Parallelizable, Category("AddCase")]
        public void Secretary_Save_case_without_fill_fields()
        {
            //Pages.Goto();
            Pages.AddCase.Goto();
            Pages.AddCase.SaveCaseWithoutFill();
        }

        [Test, Parallelizable, Category("AddCase")]
        public void Secretary_Save_case_with_fill_all_fields()
        {
            //Pages.Goto();
            Pages.AddCase.Goto();
            Pages.AddCase.SaveCaseWithFillFields("14420212", "1", "12w3", "333e222", "1", 1, "string CaseSubject", "2", "1","الأحساء", "rt",  23);

        }

    }
}
