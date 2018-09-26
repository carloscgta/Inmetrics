using OpenQA.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Drawing.Imaging;
using System.Threading;
using TechTalk.SpecFlow;

namespace Automação_Mobile.NewFolder1
{
    [Binding]
    public class HooksMobile
    {

    
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        //public static AndroidDriver<AndroidElement> driver { get; private set; }
        public static AndroidDriver<AndroidElement> driver { get; private set;}

        //public static IOSDriver<IOSElement> driver { get; private set; }

        public string screenshotsPasta;
        int contador = 1;


        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario

            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "Nexus");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("automationName", "uiautomator2");
            capabilities.SetCapability("app", "");
            capabilities.SetCapability("appPackage", "co.work.golapp");
            capabilities.SetCapability("appActivity", "co.work.golapp.MainActivity");
            capabilities.SetCapability("newCommandTimeout", 20000);
            capabilities.SetCapability("autoGrantPermissions", true);
            capabilities.SetCapability("autoAcceptAlerts", true);
            //capabilities.SetCapability("testdroid_testTimeout", 1200);
            //Conectando com o Appium
             driver = new AndroidDriver<AndroidElement>(new Uri("http://192.168.48.178:4723/wd/hub"), capabilities);
            
           /* DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "iPhone 6");
            capabilities.SetCapability("platformName", "iOS");
            capabilities.SetCapability("platformVersion", "12.0");
            capabilities.SetCapability("automationName", "Simulator");
            capabilities.SetCapability("app", "/Users/inmetrics/Library/Developer/Xcode/DerivedData/golapp-gyxstjvumbjwqbgajunylaarcrpp/Build/Products/Release-iphonesimulator/golapp.app");
            //capabilities.SetCapability("UDID", "c2b18f96e808989e96d880cc23cabfcc0d3d7303");
            //capabilities.SetCapability("appPackage", "com.entria.gol.app");
            //capabilities.SetCapability("appActivity", "com.entria.gol.app.MainActivity");
            capabilities.SetCapability("newCommandTimeout", 20000);
            capabilities.SetCapability("autoGrantPermissions", true);
            capabilities.SetCapability("autoAcceptAlerts", true);
            driver = new IOSDriver<IOSElement>(new Uri("http://192.168.48.178:4723/wd/hub"), capabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            capabilities.SetCapability("newCommandTimeout", 60000);
            screenshotsPasta = @"C:\Users\Inmetrics\Documents\GOL\Automação_Mobile\Automação_Mobile\Screenshots";*/

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
        
        public void Screenshot(IWebDriver driver, string screenshotsPasta)
        {
            ITakesScreenshot camera = driver as ITakesScreenshot;
            Screenshot foto = camera.GetScreenshot();
            foto.SaveAsFile(screenshotsPasta, ImageFormat.Png);
        }

        [AfterStep]
        public void capturaImagem()
        {
            Screenshot(driver, screenshotsPasta + "Imagem_" + contador++ + ".png");
            Thread.Sleep(500);
        }


    }
}
