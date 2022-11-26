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

        [TestMethod]
        public void TestSampleEmail2()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("abc-100@yahoo.com");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSampleEmail3()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("abc.100@yahoo.com");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSampleEmail4()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("abc111@abc.com");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSampleEmail5()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("abc-100@abc.net");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSampleEmail6()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("abc.100@abc.com.au");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSampleEmail7()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("abc@1.com");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSampleEmail8()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("abc@gmail.com.com");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSampleEmail9()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            bool result = objTest.ValidatePassword("abc+100@gmail.com");
            Assert.IsTrue(result);
        }
    }
}