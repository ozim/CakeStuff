namespace BracesValidator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;

    [TestFixture]
    public class BracesValidatorTests
    {
        [TestCase("{ [ ] ( ) }", Result = true)]
        [TestCase("{ [ ( ] ) }", Result = false)]
        [TestCase("{ [ }", Result = false)]
        public bool CheckOutcome(string code)
        {
            BracesValidator validator = new BracesValidator();
            return validator.Validate(code);
        }
    }
}
