using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{

    [TestFixture]
    public class AccountCreationTests : TestBase
    {
      

        [Test]
        public void AccountCreationTest()
        {
            
            ContactData group = new ContactData("Firstname");
            group.Middlename = "Middlename";
            group.Lastname = "Lastname";
            app.Contact
                .AddnewAccount(group)
                .CreateAccount();
            
        }

    }
}
