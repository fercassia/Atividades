using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class CalculaDistanciaBandaPercorreTest
{
  [Test]
  public void ComUmaRodadaDeEnsaiosEUmShow()
  {
    Assert.AreEqual(45500, Challenge.CalculaDistanciaBandaPercorre(1,1));
  }
}