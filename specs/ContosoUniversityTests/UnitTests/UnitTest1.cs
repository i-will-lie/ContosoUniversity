using NUnit.Framework;


namespace ContosoUniversity.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_should_pass_with_assert_pass()
        {
            
            Assert.Pass();
        }

        //[Test]
        public void Test_should_fail_with_assert_fail()
        {

            Assert.Fail();
        }

        //[Test]
        public void Test_2()
        {

            Assert.Pass();
        }
    }
}