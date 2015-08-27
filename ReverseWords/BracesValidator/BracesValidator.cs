namespace BracesValidator
{
    using System.Collections.Generic;

    public class BracesValidator
    {
        public bool Validate(string code)
        {
            char[] codeArray = code.ToCharArray();
            List<char> openers = new List<char> { '{', '[', '(' };
            List<char> closers = new List<char> { '}', ']', ')' };

            Stack<char> parensStack = new Stack<char>();

            int braceCounter = 0;

            for (int i = 0; i < codeArray.Length; i++)
            {
                if(openers.Contains(codeArray[i])) {
                    parensStack.Push(codeArray[i]);
                }

                if(closers.Contains(codeArray[i])) {
                    var current = parensStack.Pop();
                    if(openers.IndexOf(current) != closers.IndexOf(codeArray[i])) {
                        return false;
                    }
                }
            }
            
            return parensStack.Count == 0;
        }
    }
}
