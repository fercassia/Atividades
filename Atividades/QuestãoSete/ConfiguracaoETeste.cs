using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class TamanhoSetorBuscaTest
{
  [Test]
  public void DeveCalcularComDistânciaDeQuatrocentosECinquentaMetros()
  {
    Assert.AreEqual("315", Challenge.TamanhoSetorBusca(2834,314));
  }
}