using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using IRPF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IRFPTest
{
    [TestClass]
    public class IrpfTest
    {
        [TestMethod]
        public void CalcularIrpfValo100()
        {
            var irpf = new Irpf { Valor = 100.00 };
            irpf.CalcularValorIrpf();
            Assert.AreEqual(0, irpf.Imposto);
        }

        [TestMethod]
        public void CalcularIrpfValo5000()
        {
            var irpf = new Irpf { Valor = 5000.00 };
            irpf.CalcularValorIrpf();
            Assert.AreEqual(300, irpf.Imposto);
        }
    }
}
