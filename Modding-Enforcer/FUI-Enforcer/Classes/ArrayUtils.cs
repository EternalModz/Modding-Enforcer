namespace FUI_Enforcer.Classes
{
    static class ArrayUtils
    {
        /// <summary>
        /// Search for a byte sequence that matches a byte pattern in a byte array using the Sunday algorithm.
        /// </summary>
        /// <param name="pattern">The pattern to search for</param>
        /// <param name="text">The array to search through</param>
        /// <returns>The starting position if found, or -1 if not found</returns>
        public static int SearchBytes(byte[] text, int startIndex, byte[] pattern)
        {
            int patternLen = pattern.Length, textLen = text.Length;

            // Create the shift table
            int[] qs_table = new int[byte.MaxValue + 1];

            // For characters not in the pattern, shift the search window by patternLen+1
            for (int i = qs_table.Length; i-- > 0;) qs_table[i] = patternLen + 1;

            // For characters in the pattern, shift the search window to the position where the character matches the pattern
            for (int n = 0; n < patternLen; ++n) qs_table[pattern[n]] = patternLen - n;

            int pos;

            // Search through the text using the shift table until the end of the text is reached
            for (pos = startIndex; pos < textLen - patternLen; pos += qs_table[text[pos + patternLen]])
            {
                // If a match is found, return the position
                if (CompareBytes(text, pos, pattern, patternLen)) return pos;
            }

            // If the end of the text has not been searched, search it
            if (pos == textLen - patternLen)
            {
                // If a match is found, return the position
                if (CompareBytes(text, pos, pattern, patternLen)) return pos;
            }

            // No match found
            return -1;
        }

        /// <summary>
        /// Check if one array (pattern) is contained in another array (text)
        ///
        /// If pos+patternLen is greater than text.Length or if pos or patternLen is less than 0, or if needleLen is greater than pattern.Length,
        /// ArrayOutOfBoundException will be thrown.
        /// </summary>
        /// <param name="text">The array to compare to the pattern, starting at position pos</param>
        /// <param name="pos">Where to start the comparison in the text array</param>
        /// <param name="pattern">The array to compare against the text array, starting from the beginning</param>
        /// <param name="patternLen">The length of the pattern to compare</param>
        /// <returns></returns>
        static bool CompareBytes(byte[] text, int pos, byte[] pattern, int patternLen)
        {
            for (int comparer = 0; comparer < patternLen; ++comparer)
            {
                if (text[comparer + pos] != pattern[comparer]) return false;
            }
            return true;
        }
    }
}