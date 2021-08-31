using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class RetornaGuicheIngressoTest
{
  [Test]
  public void IngressoNumeroVinteESeis()
  {
    Assert.AreEqual(6, Challenge.RetornaGuicheIngresso(26));
  }
}