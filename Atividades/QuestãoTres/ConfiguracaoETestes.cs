using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class RetornaPessoasPreferemUmUnicoPalcoTest
{
  [Test]
  public void DeveCalcularComDistânciaDeQuatrocentosECinquentaMetros()
  {
    Assert.AreEqual(2500, Challenge.RetornaPessoasPreferemUmUnicoPalco(10000));
  }
}