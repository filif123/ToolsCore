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
public void ANSItoUTFTest01661()
{
    string s;
    s = this.ANSItoUTFTest01("");
}

[TestMethod]
[PexGeneratedBy(typeof(UtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ANSItoUTFTest01ThrowsArgumentNullException419()
{
    string s;
    s = this.ANSItoUTFTest01((string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(UtilsTest))]
public void ANSItoUTFTest01184()
{
    string s;
    s = this.ANSItoUTFTest01("\0");
}
    }
}
