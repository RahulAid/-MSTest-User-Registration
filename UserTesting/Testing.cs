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
            bool result = objTest.ValidateFirstName("Kumar");
            Assert.IsTrue(result);
        }
    }
}