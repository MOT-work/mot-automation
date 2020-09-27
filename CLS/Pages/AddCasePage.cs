using System;
using Framework.Selenium;
using OpenQA.Selenium;

namespace CLS.Pages
{
    public class AddCasePage : PageBase
    {
        public readonly AddCasePageMap Map;

        public AddCasePage Goto()
        {
            CLSMenu.GotoAddCasePage();
            return this;
        }

        public AddCasePage()
        {
            Map = new AddCasePageMap();
        }

        public void SaveCaseWithoutFill()
        {
           Map.SaveCaseButton.Click();   
        }

         public void ClickCard(string name)
        {
          // Map.Nerd(name).Click();
           Map.StageByName(name).Click();
        }

        public void SaveCase1(string dateBox1, string CaseType, string number, string casenumber, string CaseRequestId, string LawyerID, string CaseSubject, string CourtMasterTypeId, string CourtTypeID,
         string CourtId, string Defendants, int officenumber)
        {
 
            Map.dateBox.SendKeys(" ");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.CaseType,"");
            Map.number.SendKeys("");
            Map.casenumber.SendKeys("");
            Map.CaseRequestId.SendKeys("");
            Map.LawyerID.SendKeys("");
            Map.CaseSubject.SendKeys("");
            Map.addCaseBI_CourtMasterTypeId.SendKeys("");
            Map.CourtTypeID.SendKeys("");
            Map.CourtId.SendKeys("");
            //Map.Prosecutors.SendKeys("");
            Map.Defendants.SendKeys("");
            Map.officenumber.SendKeys("");
            Map.save.Click();

            if(Map.CaseType.Text=="")
            {
                ClickCard("");

            }
            else
            {
                Map.casenumber.SendKeys("");
            }
        }

    }

    public class AddCasePageMap
    {
        public Element SaveCaseButton => Driver.FindElement(By.Id("submit"));

        public Element Nerd(string name) => Driver.FindElement(By.CssSelector($"a[href*='{name}']"), $"Nerd: {name}");

        public Element StageByName(string name) => Driver.FindElement(
            by: By.XPath($"//div[@class='stage-option' and text()='{name}']"),
            elementName: $"{name} Stage");


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
