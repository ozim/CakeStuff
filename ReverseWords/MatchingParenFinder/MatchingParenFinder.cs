namespace MatchingParenFinder
{
    using System.Collections.Generic;

    public class MatchingParenFinder
    {
        public int FindMatchingParenPosition(string text,int position) {

            char[] codeArray = text.ToCharArray();
            Stack<char> parensStack = new Stack<char>();

            for (int i = position; i < codeArray.Length; i++)
            {
                if (codeArray[i] == '(')
                {
                    parensStack.Push(codeArray[i]);
                }
                if (codeArray[i] == ')')
                {
                    parensStack.Pop();
                }
                if(parensStack.Count == 0) {
                    return i;
                }
            }

            return 0;
        }
    }
}
