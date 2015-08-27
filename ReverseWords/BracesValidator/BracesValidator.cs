namespace BracesValidator
{
    using System.Collections.Generic;

    public class BracesValidator
    {
        public bool Validate(string code)
        {
            char[] codeArray = code.ToCharArray();

            Dictionary<char, char> openersClosersMap = new Dictionary<char, char>();
            openersClosersMap.Add('{', '}');
            openersClosersMap.Add('[', ']');
            openersClosersMap.Add('(', ')');
            openersClosersMap.Add('|', '|');

            Stack<char> parensStack = new Stack<char>();

            int braceCounter = 0;

            for (int i = 0; i < codeArray.Length; i++)
            {
                if((parensStack.Peek() == codeArray[i])) {
                    parensStack.Pop();
                } else {
                    if (openersClosersMap.ContainsKey(codeArray[i])) {
                        parensStack.Push(codeArray[i]);
                    }

                    if (openersClosersMap.ContainsValue(codeArray[i]) && codeArray[i]!='|')
                    {
                        var current = parensStack.Pop();
                        if (openersClosersMap[current] != codeArray[i])
                        {
                            return false;
                        }
                    }
                }
            }
            
            return parensStack.Count == 0;
        }
    }
}
