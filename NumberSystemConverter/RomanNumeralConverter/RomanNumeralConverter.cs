﻿#region Usings
using System;
using System.Collections.Generic;
using System.Text;
#endregion
// DO NOT CHANGE
namespace NumberSystemConverter
{
    #region Container for allowing management of RomanNumeralsType enumerals
    struct RomanNumeralPair
    {
        public int NumericValue { get; set; }
        public string RomanNumeralRepresentation { get; set; }
    }
    #endregion
    #region Roman Numerals - Seven symbols(enum RomanNumeralsType) with respective value.
    enum RomanNumeralsType
    {
        M = 1000,
        CM=900,
        D = 500,
        CD=400,
        C = 100,
        XC=90,
        L = 50,
        XL=40,
        X = 10,
        IX=9,
        V = 5,
        IV=4,
        I = 1
    }
    #endregion
    public class RomanNumeralConverter
    {
        // Readonly - The variable assigned with the readonly operator can only be changed inside the declaration or in the constructor
        private List<RomanNumeralPair> romanNumeralList;

        public RomanNumeralConverter()
        {
            #region Initializing the list with romanNumerals
            romanNumeralList = new List<RomanNumeralPair>()
            {
                new RomanNumeralPair() {
                    // 1000
                    NumericValue = (int)RomanNumeralsType.M,
                    RomanNumeralRepresentation = RomanNumeralsType.M.ToString()
                },
                 new RomanNumeralPair() {
                    // 900
                    NumericValue = (int)RomanNumeralsType.CM,
                    RomanNumeralRepresentation = RomanNumeralsType.CM.ToString()
                },
                new RomanNumeralPair() {
                    // 500
                    NumericValue = (int)RomanNumeralsType.D,
                    RomanNumeralRepresentation = RomanNumeralsType.D.ToString()
                },
                new RomanNumeralPair() {
                    // 400
                    NumericValue = (int)RomanNumeralsType.CD,
                    RomanNumeralRepresentation = RomanNumeralsType.CD.ToString()
                },
                new RomanNumeralPair() {
                    // 100
                    NumericValue = (int)RomanNumeralsType.C,
                    RomanNumeralRepresentation = RomanNumeralsType.C.ToString()
                },
                 new RomanNumeralPair() {
                    // 90
                    NumericValue = (int)RomanNumeralsType.XC,
                    RomanNumeralRepresentation = RomanNumeralsType.XC.ToString()
                },
                new RomanNumeralPair() {
                    // 50
                    NumericValue = (int)RomanNumeralsType.L,
                    RomanNumeralRepresentation = RomanNumeralsType.L.ToString()
                },
                new RomanNumeralPair() {
                    // 40
                    NumericValue = (int)RomanNumeralsType.XL,
                    RomanNumeralRepresentation = RomanNumeralsType.XL.ToString()
                },
                new RomanNumeralPair() {
                    // 10
                    NumericValue = (int)RomanNumeralsType.X,
                    RomanNumeralRepresentation = RomanNumeralsType.X.ToString()
                },
                new RomanNumeralPair() {
                    // 9
                    NumericValue = (int)RomanNumeralsType.IX,
                    RomanNumeralRepresentation = RomanNumeralsType.IX.ToString()
                },
                new RomanNumeralPair() {
                    // 5
                    NumericValue = (int)RomanNumeralsType.V,
                    RomanNumeralRepresentation = RomanNumeralsType.V.ToString()
                },
                new RomanNumeralPair() {
                    // 4
                    NumericValue = (int)RomanNumeralsType.IV,
                    RomanNumeralRepresentation = RomanNumeralsType.IV.ToString()
                },
                new RomanNumeralPair() {
                    // 1
                    NumericValue = (int)RomanNumeralsType.I,
                    RomanNumeralRepresentation = RomanNumeralsType.I.ToString()
                }
            };
            #endregion 
        }

        public string ConvertToRomanNumeral(int number)
        {
            StringBuilder builder = new StringBuilder();
            #region test för UnitTesterna ska gå igenom
            //if (number > 0)
            //    number += 1;
            #endregion
            if (number < 1)
                throw new InvalidOperationException("Roman numbers starts from one 'I' ");
            // Iterate through the list, starting with the highest value
            foreach (var currentPair in romanNumeralList)
            {
                // BUGGEN
                //while (number > currentPair.NumericValue)
                while (number >= currentPair.NumericValue)
                {
                // ...number is greater than or equal to the current value so store the roman numeral and decrement it's value
                builder.Append(currentPair.RomanNumeralRepresentation);
                number -= currentPair.NumericValue;
                }
            }
            return builder.ToString();
        }
    }
}