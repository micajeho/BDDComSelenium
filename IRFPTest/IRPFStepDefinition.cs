using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace IRFPTest
{
    [Binding]
    public class IRPFStepDefinition
    {
        private IE _browser;

        [Given(@"preencho o campo 'salario' com o valor 100\.00")]
        public void DadoPreenchoOCampoSalarioComOValor100_00()
        {
            _browser.TextField(Find.ByName("Valor")).TypeText("100,00");
        }

        [Given(@"que estou na página IR")]
        public void DadoQueEstouNaPaginaIR()
        {
            _browser = new IE("http://localhost:6968/IR");
        }

        [Then(@"vejo 'O resultado é 0\.00'")]
        public void EntaoVejoOResultadoE0_00()
        {
            Assert.IsTrue(_browser.ContainsText("O resultado é 0"));
        }

        [When(@"clico em Calcular")]
        public void QuandoClicoEmCalcular()
        {
            _browser.Button(Find.ByValue("Calcular")).Click();
        }

        [AfterScenario]
        public void FechaBrowser()
        {
            if (_browser != null)
            {
                _browser.Dispose();
            }

        }

        [Then(@"vejo 'O resultado é 300\.00'")]
        public void EntaoVejoOResultadoE300_00()
        {
            Assert.IsTrue(_browser.ContainsText("O resultado é 300"));
        }

        [Given(@"preencho o campo 'salario' com o valor 5000\.00")]
        public void DadoPreenchoOCampoSalarioComOValor5000_00()
        {
            _browser.TextField(Find.ByName("Valor")).TypeText("5000,00");
        }

        [Given(@"preencho o campo 'dependentes' com o valor 1")]
        public void DadoPreenchoOCampoDependentesComOValor1()
        {
            _browser.TextField(Find.ByName("Dependente")).TypeText("1");
        }

        [Then(@"vejo 'O resultado é 200\.00'")]
        public void EntaoVejoOResultadoE200_00()
        {
            Assert.IsTrue(_browser.ContainsText("O resultado é 200"));
        }

        [Given(@"preencho o campo 'dependentes' com o valor 2")]
        public void DadoPreenchoOCampoDependentesComOValor2()
        {
            _browser.TextField(Find.ByName("Dependente")).TypeText("2");
        }

        [Then(@"vejo 'O resultado é 100\.00'")]
        public void EntaoVejoOResultadoE100_00()
        {
            Assert.IsTrue(_browser.ContainsText("O resultado é 100"));
        }

        [Given(@"preencho o campo 'salario' com o valor 6000\.00")]
        public void DadoPreenchoOCampoSalarioComOValor6000_00()
        {
            _browser.TextField(Find.ByName("Valor")).TypeText("6000,00");
        }

        [Then(@"vejo 'O resultado é 150\.00'")]
        public void EntaoVejoOResultadoE150_00()
        {
            Assert.IsTrue(_browser.ContainsText("O resultado é 150"));
        }
    }
}