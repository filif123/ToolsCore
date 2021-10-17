using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using ToolsCore.Tools;

namespace ToolsCoreTests.Tools
{
    [TestClass]
    public class AppRegistryTests
    {
        private const string REG_PATH = "SOFTWARE\\AppRegistryTests";
        private const string APP_NAME = "AppRegistryTests";

        [TestMethod]
        public void GetRecentDirs_KeyNotCreated()
        {
            var key = Registry.CurrentUser.OpenSubKey(REG_PATH);
            if (key is not null)
            {
                Registry.CurrentUser.DeleteSubKey(REG_PATH);
            }

            var actual = AppRegistry.GetRecentDirs(APP_NAME);

            Assert.IsNotNull(actual);
            Assert.AreEqual(0, actual.Count);
        }
    }
}
