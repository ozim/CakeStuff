using System;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string toBeReversed = "landed has. eagle the!";
            string result = "the eagle has. landed!";

            char[] characters = toBeReversed.ToCharArray();


            Reverse(characters, 0, characters.Length - 1);

            Console.WriteLine(characters);
            Console.ReadKey();

            int start = 0;
            for (int i = 0; i <= characters.Length; i++)
            {
                if (i == characters.Length || characters[i].Equals(' ')) {
                    Reverse(characters, start, i-1);
                    start = i+1;
                } 
            }

            Console.WriteLine(String.Concat(characters) + " is equal " + result);
            Console.ReadKey();
        }

        public static void Reverse(char[] arr, int start, int end)
        {
            while (start < end) {
                if (arr[end] == '.' || arr[end] == ',' || arr[end] == '!' || arr[end] == '?')
                {
                    end--;
                }
                var temp = arr[end];
                arr[end] = arr[start];
                arr[start] = temp;

                start++;
                end--;
            }
        }
    }
}
