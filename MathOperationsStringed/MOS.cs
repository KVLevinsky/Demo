using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsStringed {
    public class MOS {
        public static string Add(string operand1, string operand2) {
            string result = "";
            int maxLength = Math.Max(operand1.Length, operand2.Length);
            operand1 = Normalize(operand1, maxLength);
            operand2 = Normalize(operand2, maxLength);
            byte digit1 = 0, digit2 = 0, digitCarry = 0;
            for (int i = 0; i < maxLength; i++) {
                if (!byte.TryParse(operand1[i].ToString(), out digit1)) break;
                if (!byte.TryParse(operand2[i].ToString(), out digit2)) break;
                int sum = digit1 + digit2 + digitCarry;
                result += (sum % 10).ToString();
                digitCarry = (byte)(sum / 10);
            }
            result += digitCarry.ToString();
            result = ReverseString(result);
            return result;
        }

        public static string Normalize(string operand, int maxLength) {
            string result = ReverseString(operand) + new string('0', maxLength - operand.Length);
            return result;
        }

        public static string ReverseString(string value) {
            char[] temp = value.ToCharArray();
            Array.Reverse(temp);
            return new string(temp);
        }
    }
}
