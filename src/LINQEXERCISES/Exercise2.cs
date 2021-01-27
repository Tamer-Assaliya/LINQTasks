using System.Collections.Generic;
using System.Linq;

namespace AllTogether1
{
    public class FullExercise2
    {
        // Given a sequence of words, get rid of any that don't have the character 'e' in them,
        // then sort the remaining words alphabetically, then return the following phrase using
        // only the final word in the resulting sequence:
        //    -> "The last word is <word>"
        // If there are no words with the character 'e' in them, then return null.
        //
        // TRY to do it all using only LINQ statements. No loops or if statements.
        public static string GetTheLastWord(IEnumerable<string> words)
        {
            return words
                .Where(w => w.Contains("e"))
                .OrderBy(w => w)
                .Select(w => $"The last word is {w}")
                .LastOrDefault()
                ;
        }
    }
}