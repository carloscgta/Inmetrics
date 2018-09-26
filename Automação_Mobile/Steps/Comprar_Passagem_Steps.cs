using Automação_Mobile.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Automação_Mobile.Steps
{
    [Binding]
    public class Comprar_Passagem_Steps
    {
        Login logar = new Login();

        [Given(@"que esteja logado no app ""(.*)"" ""(.*)""")]
        public void DadoQueEstejaLogadoNoApp(string usuario, string senha)
        {
            //Thread.Sleep(60);
            logar.selecionar_botao_login();
            logar.preencher_usuario(usuario);
            logar.clicar_continuar();
            logar.preencher_senha(senha);
        }
        
        [When(@"compra uma passagem com tarifa ""(.*)""")]
        public void QuandoCompraUmaPassagemComTarifa(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"visualizo que o valor da bagagem despachada é ""(.*)""")]
        public void EntaoVisualizoQueOValorDaBagagemDespachadaE(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
