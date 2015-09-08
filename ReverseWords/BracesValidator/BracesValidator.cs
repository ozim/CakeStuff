namespace BracesValidator
{
    using System;
    using System.Collections.Generic;

    public class BracesValidator
    {
        public bool Validate(string code)
        {
            if(code == null) {
                throw new ArgumentNullException("code");
            }
            char[] codeArray = code.ToCharArray();

            Dictionary<char, char> openersClosersMap = new Dictionary<char, char>();
            openersClosersMap.Add('{', '}');
            openersClosersMap.Add('[', ']');
            openersClosersMap.Add('(', ')');
            openersClosersMap.Add('|', '|');

            Stack<char> parensStack = new Stack<char>();

            for (int i = 0; i < codeArray.Length; i++)
            {

                if(codeArray[i]=='|' && parensStack.Peek() != '|') {
                    parensStack.Push(codeArray[i]);
                } else if(codeArray[i] == '|')
                {
                    parensStack.Pop();
                }

                if (openersClosersMap.ContainsKey(codeArray[i]))
                {
                    parensStack.Push(codeArray[i]);
                }

                if (openersClosersMap.ContainsValue(codeArray[i]) )
                {
                    var current = parensStack.Pop();
                    if (openersClosersMap[current] != codeArray[i])
                    {
                        return false;
                    }
                }
            }

            return parensStack.Count == 0;
        }
    }
}
