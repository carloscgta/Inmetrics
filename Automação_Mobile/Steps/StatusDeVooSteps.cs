using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Automação_Mobile.Steps
{
    [Binding]
    public class StatusDeVooSteps
    {
       

        Home_Page home = new Home_Page();

        [Given(@"que estou na home do aplicativo")]
        public void DadoQueEstouNaHomeDoAplicativo()
        {
           
        }




        [When(@"eu clicar no link Status de Voo")]
        public void QuandoEuClicarNoLinkStatusDeVoo()
        {
            home.acessarStatusVoo();
        }




        [When(@"inserir as datas desejadas")]
        public void QuandoInserirAsDatasDesejadas()
        {
            ScenarioContext.Current.Pending();
        }





        [Then(@"é exibido o status do voo")]
        public void EntaoEExibidoOStatusDoVoo()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
