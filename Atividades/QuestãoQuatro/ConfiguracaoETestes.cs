using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class RetornaSeHaEcoNoEstudioTest
{
  [Test]
  public void DeveCalcularComDistÃ¢nciaDeOitoMetros()
  {
    Assert.AreEqual(false, Challenge.RetornaSeHaEcoNoEstudio(8));
  }
  [Test]
  public void DeveCalcularComDistÃ¢nciaDeVinteMetros()
  {
    Assert.AreEqual(true, Challenge.RetornaSeHaEcoNoEstudio(20));
  }
}