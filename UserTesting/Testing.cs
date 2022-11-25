using System.Text.RegularExpressions;

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

        [TestMethod]
        public void TestMobileNumber()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();
            bool result = objTest.ValidateMobileNumber("+91 2134657809");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestPasswordRule1()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("Rahulllll");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestPasswordRule2()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("RahulLLll");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestPasswordRule3()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("RahulL11Lll");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestPasswordRule4()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("RahulL11Lll#");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSampleEmail1()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("abc@yahoo.com");
            Assert.IsTrue(result);
        }
    }
}