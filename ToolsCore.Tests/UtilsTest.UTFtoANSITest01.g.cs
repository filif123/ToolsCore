using System;
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
public void UTFtoANSITest01616()
{
    string s;
    s = this.UTFtoANSITest01("\0\0");
}

[TestMethod]
[PexGeneratedBy(typeof(UtilsTest))]
public void UTFtoANSITest01831()
{
    string s;
    s = this.UTFtoANSITest01("�");
}

[TestMethod]
[PexGeneratedBy(typeof(UtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void UTFtoANSITest01ThrowsArgumentNullException745()
{
    string s;
    s = this.UTFtoANSITest01((string)null);
}
    }
}
