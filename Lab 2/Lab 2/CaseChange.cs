using System;

namespace Lab2
{
    class CaseChange
    {
        public static char ChangeCase(char ch)
        {
            if (char.IsLower(ch))
            {
                return char.ToUpper(ch);
            }
            else if (char.IsUpper(ch))
            {
                return char.ToLower(ch);
            }
            else
            {
                return ch;
            }
        }
    }
}