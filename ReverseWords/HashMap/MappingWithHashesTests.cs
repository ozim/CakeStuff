namespace HashMap
{
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

        [Test]
        public void AddMultipleValues()
        {
            MappingWithHashes hashMapping = new MappingWithHashes();

            string[] listOfValues = new string[5];
            listOfValues[0] = "something";
            listOfValues[1] = "something1";
            listOfValues[2] = "mindfull";
            listOfValues[3] = "makes no sense";
            listOfValues[4] = "blue thing";

            foreach (string element in listOfValues) {
                hashMapping.Add(element);
            }

            foreach (string element in listOfValues)
            {
                Assert.True(hashMapping.Contains(element));
            }
        }
    }
}
