namespace UserTesting
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void TestFirstName()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();
            bool result = objTest.ValidateFirstName("Rahul");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestLastName()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();
            bool result = objTest.ValidateLastName("Kumar");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEmail()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();
            bool result = objTest.ValidateEmail("abc.xyz@bl.co.in");
            Assert.IsTrue(result);
        }
    }
}