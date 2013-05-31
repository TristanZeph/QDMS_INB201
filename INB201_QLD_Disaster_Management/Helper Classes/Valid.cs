using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace INB201_QLD_Disaster_Management.Helper_Classes {
    /// <summary>
    /// Static class that validates text in form inputs.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public class Valid {
        
        // regex values for string validation
        private const string EMPTY = "";
        private const string lettersOnly = "^[a-zA-Z]+$";
        private const string numbersOnly = "^[0-9]+$";

        /// <summary>
        /// Validation for null string.
        /// </summary>
        /// <returns>
        /// True, if text is null. Otherwise return false.
        /// </returns>
        public static bool Null(string text) {
            return text == null || text == EMPTY;
        }

        /// <summary>
        /// String validation for letters only.
        /// </summary>
        /// <returns>
        /// True, if text contains letters only. Otherwise return false.
        /// </returns>
        public static bool LettersOnly(string text) {
            Regex regex = new Regex(lettersOnly);

            return regex.IsMatch(text);
        }

        /// <summary>
        /// String validation for numbers only.
        /// </summary>
        /// <returns>
        /// True if text contains only numbers. Otherwise return false.
        /// </returns>
        public static bool NumbersOnly(string text) {
            Regex regex = new Regex(numbersOnly);

            return regex.IsMatch(text);
        }

        /// <summary>
        /// String validation for correct text length.
        /// </summary>
        /// <param name="size">Maximum size of the text</param>
        /// <param name="text">The input value</param>
        /// <returns>
        /// True, if the text count is greater than size.
        /// Otherwise, return false.
        /// </returns>
        public static bool Size(int size, string text) {
            int count = text.Count();

            return count < size;
        }

        /// <summary>
        /// Number validation for number betweens two values
        /// </summary>
        /// <param name="number">the number to be tested</param>
        /// <param name="lowerBound">lower number boundary</param>
        /// <param name="upperBound">upper number boundary</param>
        /// <returns>
        /// true if number is between lowerBound and upperBound,
        /// Otherwise false
        /// </returns>
        public static bool BetweenBoundaries(int number, int lowerBound, int upperBound) {
            return number >= lowerBound && number <= upperBound;
        }
    }
}
