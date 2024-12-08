using MySamples;
using Singletone;

class Program
{
    static void Main(string[] args)
    {
        #region Singletone
        //Logger logger = Logger.Instance;

        //logger.Log("Dies ist eine Log-Nachricht.");

        //// Weitere Log-Nachricht schreiben
        //Logger.Instance.Log("Eine weitere Log-Nachricht.");

        //Logger logger2 = Logger.Instance;
        //Console.WriteLine(object.ReferenceEquals(logger, logger2)); // Gibt 'True' aus

        //logger.Update();
        //Logger logger3 = Logger.Instance;
        #endregion

        #region PalindromeChecker
        //PalindromeChecker palindromeChecker = new PalindromeChecker();
        //palindromeChecker.IstPalindrome("hallo ...");
        #endregion

        #region Fibonacci
        Fibonacci fibonacci = new Fibonacci();
        fibonacci.BerechneFibonacci(10);
        #endregion

    }
}