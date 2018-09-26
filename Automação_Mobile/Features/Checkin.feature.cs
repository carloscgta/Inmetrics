﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Automação_Mobile.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Checkin", SourceFile="Features\\Checkin.feature", SourceLine=1)]
    public partial class CheckinFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Checkin.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Checkin", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void RealizarReservaComTarifaPromo_Check_InCompraDeUmaBagagem(string login, string senha, string codigoVoo, string sobrenome, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar reserva com tarifa Promo- Check-in compra de uma bagagem", null, @__tags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given(string.Format("que estou logado no check-in \"{0}\" \"{1}\"", login, senha), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 8
 testRunner.When("selecionar o localizador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 9
 testRunner.And(string.Format("preencher os dados \"{0}\" \"{1}\"", codigoVoo, sobrenome), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.Then("realizo o check-in com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Realizar reserva com tarifa Promo- Check-in compra de uma bagagem, carloscgta@gma" +
            "il.com", new string[] {
                "mytag"}, SourceLine=13)]
        public virtual void RealizarReservaComTarifaPromo_Check_InCompraDeUmaBagagem_CarloscgtaGmail_Com()
        {
#line 6
this.RealizarReservaComTarifaPromo_Check_InCompraDeUmaBagagem("carloscgta@gmail.com", "71992040812", "UMW7JN", "TIRONE", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
