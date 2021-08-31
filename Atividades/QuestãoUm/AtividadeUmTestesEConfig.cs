using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class RetornaTempoArenaEmMilisegundosTest
{
  [Test]
  public void DeveCalcularComDistânciaDeQuatrocentosECinquentaMetros()
  {
    Assert.AreEqual(1324, Challenge.RetornaTempoArenaEmMilisegundos("0.45",340));
  }
}