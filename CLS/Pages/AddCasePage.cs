using System;
using System.Threading;
using Framework.Selenium;
using OpenQA.Selenium;

namespace CLS.Pages
{
    public class AddCasePage : PageBase
    {
        public readonly AddCasePageMap Map;

        public void Goto()
        {
            Driver.Wait.Until(drvr=>CLSMenu.Map.AddCasesLink.Clickable);
            CLSMenu.Map.AddCasesLink.Click();
        }

        public AddCasePage()
        {
            Map = new AddCasePageMap();
        }

        public void SaveCaseWithoutFill()
        {
           Map.save.Click();
  
        }

    }

    public class AddCasePageMap
    {
        public Element dateBox => Driver.FindElement(By.Id("addCaseBI_CaseDateHijri"), "File Date");
        public Element CaseType => Driver.FindElement(By.Id("CaseType"), "Case Type");
        public Element number => Driver.FindElement(By.Id("addCaseBI_CaseRegisterationNumber"), "number");
        public Element casenumber => Driver.FindElement(By.Id("casenumber"), "case number");
        public Element CaseRequestId => Driver.FindElement(By.Id("xId"), "Case Request Id");
        public Element LawyerID => Driver.FindElement(By.Id("LawyerID"), "Lawyer ID");
        public Element CaseSubject => Driver.FindElement(By.Id("addCaseBI_CaseSubject"), "Lawyer ID");
        public Element addCaseBI_CourtMasterTypeId => Driver.FindElement(By.Id("addCaseBI_CourtMasterTypeId"), "add Case BI_CourtMaster Type Id");
        public Element CourtTypeID => Driver.FindElement(By.Id("CourtTypeID"), "CourtTypeID");
        public Element CourtId => Driver.FindElement(By.Id("CourtId"), "Court Id");
        public Element Prosecutors => Driver.FindElement(By.Id("addCaseBI_Prosecutors"), "Prosecutors");
        public Element Defendants => Driver.FindElement(By.Id("addCaseBI_Defendants"), "Defendants");
        public Element officenumber => Driver.FindElement(By.Id("addCaseBI_CircuitDescription"), "office number");
        public Element save => Driver.FindElement(By.Id("submit"), "save");
        public Element draft => Driver.FindElement(By.Id("btn.btn-mot.draftbtn"), "draft");
        public Element ignore => Driver.FindElement(By.Id("btn.btn-mot.ignorebtn"), "ignore");
        public Element close => Driver.FindElement(By.Id("btn.btn-mot.closebtn"), "close");
        public Element popupwindow => Driver.FindElement(By.Id("btn.btn-mot.closebtn"), "close");
    }
}
