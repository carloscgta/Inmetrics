using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automação_Mobile
{
    public class Home_Page : Base
    {
        string androidstatus_voo = "//android.widget.TextView[@text='Status de voo']";

        string iOSstatus_voo = "//android.widget.TextView[@text='Status de voo']";

        public void acessarStatusVoo()
        {
            clicar(By.XPath(androidstatus_voo));
        }

        
    }

}
