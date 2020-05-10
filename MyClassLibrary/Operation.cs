using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyClassLibrary
{
    public class Operation
    {
        public static void ResetTextBox(TextBox t, TextBox t1 = null)
        {
            t.ResetText();
            t1.ResetText();
            t.Focus();
        }

        public static bool NumberValidator(TextBox t)
        {
            string option = t.Text.ToString();
            int result;
            bool isNumberValid = false;
            isNumberValid = int.TryParse(option, out result);
            if (isNumberValid != true) { return false; }
            else { return true; }
        }

        public static bool TextValidator(TextBox t)
        {
            return !(string.IsNullOrEmpty(t.Text.ToString()));
        }

        public static bool IsDigitRepeated(TextBox t)
        {
            string s = t.Text.ToString();
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
