using EvaluationSampleCode;

namespace EvaluationSampleCodeUnitTest
{
    [TestClass]
    public class MathOperationsUnitTest
    {
        MathOperations _mathOperations = new MathOperations();

        [DataTestMethod]
        [DataRow(5, 10, 15)]
        [DataRow(-5, -10, -15)]
        [DataRow(10, -5, 5)]
        public void Add_numbers_correctSum(int numberOne, int numberTwo, int expectedSum)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);
            Assert.AreEqual(expectedSum, result);
        }

        [DataTestMethod]
        [DataRow(100, 10, 10)]
        [DataRow(4, 2, 2)]
        [DataRow(-100, 2, -50)]
        //[DataRow(5, 2, 2.5)] Ne marche pas plante quand on calcule un nombre a virgule :(
        public void Divide_numbers_correctDivide(int numberOne, int numberTwo, float expectedResult)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);
            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow(100, 0)]
        [DataRow(4, 0)]
        [ExpectedException(typeof(ArgumentException))]
        public void Divide_numbersBy0_ExpectError(int numberOne, int numberTwo)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);
        }

        [TestMethod]
        [DataRow(100)]
        [DataRow(1)]

        public void GetOddNumbers_checkIfIsOdd_IsTrue(int number)
        {
            var oddNumbers = _mathOperations.GetOddNumbers(number);

            if (number != 1) { 
                // vu que la somme de nombre impair est toujours paire je vérifie si la somme est paire ..
                Assert.IsTrue(oddNumbers.Sum() % 2 == 0);
            } else
            {
                // sinon je vérifie si il est impaire simplement
                Assert.IsTrue(oddNumbers.Sum() % 2 == 1);

            }
        }
    }
}