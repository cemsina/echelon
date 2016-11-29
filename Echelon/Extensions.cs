using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echelon
{
    public static class Extensions
    {
        public static List<int> GetDivisors(this int value)
        {
            int AbsValue = Math.Abs(value);
            List<int> primeList = new List<int>();
            for (int i = 2; i <= AbsValue; i++)
            {
                if (AbsValue % i == 0)
                {
                    primeList.Add(i);
                }
            }
            return primeList;
        }
        public static bool CanBeDivided(this int Number, int value)
        {
            int AbsValue = Math.Abs(Number);
            if (AbsValue % value == 0) { return true; }
            return false;
        }
        public static RNumber toRNumber(this string str)
        {
            str.Replace(" ","");
            string[] strArr = str.Split('/');
            if(strArr.Count() == 2)
            {
                int n = Convert.ToInt32(strArr[0]);
                int d = Convert.ToInt32(strArr[1]);
                return new RNumber(n, d);
            }
            else
            {
                int n = Convert.ToInt32(strArr[0]);
                return new RNumber(n);
            }
        }
    }
}
