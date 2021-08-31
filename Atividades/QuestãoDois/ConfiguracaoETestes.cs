using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class RetornaTempoMinimoEmMinutosTest
{
  [Test]
  public void DeveCalcularComDuasMilSetecentosEQuarentaENovePessoasEOitoPortoesACinquentaSegundosPorPessoa()
  {
    Assert.AreEqual(287, Challenge.RetornaTempoMinimoEmMinutos(2749,50,8));
  }
}