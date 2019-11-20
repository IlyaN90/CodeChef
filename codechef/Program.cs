using System;
using System.Collections.Generic;
using System.Linq;

static class Program
{
    public static void Main()
    {
        int T = Int32.Parse(Console.ReadLine());
        while (T > 0) 
        { 
            var map = new Dictionary<char, int>();
            string str = Console.ReadLine();
            str= String.Concat(str.OrderBy(c => c));
            int i = 0;
            int multiple = 0;
            int[] intArr = new int[str.Length];
            foreach (char ch in str)
            {
                if (map.TryGetValue(ch, out multiple))
                {
                    map[ch] = multiple + 1;
                    i++;
                }
                else
                {
                    map.Add(ch, 1);
                }
            }
            i = 0;
            foreach (var s in map)
            {
                intArr[i] = s.Value;
                i++;
            }
            i = 0;
            int sum = 0;
            Array.Sort(intArr);
            Array.Reverse(intArr);
            for (i = 1; i < intArr.Length; i++)
            {
                sum += intArr[i];
            }
            if (intArr[0] == sum)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
            T--;
        }
    }
}
       /* int T = Int32.Parse(Console.ReadLine());
        string testCase= Console.ReadLine();
        string[] input = testCase.Split(null,4);
        int start = Convert.ToInt32((input[0] + input[1]), 2);
        int finish = Convert.ToInt32((input[2] + input[3]), 2);
        int[] numArray = Array.ConvertAll(testCase.Split(null,4), int.Parse);
        int x1 = numArray[0];
        int y1 = numArray[1];
        int x2 = numArray[2];
        int y2 = numArray[3];
        Console.WriteLine(start);
        Console.WriteLine(finish);
        int result = start - finish;
        if ((result > 2&& result<2)||(x1!=x2&&y1!=y2))
        {
            Console.WriteLine("sad");
        }
        else if (y1 > y2) 
        {
            Console.WriteLine("down");
        }
        else if (y1 < y2)
        {
            Console.WriteLine("up");
        }
        else if (start > finish)
        {
            Console.WriteLine("left");
        }
        else if (finish < start)
        {
            Console.WriteLine("right");
        }
        T--;    
    }
}

int T= Int32.Parse(Console.ReadLine());
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
using System;

static class Program
{
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int k = Int32.Parse(Console.ReadLine());
        int loopVar = n;
        int divCount = 0;
        while (loopVar > 0)
        {
            if (k%n==0)
            {
                divCount++;
            }
            loopVar--;
        }
        Console.WriteLine(divCount);
    }
}
--------------------------------------------------------
var T = int.Parse(Console.ReadLine());
for (var t = 0; t < T; ++t)
{
    int NK = Array.ConvertAll(
        Console.ReadLine().Split(null), int.Parse);
    int N = NK[0];
    int K = NK[1];
    int A = Array.ConvertAll(
        Console.ReadLine().Split(null), int.Parse);
    Array.Sort(A);
    long sum = 0;
    for (int i = K; i < (N - K); ++i)
    {
        sum += A[i];
    }
    Console.WriteLine((sum / (double)(N - 2 * K)));
}*/
