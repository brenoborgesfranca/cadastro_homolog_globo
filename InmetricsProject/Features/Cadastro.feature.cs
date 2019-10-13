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
namespace InmetricsProject.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Cadastro")]
    public partial class CadastroFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Cadastro.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-br"), "Cadastro", "\tComo usuário\r\n\tDesejo me cadastrar na aplicação\r\n\tAssim posso usufruir das funci" +
                    "onalidades do mesmo", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1)  Quando o usuário acessar a página de cadastro, o formulário deverá ser exibid" +
            "o")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void _1QuandoOUsuarioAcessarAPaginaDeCadastroOFormularioDeveraSerExibido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1)  Quando o usuário acessar a página de cadastro, o formulário deverá ser exibid" +
                    "o", null, new string[] {
                        "mytag"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
 testRunner.Given("um visitante não cadastrado que acessou a tela inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 12
 testRunner.When("Clicar no botão Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 13
 testRunner.Then("deverá ser redirecionado para pagina de cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2) Campos Obrigatórios disponibilizados no formulário de cadastro")]
        public virtual void _2CamposObrigatoriosDisponibilizadosNoFormularioDeCadastro()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2) Campos Obrigatórios disponibilizados no formulário de cadastro", null, ((string[])(null)));
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 16
 testRunner.Given("um visitante não cadastrado que acessou a tela inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 17
 testRunner.When("Clicar no botão Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 18
 testRunner.Then("deverá ser demonstrado os campos obrigatórios do formulário", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3) Realizar Cadastro")]
        public virtual void _3RealizarCadastro()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3) Realizar Cadastro", null, ((string[])(null)));
#line 21
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
 testRunner.Given("um visitante não cadastrado que acessou a tela inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 24
 testRunner.When("Clicar no botão Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Sobrenome",
                        "Como gostaria de ser chamado?",
                        "Email",
                        "Veículo",
                        "País",
                        "Cidade",
                        "DDD",
                        "Telefone",
                        "DDD",
                        "Celular",
                        "Twitter",
                        "Instagram",
                        "Senha",
                        "Confirmação de Senha"});
            table1.AddRow(new string[] {
                        "Breno",
                        "Borges",
                        "Breno",
                        "mailtestemail@email.com",
                        "Fiesta",
                        "Brasil",
                        "Anápolis",
                        "62",
                        "99259414",
                        "62",
                        "992153445",
                        "bfranca",
                        "brenoborgesfranca",
                        "@XDFXDFCDFdds#",
                        "@XDFXDFCDFdds#"});
#line 25
 testRunner.And("preencher todos os campos do formulário de cadastro corretamente", ((string)(null)), table1, "E ");
#line 28
 testRunner.And("clicar no botão SOLICITAR CADASTRO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 29
 testRunner.Then("a mensaggem de cadastro com sucesso deverá ser exibida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4) Email já cadastrado")]
        public virtual void _4EmailJaCadastrado()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4) Email já cadastrado", null, ((string[])(null)));
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 33
 testRunner.Given("um visitante não cadastrado que acessou a tela inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 34
 testRunner.When("Clicar no botão Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Sobrenome",
                        "Como gostaria de ser chamado?",
                        "Email",
                        "Veículo",
                        "País",
                        "Cidade",
                        "DDD",
                        "Telefone",
                        "DDD",
                        "Celular",
                        "Twitter",
                        "Instagram",
                        "Senha",
                        "Confirmação de Senha"});
            table2.AddRow(new string[] {
                        "Breno",
                        "Borges",
                        "Breno",
                        "xdd@email.com",
                        "Fiesta",
                        "Brasil",
                        "Anápolis",
                        "62",
                        "99259414",
                        "62",
                        "992153445",
                        "bfranca",
                        "brenoborgesfranca",
                        "@XDFXDFCDFdds#",
                        "@XDFXDFCDFdds#"});
#line 35
 testRunner.And("preencher todos os campos do formulário de cadastro corretamente", ((string)(null)), table2, "E ");
#line 38
 testRunner.And("clicar no botão SOLICITAR CADASTRO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 39
 testRunner.Then("o sistema ira retornar mensagem de erro pois o e-mail ja existe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("5)  Verificar exceções referentes a uma Senha Franca")]
        public virtual void _5VerificarExcecoesReferentesAUmaSenhaFranca()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5)  Verificar exceções referentes a uma Senha Franca", null, ((string[])(null)));
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 43
    testRunner.Given("um visitante não cadastrado que acessou a tela inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 44
 testRunner.When("Clicar no botão Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Sobrenome",
                        "Como gostaria de ser chamado?",
                        "Email",
                        "Veículo",
                        "País",
                        "Cidade",
                        "DDD",
                        "Telefone",
                        "DDD",
                        "Celular",
                        "Twitter",
                        "Instagram",
                        "Senha",
                        "Confirmação de Senha"});
            table3.AddRow(new string[] {
                        "Breno",
                        "Borges",
                        "Breno",
                        "juniorr@email.com",
                        "Fiesta",
                        "Brasil",
                        "Anápolis",
                        "62",
                        "99259414",
                        "62",
                        "992153445",
                        "bfranca",
                        "brenoborgesfranca",
                        "12345678",
                        "12345678"});
#line 45
 testRunner.And("preencher todos os campos do formulário de cadastro corretamente", ((string)(null)), table3, "E ");
#line 48
 testRunner.And("clicar no botão SOLICITAR CADASTRO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 49
 testRunner.Then("o sistema irá retornar as mensagens de erros informando que a senha é fraca", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("6) Verificar se o usuário deseja receber releases e informações relativas à TV Gl" +
            "obo")]
        public virtual void _6VerificarSeOUsuarioDesejaReceberReleasesEInformacoesRelativasATVGlobo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("6) Verificar se o usuário deseja receber releases e informações relativas à TV Gl" +
                    "obo", null, ((string[])(null)));
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 53
 testRunner.Given("um visitante não cadastrado que acessou a tela inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 54
 testRunner.When("Clicar no botão Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 55
 testRunner.Then("o sistema deverá Verificar se o usuário deseja receber releases e informações rel" +
                    "ativas à TV Globo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("7)  Senha sem caracter especial")]
        public virtual void _7SenhaSemCaracterEspecial()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("7)  Senha sem caracter especial", null, ((string[])(null)));
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 58
    testRunner.Given("um visitante não cadastrado que acessou a tela inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 59
 testRunner.When("Clicar no botão Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Sobrenome",
                        "Como gostaria de ser chamado?",
                        "Email",
                        "Veículo",
                        "País",
                        "Cidade",
                        "DDD",
                        "Telefone",
                        "DDD",
                        "Celular",
                        "Twitter",
                        "Instagram",
                        "Senha",
                        "Confirmação de Senha"});
            table4.AddRow(new string[] {
                        "Breno",
                        "Borges",
                        "Breno",
                        "juniorr@email.com",
                        "Fiesta",
                        "Brasil",
                        "Anápolis",
                        "62",
                        "99259414",
                        "62",
                        "992153445",
                        "bfranca",
                        "brenoborgesfranca",
                        "SENHAa12322",
                        "SENHAa12322"});
#line 60
 testRunner.And("preencher todos os campos do formulário de cadastro corretamente", ((string)(null)), table4, "E ");
#line 63
 testRunner.And("clicar no botão SOLICITAR CADASTRO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 64
 testRunner.Then("o sistema irá informar que a senha precisa de um caracter especial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("8)  Senhas diferentes")]
        public virtual void _8SenhasDiferentes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("8)  Senhas diferentes", null, ((string[])(null)));
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 67
    testRunner.Given("um visitante não cadastrado que acessou a tela inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 68
 testRunner.When("Clicar no botão Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Sobrenome",
                        "Como gostaria de ser chamado?",
                        "Email",
                        "Veículo",
                        "País",
                        "Cidade",
                        "DDD",
                        "Telefone",
                        "DDD",
                        "Celular",
                        "Twitter",
                        "Instagram",
                        "Senha",
                        "Confirmação de Senha"});
            table5.AddRow(new string[] {
                        "Breno",
                        "Borges",
                        "Breno",
                        "juniorr@email.com",
                        "Fiesta",
                        "Brasil",
                        "Anápolis",
                        "62",
                        "99259414",
                        "62",
                        "992153445",
                        "bfranca",
                        "brenoborgesfranca",
                        "@SENHAa14322",
                        "@SENHAa1442322"});
#line 69
 testRunner.And("preencher todos os campos do formulário de cadastro corretamente", ((string)(null)), table5, "E ");
#line 72
 testRunner.And("clicar no botão SOLICITAR CADASTRO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 73
 testRunner.Then("o sistema irá informar que as senhas estão diferentes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("9)  Senhas com pelo menos uma letra minúscula")]
        public virtual void _9SenhasComPeloMenosUmaLetraMinuscula()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("9)  Senhas com pelo menos uma letra minúscula", null, ((string[])(null)));
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 76
    testRunner.Given("um visitante não cadastrado que acessou a tela inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 77
 testRunner.When("Clicar no botão Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Sobrenome",
                        "Como gostaria de ser chamado?",
                        "Email",
                        "Veículo",
                        "País",
                        "Cidade",
                        "DDD",
                        "Telefone",
                        "DDD",
                        "Celular",
                        "Twitter",
                        "Instagram",
                        "Senha",
                        "Confirmação de Senha"});
            table6.AddRow(new string[] {
                        "Breno",
                        "Borges",
                        "Breno",
                        "juniorr@email.com",
                        "Fiesta",
                        "Brasil",
                        "Anápolis",
                        "62",
                        "99259414",
                        "62",
                        "992153445",
                        "bfranca",
                        "brenoborgesfranca",
                        "JOAOJOAO@JOAO",
                        "JOAOJOAO@JOAO"});
#line 78
 testRunner.And("preencher todos os campos do formulário de cadastro corretamente", ((string)(null)), table6, "E ");
#line 81
 testRunner.And("clicar no botão SOLICITAR CADASTRO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 82
 testRunner.Then("o sistema irá informar que é necessário pelo menos uma letra minuscula", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("9.1)  Senhas com pelo menos uma letra maiúscula")]
        public virtual void _9_1SenhasComPeloMenosUmaLetraMaiuscula()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("9.1)  Senhas com pelo menos uma letra maiúscula", null, ((string[])(null)));
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 85
    testRunner.Given("um visitante não cadastrado que acessou a tela inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 86
 testRunner.When("Clicar no botão Novo Cadastro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Sobrenome",
                        "Como gostaria de ser chamado?",
                        "Email",
                        "Veículo",
                        "País",
                        "Cidade",
                        "DDD",
                        "Telefone",
                        "DDD",
                        "Celular",
                        "Twitter",
                        "Instagram",
                        "Senha",
                        "Confirmação de Senha"});
            table7.AddRow(new string[] {
                        "Breno",
                        "Borges",
                        "Breno",
                        "juniorr@email.com",
                        "Fiesta",
                        "Brasil",
                        "Anápolis",
                        "62",
                        "99259414",
                        "62",
                        "992153445",
                        "bfranca",
                        "brenoborgesfranca",
                        "joao@joao@joao",
                        "joao@joao@joao"});
#line 87
 testRunner.And("preencher todos os campos do formulário de cadastro corretamente", ((string)(null)), table7, "E ");
#line 90
 testRunner.And("clicar no botão SOLICITAR CADASTRO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 91
 testRunner.Then("o sistema irá informar que é necessário pelo menos uma letra maiscula", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

