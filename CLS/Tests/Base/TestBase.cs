using Framework;
using Framework.Selenium;
using CLS.Pages;
using NUnit.Framework;

namespace Tests.Base
{
    public abstract class TestBase
    {
        protected TestBase()
        {
            FW.Init();
            FW.CreateTestResultsDirectory();
        }

        [SetUp]
        public virtual void Setup()
        {
            FW.SetLogger();
            
            Driver.Init(
                type: FW.Config.Driver.Type,
                browser: FW.Config.Driver.Browser,
                setWait: FW.Config.Driver.Wait
            );

            Pages.Init();
        }

        [TearDown]
        public virtual void Cleanup()
        {
            Driver.Quit();
        }
    }
}
