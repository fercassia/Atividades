using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class RetornaPessoasPreferemUmUnicoPalcoTest
{
  [Test]
  public void DeveCalcularComDistÃ¢nciaDeQuatrocentosECinquentaMetros()
  {
    Assert.AreEqual(2500, Challenge.RetornaPessoasPreferemUmUnicoPalco(10000));
  }
}