using Automação_Mobile.Pages;
using System;
using TechTalk.SpecFlow;

namespace Automação_Mobile
{
    [Binding]
    public class CheckinSteps
    {
        CheckIn checkin = new CheckIn();
        Login login = new Login();

        [Given(@"que estou logado no check-in ""(.*)"" ""(.*)""")]
        public void DadoQueEstouLogadoNoCheck_In(string login0, string senha1)
        {
            login.selecionar_botao_login();
            login.preencher_usuario(login0);
            login.preencher_senha(senha1);
            login.clicar_continuar();
            checkin.fazerCheckIn();
           
        }
        
        [When(@"selecionar o localizador")]
        public void QuandoSelecionarOLocalizador()
        {
            checkin.selecionarLocalizador();
        }
        
        [When(@"preencher os dados ""(.*)"" ""(.*)""")]
        public void QuandoPreencherOsDados(string codigo0, string sobrenome1)
        {
            checkin.InserirCodigo(codigo0);
            checkin.InserirSobrenome(sobrenome1);



        }
        
        [Then(@"realizo o check-in com sucesso")]
        public void EntaoRealizoOCheck_InComSucesso()
        {
            

        }
    }
}
