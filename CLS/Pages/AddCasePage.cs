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
           Map.SaveCaseButton.Click();
  
        }
        public void SaveCaseWithFillFields(string dateBox1, string CaseType, string number, string casenumber, string CaseRequestId, int LawyerID, string CaseSubject, string CourtMasterTypeId, string CourtTypeID,
         string CourtId, string Prosecutors, int officenumber)
        {
            Map.dateBox.SendKeys(" ");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.CaseType,"");
            Map.number.SendKeys("");
            Map.casenumber.SendKeys("");
           // Map.CaseRequestId.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.CaseRequestId,"");
           // Map.LawyerID.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.INDEX,Map.LawyerID,"");
            Map.CaseSubject.SendKeys("");
            //Map.addCaseBI_CourtMasterTypeId.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.addCaseBI_CourtMasterTypeId,"");
            //Map.CourtTypeID.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.CourtTypeID,"");
            //Map.CourtId.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.TEXT,Map.CourtId,"");
            Map.Prosecutors.SendKeys("");
            Map.officenumber.SendKeys("");
            Map.SaveCaseButton.Click();
        }


    }

    public class AddCasePageMap
    {
        public Element dateBox => Driver.FindElement(By.Id("addCaseBI_CaseDateHijri"), "File Date");
        public Element CaseType => Driver.FindElement(By.Name("addCaseBI.CaseType"), "Case Type");
        public Element number => Driver.FindElement(By.Id("addCaseBI_CaseRegisterationNumber"), "number");
        public Element casenumber => Driver.FindElement(By.Name("addCaseBI.CaseNo"), "case number");
        public Element CaseRequestId => Driver.FindElement(By.Name("addCaseBI.CaseRequestId"), "Case Request Id");
        public Element LawyerID => Driver.FindElement(By.Name("LawyerID"), "Lawyer ID");
        public Element CaseSubject => Driver.FindElement(By.Id("addCaseBI_CaseSubject"), "Lawyer ID");
        public Element addCaseBI_CourtMasterTypeId => Driver.FindElement(By.Id("addCaseBI_CourtMasterTypeId"), "add Case BI_CourtMaster Type Id");
        public Element CourtTypeID => Driver.FindElement(By.Id("CourtTypeID"), "CourtTypeID");
        public Element CourtId => Driver.FindElement(By.Id("CourtId"), "Court Id");
        public Element Prosecutors => Driver.FindElement(By.Id("addCaseBI_Prosecutors"), "Prosecutors");
        public Element Defendants => Driver.FindElement(By.Id("addCaseBI_Defendants"), "Defendants");
        public Element officenumber => Driver.FindElement(By.Id("addCaseBI_CircuitDescription"), "office number");
        public Element SaveCaseButton => Driver.FindElement(By.Id("submit"), "save");

    }
}
