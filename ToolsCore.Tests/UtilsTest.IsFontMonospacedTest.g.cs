using System;
using System.Drawing;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <auto-generated>
// Tento soubor obsahuje automaticky vygenerované testy.
// Neupravujte ho ručně.
// 
// Pokud obsah tohoto souboru zastará, můžete ho odstranit.
// Třeba pokud se už nekompiluje.
// </auto-generated>

namespace ToolsCore.Tests
{
    public partial class UtilsTest
    {

[TestMethod]
[PexGeneratedBy(typeof(UtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void IsFontMonospacedTestThrowsArgumentNullException339()
{
    bool b;
    b = this.IsFontMonospacedTest((Graphics)null, (Font)null);
}

[TestMethod]
[PexGeneratedBy(typeof(UtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void IsFontMonospacedTestThrowsArgumentNullException631()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      IDisposable iDisposable;
      bool b;
      iDisposable = GraphicsFactory.Create();
      disposables.Add(iDisposable);
      b = this.IsFontMonospacedTest((Graphics)iDisposable, (Font)null);
      disposables.Dispose();
    }
}
    }
}
