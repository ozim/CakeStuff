namespace BracesValidator
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class BracesValidatorTests
    {
        [TestCase("{ [ ] ( ) }", Result = true)]
        [TestCase("{ [ ] | | }", Result = true)]
        [TestCase("{ [ ] ( | ) | }", Result = false)]
        [TestCase("{ [ ] { | | | } }", Result = false)]
        [TestCase("{ [ ( ] ) }", Result = false)]
        [TestCase("{ [ }", Result = false)]
        
        public bool CheckOutcome(string code)
        {
            BracesValidator validator = new BracesValidator();
            return validator.Validate(code);
        }

        [Test]
        public void ThrowsIfStingIsNull() {
            string code = null;
            BracesValidator validator = new BracesValidator();
            Assert.Throws(typeof(ArgumentNullException), ()=> validator.Validate(code));
        }

        [Test]
        public void ReturnsTrueIfStringIsEmpty()
        {
            string code = String.Empty;
            BracesValidator validator = new BracesValidator();
            Assert.True(validator.Validate(code));
        }
    }
}
