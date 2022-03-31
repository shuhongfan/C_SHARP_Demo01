using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Function
{
    public class DigitCount
    {
        // 计算字符串中的数字个数
        public static int NumberOfDigits(string TheString)
        {

            int Count = 0;
            for (int i = 0; i < TheString.Length; i++)
            {
                if (Char.IsDigit(TheString[i]))
                {
                    Count++;
                }
            }
            return Count;
        }

    }
}
