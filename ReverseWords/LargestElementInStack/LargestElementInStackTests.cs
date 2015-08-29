namespace LargestElementInStack
{
    using NUnit.Framework;

    [TestFixture]
    public class LargestElementInStackTests
    {
        [Test]
        public void WhenPushedTwoValuesLatestIsReturnedByPop()
        {
            LargestElementInStack stack = new LargestElementInStack();
            int firstValue = 10;
            int secondValue = 15;

            stack.Push(firstValue);
            stack.Push(secondValue);

            int returnedValue = stack.Pop();

            Assert.AreEqual(secondValue, returnedValue);
        }

        [Test]
        public void PoppedValueIsRemovedFromStack()
        {
            LargestElementInStack stack = new LargestElementInStack();
            int firstValue = 10;
            int secondValue = 15;

            stack.Push(firstValue);
            stack.Push(secondValue);

            stack.Pop();
            int returnedValue = stack.Pop();

            Assert.AreEqual(firstValue, returnedValue);
        }

        [Test]
        public void PeekDoesNotRemoveValueFromStack()
        {
            LargestElementInStack stack = new LargestElementInStack();
            int firstValue = 10;
            int secondValue = 15;

            stack.Push(firstValue);
            stack.Push(secondValue);

            stack.Peek();
            int returnedValue = stack.Pop();

            Assert.AreEqual(secondValue, returnedValue);
        }

        [Test]
        public void GetMaxReturnsMaxValue()
        {
            LargestElementInStack stack = new LargestElementInStack();
            int firstValue = 10;
            int secondValue = 25;
            int thirdValue = 15;

            stack.Push(firstValue);
            stack.Push(secondValue);
            stack.Push(thirdValue);

            
            int returnedValue = stack.GetMax();

            Assert.AreEqual(secondValue, returnedValue);
        }
    }
}
