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
           // Pages.Goto();
            Pages.AddCase.Goto();
            Pages.AddCase.SaveCaseWithoutFill();
             Assert.That(Pages.AddCase.Map.CheckMandatoryField.Displayed);
            //Assert.AreEqual("هذا الحقل مطلوب");
           // Pages.AddCase.ClickCard("Regular Season");
            //Assert.That(Pages.ServiceStatus.ServiceOnline("Game"));
            //update
        }

        [Test, Parallelizable, Category("AddCase")]
        public void Secretary_Save_case_with_fill_all_fields()
        {
            Pages.Goto();
            Pages.AddCase.Goto();
            Pages.AddCase.SaveCaseWithFillFields("14420202", "قضية مرفوعة ضد الوزارة" , "148ا", "23943", "2", "2", "قضية", "2", "2","2", 23);
        }

        [Test, Parallelizable, Category("AddCase")]
        public void Add_Case_As_Draft()
        {
           // Pages.Goto();
            Pages.AddCase.Goto();
            Pages.AddCase.CloseCase();
            //Pages.AddCase.SaveCaseAsDraft("2", "7567", "3", "قضية 11");
        }
         [Test, Parallelizable, Category("AddCase")]
        public void Close_Case()
        {
            Pages.Goto();
            Pages.AddCase.Goto();
            Pages.AddCase.CloseCase();
        }


    }
}
