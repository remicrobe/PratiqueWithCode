using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCodeUnitTest
{
    [TestClass]
    public class CustomStackUnitTest
    {
      
        [TestMethod]
        public void Pop_WhenStackIsEmpty_ThrowException()
        {
            CustomStack _customStack = new CustomStack();
            Assert.ThrowsException<CustomStack.StackCantBeEmptyException>(() => _customStack.Pop());
        }

        [TestMethod]
        public void Pop_WhenStackIsNotEmpty_ReturnLengthMinus1()
        {
            CustomStack _customStack = new CustomStack();
            _customStack.Push(1);
            _customStack.Push(2);
            _customStack.Pop();
            Assert.AreEqual(1, _customStack.Count());
        }

        [TestMethod]
        public void Push_WithBasicNumberAndTestIfItsCorrectlyPushed_ReturnTrue()
        {
            CustomStack _customStack = new CustomStack();
            _customStack.Push(1);
            Assert.AreEqual(1, _customStack.Count());
        }


    }
}
