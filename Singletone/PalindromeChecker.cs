using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class PalindromeChecker
    {
        public bool IstPalindrome(string wort)
        {
            //Palindrom
            string umgedreht = new string(wort.Reverse().ToArray());

            var result = wort.Equals(umgedreht, StringComparison.Ordinal); // شته ها را بایت به بایت بر اساس مقادیر باینری کاراکترها
                                                                           // (حساس به حروف کوچک و بزرگ) مقایسه می کند.

            var result2 = wort.Equals(umgedreht, StringComparison.OrdinalIgnoreCase); // غیرحساس به حالت حروف کوچک و بزرگ 
            var result3 = wort.Equals(umgedreht, StringComparison.CurrentCulture);
             // False in vielen Kulturen, True in einigen deutschen Szenarien

            return result;
        }
    }
}
