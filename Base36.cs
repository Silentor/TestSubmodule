using System;
using System.Collections.Generic;

//another change
//fixed

//change from another project
//fixed at new project

//some small change
//fixed at proj1
//version bump

//another change 4 fixed!

// another change 5
//     another change 6
//     another change 7
//     another change 8
//     another change 9
//     another change 10
//     another change 11
//     another change 12 one


//change 13

namespace Flexy.Utils2.Runtime
{
    public static class Base36
    {
        private const string CHARACTERS = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static UInt32 Decode(string value)
        {
            if ( String.IsNullOrEmpty( value ) )
                return 0;
            value = value.TrimStart( '0' ).ToUpperInvariant();
            Int64 number = 0;
            foreach(char c in value.ToUpperInvariant())
                number = number * 36 + CHARACTERS.IndexOf(c);

            return (UInt32)number;
        }

        public static String Encode(UInt32 input)
        {
            var result = new Stack<char>();
            while (input != 0)
            {
                result.Push(CHARACTERS[(Int32)(input % 36)]);
                input /= 36;
            }
            return new string(result.ToArray());
        }
    }
}
