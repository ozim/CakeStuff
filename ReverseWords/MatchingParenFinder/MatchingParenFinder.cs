namespace MatchingParenFinder
{
    using System;
    using System.Collections.Generic;

    public class MatchingParenFinder
    {
        public int FindMatchingParenPosition(string text, int position) {
            if (String.IsNullOrWhiteSpace(text)) throw new ArgumentException("text");
            if (position < 0) throw new ArgumentOutOfRangeException("position cannot be less than 0");
            if (position > text.Length) throw new ArgumentOutOfRangeException("position cannot be longer than text");

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
