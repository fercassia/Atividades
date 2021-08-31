using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class RetornaSeHaEcoNoEstudioTest
{
  [Test]
  public void DeveCalcularComDistânciaDeOitoMetros()
  {
    Assert.AreEqual(false, Challenge.RetornaSeHaEcoNoEstudio(8));
  }
  [Test]
  public void DeveCalcularComDistânciaDeVinteMetros()
  {
    Assert.AreEqual(true, Challenge.RetornaSeHaEcoNoEstudio(20));
  }
}