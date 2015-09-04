namespace HashMap
{
    public class MappingWithHashes
    {
        private BucketHolder[] internalContainer = new BucketHolder[1000];

        public MappingWithHashes(){
            for(int i=0; i<internalContainer.Length-1; i++) {
                internalContainer[i] = new BucketHolder();
            }
        }

        internal void Add(string item)
        {
            int calculatedIndex = CalculateIndex(item);
            internalContainer[calculatedIndex].Insert(item);
        }

        public bool Contains(string item) {
            int calculatedIndex = CalculateIndex(item);
            return internalContainer[calculatedIndex].CheckIfContains(item);
        }

        private int CalculateIndex(string item) {
            char[] itemByCharacter = item.ToCharArray();

            int firstPiece = itemByCharacter.Length - 1;
            int secondPiece = itemByCharacter.Length - 2;
            int thirdPiece = itemByCharacter.Length - 3;

            if(firstPiece > itemByCharacter.Length - 1) {
                firstPiece = itemByCharacter.Length;
            }
            if (secondPiece > itemByCharacter.Length - 1)
            {
                secondPiece = itemByCharacter.Length;
            }
            if (thirdPiece > itemByCharacter.Length - 1)
            {
                thirdPiece = itemByCharacter.Length;
            }

            if (firstPiece < 0)
            {
                firstPiece = 0;
            }
            if (secondPiece < 0)
            {
                secondPiece = 0;
            }
            if (thirdPiece < 0)
            {
                thirdPiece = 0;
            }

            return (itemByCharacter[thirdPiece] >> 2) * (itemByCharacter[firstPiece] >> 1) / itemByCharacter[secondPiece];
        }
    }
}
