﻿using System;
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
    public class Validate {
        
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

            return !regex.IsMatch(text);
        }

        /// <summary>
        /// String validation for numbers only.
        /// </summary>
        /// <returns>
        /// True if text contains only numbers. Otherwise return false.
        /// </returns>
        public static bool NumbersOnly(string text) {
            Regex regex = new Regex(numbersOnly);

            return !regex.IsMatch(text);
        }
    }
}
