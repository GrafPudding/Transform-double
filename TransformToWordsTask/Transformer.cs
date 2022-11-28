using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable CA1822
#pragma warning disable CA1305
#pragma warning disable CA1304

namespace TransformToWordsTask
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public sealed class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public string TransformToWords(double number)
        {
            double b = -0.0d;
            var g = BitConverter.GetBytes(b);
            var t = BitConverter.GetBytes(number);

            if (double.IsNaN(number))
            {
                return "NaN";
            }

            if (g[7] == t[7])
            {
                return "Minus zero";
            }
            else if (number == 0)
            {
                return "Zero";
            }

            if (number == double.Epsilon)
            {
                return "Double Epsilon";
            }

            if (number == double.PositiveInfinity)
            {
                return "Positive Infinity";
            }

            if (number == double.NegativeInfinity)
            {
                return "Negative Infinity";
            }

            List<string> preresultFirstPart = new List<string>();
            List<string> preresultSecondPart = new List<string>();
            string numberWithNoDot = number.ToString();
            string[] numberWithNoDotStep2 = numberWithNoDot.Split('.');
            char[] digitsBeforDot2 = numberWithNoDotStep2[0].ToCharArray();
            char[] digitsAfterDot2 = numberWithNoDotStep2[1].ToCharArray();

            for (int i = 0; i < digitsBeforDot2.Length; i++)
            {
                switch (digitsBeforDot2[i])
                {
                    case '0':
                        preresultFirstPart.Add("zero");
                        break;

                    case '1':
                        preresultFirstPart.Add("one");
                        break;

                    case '2':
                        preresultFirstPart.Add("two");
                        break;

                    case '3':
                        preresultFirstPart.Add("three");
                        break;

                    case '4':
                        preresultFirstPart.Add("four");
                        break;

                    case '5':
                        preresultFirstPart.Add("five");
                        break;

                    case '6':
                        preresultFirstPart.Add("six");
                        break;

                    case '7':
                        preresultFirstPart.Add("seven");
                        break;

                    case '8':
                        preresultFirstPart.Add("eight");
                        break;

                    case '9':
                        preresultFirstPart.Add("nine");
                        break;

                    case '-':
                        preresultFirstPart.Add("Minus");
                        break;
                }
            }

            for (int j = 0; j < digitsAfterDot2.Length; j++)
            {
                switch (digitsAfterDot2[j])
                {
                    case '0':
                        preresultSecondPart.Add("zero");
                        break;

                    case '1':
                        preresultSecondPart.Add("one");
                        break;

                    case '2':
                        preresultSecondPart.Add("two");
                        break;

                    case '3':
                        preresultSecondPart.Add("three");
                        break;

                    case '4':
                        preresultSecondPart.Add("four");
                        break;

                    case '5':
                        preresultSecondPart.Add("five");
                        break;

                    case '6':
                        preresultSecondPart.Add("six");
                        break;

                    case '7':
                        preresultSecondPart.Add("seven");
                        break;

                    case '8':
                        preresultSecondPart.Add("eight");
                        break;

                    case '9':
                        preresultSecondPart.Add("nine");
                        break;

                    case 'E':
                        preresultSecondPart.Add("E");
                        break;

                    case '+':
                        preresultSecondPart.Add("plus");
                        break;
                }
            }

            string[] aa = preresultFirstPart.ToArray();
            char[] upperletter = aa[0].ToCharArray();
            upperletter[0] = char.ToUpper(upperletter[0]);
            aa[0] = new string(upperletter);
            string[] bb = preresultSecondPart.ToArray();
            string firsresult = string.Join(" ", aa);
            string secondresult = string.Join(" ", bb);

            return firsresult + " point " + secondresult;
        }
    }
}
