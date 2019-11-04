using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(9,"Fizz")]
        [TestCase(18,"Fizz")]
        public void NumberDevideBy3Fizz(int number,string result)
        {
            if (number % 3 == 0)
            {
                result = "Fizz";
            }
            Assert.AreSame("Fizz", result);
        }
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        public void NumberDevideBy5Buzz(int number, string result)
        {
            if (number % 5 == 0)
            {
                result = "Buzz";
            }
            Assert.AreSame("Buzz", result);
        }
        [TestCase(30, "FizzBuzz")]
        [TestCase(15, "FizzBuzz")]
        public void NumberDevideBy5And3FizzBuzz(int number, string result)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                result = "FizzBuzz";
            }
            Assert.AreEqual("FizzBuzz", result);
        }
        [TestCase(7)]
        [TestCase(11)]
        public void NumberNotDevideByNumber(int number)
        {
            if (number % 3 != 0 || number % 5 != 0)
            {
                string result = number.ToString();
            }
            Assert.AreEqual(result, number.ToString());
        }
        [TestCase(7)]
        [TestCase(11)]
        public void NumberUnder0(int number)
        {
            if (number<0)
            {
                
            }
            Assert.That(() => metoda, Throws.ArgumentException);
        }
    }
}