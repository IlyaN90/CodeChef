using System;

static class Program
{
    public static void Main()
    {


        /*int T= Int32.Parse(Console.ReadLine());
        while (T != 0)
        {
            string N=Console.ReadLine();
            bool isPalindrome = true;
            for(int i = 0; i < N.Length; i++)
            {
               if (!N[i].Equals(N[N.Length - i-1]))
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("wins");
            }
            else
            {
                Console.WriteLine("losses");
            }
            T--;
        }
        --------------------------------------------------------
        var T = int.Parse(Console.ReadLine());
        for (var t = 0; t < T; ++t)
        {
            var NK = Array.ConvertAll(
                Console.ReadLine().Split(null), int.Parse);
            var N = NK[0];
            var K = NK[1];
            var A = Array.ConvertAll(
                Console.ReadLine().Split(null), int.Parse);
            Array.Sort(A);
            long sum = 0;
            for (int i = K; i < (N - K); ++i)
            {
                sum += A[i];
            }
            Console.WriteLine((sum / (double)(N - 2 * K)));
        }*/
    }
}