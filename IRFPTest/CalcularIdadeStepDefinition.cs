using System;
using IRPF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace IRFPTest
{
    [Binding]
    public class CalcularIdadeStepDefinition
    {
        private IE _browser;
        private CalcularIdade _calcularIdade;

        [Given(@"a data atual é '15/04/2000'")]
        public void DadoADataAtualE15042000()
        {
            var dataAtual = new DateTime(2000, 04, 15);

            _calcularIdade = new CalcularIdade { DataBase = dataAtual };
        }

        [Given(@"preencho o campo data de nascimento como valor '25/04/1981'")]
        public void DadoPreenchoOCampoDataDeNascimentoComoValor25041981()
        {
            _browser.TextField(Find.ByName("DataNascimento")).TypeText("25/04/1981");
            _calcularIdade = new CalcularIdade { DataNascimento = new DateTime(1981, 04, 25) };
        }

        [Given(@"que estou na página de calcular Idade")]
        public void DadoQueEstouNaPaginaDeCalcularIdade()
        {
            _browser = new IE("http://localhost:6968/Idade");
        }

        [Then(@"a idade do usuário será exibida")]
        public void EntaoAIdadeDoUsuarioSeraExibida()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a mensagem 'Usuario maior de idade'")]
        public void EntaoAMensagemUsuarioMaiorDeIdade()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"eu clicar no botão 'Calcular'")]
        public void QuandoEuClicarNoBotaoCalcular()
        {
            _browser.Button(Find.ByValue("Calcular")).Click();
            _calcularIdade.calcularIdade();
        }

        [Given(@"a data atual é '15/04/1999'")]
        public void DadoADataAtualE15041999()
        {
            var dataAtual = new DateTime(1999, 04, 15);

            _calcularIdade.DataBase = dataAtual;
        }

        [AfterScenario]
        public void FechaBrowser()
        {
            if (_browser != null)
            {
                _browser.Dispose();
            }

        }

        [Then(@"a mensagem 'Usuario menor de idade'")]
        public void EntaoAMensagemUsuarioMenorDeIdade()
        {
            Assert.IsTrue(_browser.TextField(Find.ByName("Mensagem")).Equals("Usuario menor de idade"));
        }
    }
}
