namespace LinkedListInOrderInsertion
{
    using System;
    using System.Collections.Generic;

    public class LinkedList
    {

        private Element Head = null;
        private Element Iterator = new Element();

        internal void Add(int value)
        {
            Element insertedElement = new Element { Value = value };
            if (Head == null) {
                Head = insertedElement;
                Iterator.Next = Head;
            } else
            {
                Element current = Head;
                
                if(current.Value > insertedElement.Value) {
                    Head = insertedElement;
                    Head.Next = current;

                    Iterator.Next = Head;
                    return;
                }

                while(current.Next != null) {
                    if(current.Next.Value > insertedElement.Value) {
                        insertedElement.Next = current.Next;
                        current.Next = insertedElement;
                        return;
                    }
                    current = current.Next;
                }

                current.Next = insertedElement;
            }
        }

        internal int Last()
        {
            Element current = Head;
            if(current == null) {
                throw new InvalidOperationException("List is empty");
            }
            while (current.Next != null)
            {
                current = current.Next;
            }

            return current.Value;
        }

        internal void PrintInReversedOrder(Element startElement) {
            if (startElement == null)
            {
                return;
            }
            
            PrintInReversedOrder(startElement.Next);
            Console.WriteLine(startElement.Value);
        }

        internal IEnumerable<Element> Next()
        {
            if(Iterator.Next != null) {
                yield return Iterator.Next;
            }
        }
    }
}
