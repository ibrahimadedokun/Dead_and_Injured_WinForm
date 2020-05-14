using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public class Operation
    {
        public static string WinWord = "Eureka!";

        public static bool NumberValidator(TextBox t, int numLen = 0)
        {
            string option = t.Text.ToString();
            bool isRepeated = IsDigitRepeated(option);
            if (isRepeated) { return false; }
            int result;
            bool isNumberValid = false;
            isNumberValid = int.TryParse(option, out result);
            if (isNumberValid != true || (option.Length != numLen)) { return false; }
            else { return true; }
        }

        public static bool TextValidator(TextBox t)
        {
            return !(string.IsNullOrEmpty(t.Text.ToString()));
        }

        public static bool IsDigitRepeated(string s)
        {            
            bool status = false;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = (i + 1); j < s.Length; ++j)
                {
                    if (s[i] == s[j]) return true;
                }
            }
            return status;
        }
    }

}
