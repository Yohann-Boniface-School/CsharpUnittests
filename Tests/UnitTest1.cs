using BankAccount.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBalanceCreation0()
        {
            SavingAccount account = new SavingAccount(0, "foo", "euro");
            Assert.AreEqual(0, account.getBalance());
        }
    }
}