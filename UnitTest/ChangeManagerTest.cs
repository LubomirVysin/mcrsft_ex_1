using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft_excercise_1;

namespace UnitTest
{
    [TestClass]
    public class ChangeManagerTest
    {
        private ChangeManager _changeManager;

        [TestInitialize]
        public void ChangeManager_SetUp()
        {
            _changeManager = new ChangeManager();
        }

        [TestMethod]
        public void ChangeManager_MakeChange__Input_135__ExpectedResult_4()
        {
            Assert.IsTrue(_changeManager.MakeChange(135).Equals(4));
        }

        [TestMethod]
        public void ChangeManager_MakeChange__Input_100__ExpectedResult_1()
        {
            Assert.IsTrue(_changeManager.MakeChange(100).Equals(1));
        }

        [TestMethod]
        public void ChangeManager_MakeChange__ExpectFail()
        {
            Assert.IsTrue(_changeManager.MakeChange(0).Equals(1));
        }
    }
}
