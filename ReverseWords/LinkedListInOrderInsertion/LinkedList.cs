namespace LinkedListInOrderInsertion
{
    public class LinkedList
    {

        private Element Head = null;
        internal void Add(int value)
        {
            Element insertedElement = new Element { Value = value };
            if (Head == null) {
                Head = insertedElement;
            } else
            {
                Element current = Head;
                
                if(current.Value > insertedElement.Value) {
                    Head = insertedElement;
                    Head.Next = current;
                    return;
                }

                while(current.Next != null) {
                    
                    current = current.Next;
                }

                current.Next = insertedElement;
            }
        }

        internal int Last()
        {
            Element current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            return current.Value;
        }
    }
}
