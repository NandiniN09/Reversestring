using System;

namespace Reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
            const string str = "krishna";
            var chars = str.ToCharArray();
            var length = chars.Length;
            Console.WriteLine($"string length is {length}");
            for(var i=length-1; i>=0; i--)
            {
                Console.Write(chars[i]);
            }
        }
    }
}
