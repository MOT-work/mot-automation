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
           //assertion   
        }

         public void CloseCase()
        {
            Map.CloseCaseButton.Click(); 
            // Driver.Wait.Until(
            // WaitConditions.ElementIsDisplayed(Map.ConfirmCloseButton)).Click();
                
        }
        
         public void SaveCaseAsDraft(string CaseType, string casenumber, string CaseRequestId, string CaseSubject)
        {
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.CaseType,"");
            Map.casenumber.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.CaseRequestId,"");
             Map.CaseSubject.SendKeys("");
              if(Map.CaseType.Text=="قضية مرفوعة ضد الوزارة")
            {
                Map.Prosecutors.SendKeys("");

            }
            else
            {
                Map.Defendants.SendKeys("");
            }
           Map.DraftButton.Click();   
        }

        /* public void ClickCard(string name)
        {
          // Map.Nerd(name).Click();
           Map.StageByName(name).Click();
        }*/

        public void SaveCaseWithFillFields(string dateBox1, string CaseType, string number, string casenumber, string CaseRequestId, string LawyerID, string CaseSubject, string CourtMasterTypeId, string CourtTypeID,
         string CourtId, int officenumber)
        {
            Map.dateBox.SendKeys(" ");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.CaseType,"");
            Map.number.SendKeys("");
            Map.casenumber.SendKeys("");
            //Map.CaseRequestId.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.CaseRequestId,"");
           // Map.LawyerID.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.LawyerID,"");
            Map.CaseSubject.SendKeys("");
            //Map.addCaseBI_CourtMasterTypeId.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.addCaseBI_CourtMasterTypeId,"");
            //Map.CourtTypeID.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.CourtTypeID,"");
            //Map.CourtId.SendKeys("");
            Driver.SelectDropdownOption(DropdownBy.VALUE,Map.CourtId,"");
            Map.officenumber.SendKeys("");

            if(Map.CaseType.Text =="قضية مرفوعة ضد الوزارة")
            {
                Map.Prosecutors.SendKeys("");

            }
            else
            {
                Map.Defendants.SendKeys("");
            }

            Map.SaveCaseButton.Click();
        }

    }

    public class AddCasePageMap
    {
        //public Element SaveCaseButton => Driver.FindElement(By.Id("submit"));

        //public Element Nerd(string name) => Driver.FindElement(By.CssSelector($"a[href*='{name}']"), $"Nerd: {name}");

        /*public Element StageByName(string name) => Driver.FindElement(
            by: By.XPath($"//div[@class='stage-option' and text()='{name}']"),
            elementName: $"{name} Stage");*/

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
        public Element DraftButton => Driver.FindElement(By.Id("btn.btn-mot.draftbtn"), "draft");
        public Element IgnoreCaseButton => Driver.FindElement(By.Id("btn.btn-mot.ignorebtn"), "Ignore Case Button");
        public Element CloseCaseButton => Driver.FindElement(By.ClassName("btn.btn-mot.closebtn"), "Close Case Button");
        public Element popupwindow => Driver.FindElement(By.Id("btn.btn-mot.closebtn"), "popup window");
        public Element ConfirmCloseButton => Driver.FindElement(By.ClassName("confirm.btn.btn-lg.btn-danger"), "Confirm Close Button");
        
        public Element CheckMandatoryField => Driver.FindElement(By.ClassName("field-validation-error.text-danger"), "Check Mandatory Field");
        
    }
}
