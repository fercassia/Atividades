using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class GeraFrequenciaNotaTest
{
  [Test]
  public void DeveCalcularComFrequenciaParaUmSemitonAcimaDeA()
  {
    Assert.AreEqual(new string[] {"466.1638","A#"}, Challenge.GeraFrequenciaNota(1));
  }
  [Test]
  public void DeveCalcularComFrequenciaPara2SemitonsAcimaDeA()
  {
    Assert.AreEqual(new string[] {"493.8833","B"}, Challenge.GeraFrequenciaNota(2));
  }
  [Test]
  public void DeveCalcularComFrequenciaParaDoisSemitonsAbaixoDeA()
  {
    Assert.AreEqual(new string[] {"391.9954","G"}, Challenge.GeraFrequenciaNota(-2));
  }
}