using System;
using System.Collections.Generic;
using System.Linq;

namespace Keyboard
{ 
   // Given a non-empty string consisting only of special chars(!, @, # etc.),
  // return a number (as a string) where each digit corresponds to a given special
  // char on the custom keyboard
  // ( 1→ ), 2 → (, 3 → *, 4→&, 5 →^, 6 →%, 7 →$, 8 →#, 9 →@, 0 →!  ). Expected input and output
  //"())(" → "2112" "*$(#&" → "3284" "!!!!!!!!!!" → "0000000000"
  //The Questions Above Should be Implemented using LINQ in both QuerySyntax and Method Syntax

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Functional keys character of your keyboard: \n");
            string userInput = Console.ReadLine();
            var customKeyboards = new Dictionary<char, string>()
            {
                {')', "1" },
                {'(', "2" },
                {'*', "3" },
                {'&', "4" },
                {'^', "5" },
                {'%', "6" },
                {'$', "7" },
                {'#', "8" },
                {'@', "9" },
                {'!', "0" },
            };

            Console.WriteLine("Using Foreach Loop ==========================\n");
            foreach (var key in userInput)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(customKeyboards[key]);
                Console.ResetColor();
            }
            Console.WriteLine("\n");
            // Values can be accessed by passing associated key in the indexer => myMic[key];

            Console.WriteLine("Using Query selector LINQ==========================\n");

            var queryresult = from key in userInput
                              where customKeyboards.ContainsKey(key)
                              select customKeyboards[key];

            foreach (var functionalkey in queryresult)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(functionalkey);
                Console.ResetColor();
            }

            Console.WriteLine("\n");
            Console.WriteLine("Using Method selector LINQ==========================\n");
            var methodresult = userInput.Where(key => customKeyboards
            .ContainsKey(key)).Select(key => customKeyboards[key]);

            foreach (var functionalkey in methodresult)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(functionalkey);
                Console.ResetColor();
            }
            Console.WriteLine("\n");

        }


    }
}
