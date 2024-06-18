using System;
using System.Threading.Tasks;

namespace NET_Essentials.CodeSamples
{
    public class AsyncVoidProblem
    {
        public static async Task TestAsyncVoid()
        {
            try
            {
                string userName = null;
                PrintUserNameLength_INCORRECT(userName);
                PrintUserNameLength_CORRECT(userName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static async void PrintUserNameLength_INCORRECT(string userName)
        {
            Console.WriteLine(userName.Length);
        }
        
        private static async void PrintUserNameLength_CORRECT(string userName)
        {
            try
            {
                Console.WriteLine(userName.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}