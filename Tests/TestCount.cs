using BankAccount.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TestCount
    {
        [TestMethod]
        public void TestAccountId()
        {
            var _ = new Account("foo", "euro");
            _ = new Account("foo", "euro");
            _ = new Account("foo", "euro");
            
            var account = new SavingAccount(0, "foo", "euro");
            Assert.AreEqual(4, account.GetAccountId());
        }
        
        [TestMethod]
        public void TestAccountCount()
        {
            var currentCount = Account.GetAccountCount();
            var _ = new Account("foo", "euro");
            Assert.AreEqual(currentCount + 1, Account.GetAccountCount());
        }
    }
}