namespace HashMap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;

    [TestFixture]
    class MappingWithHashesTests
    {
        [Test]
        public void FindHashedValue() {
            MappingWithHashes hashMapping = new MappingWithHashes();
            string testValue = "something";
            
            hashMapping.Add(testValue);
            Assert.True(hashMapping.Contains(testValue));
        }
    }
}
