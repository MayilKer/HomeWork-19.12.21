using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork19._12._21.Extensions
{
  public static class Exten
    {
        public static void Check(this string word, string simvol)
        {
            bool res = false;
            if (word.Contains(simvol))
            {
                res = true;
            }
            Console.WriteLine(res);
            
            
        }
    }
}
