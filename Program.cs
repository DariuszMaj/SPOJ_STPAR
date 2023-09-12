using System;
using System.Collections.Generic;

namespace STPAR
{
    class Program
    {
       static void Main(string[] args)
        {
            int last;
    
            string[] data;
            int n = 1;
            while (n != 0) 
            {
                n = int.Parse(Console.ReadLine());
                if (n == 0) 
                    return;
                data = Console.ReadLine().Split(" ");
                int[] a = new int[n];
                for (int d = 0; d < n; d++)
                {
                    int x = int.Parse(data[d]);
                    if (x == 0) 
                        return;
                    a[d] = x;
                }
                Stack<int> mystack = new Stack<int>();

                last = 1;
                bool check = true;
                for (int i = 0; i < n; i++)
                {
                    if (mystack.Count > 0 && mystack.Peek() == last)
                    {
                        mystack.Pop();
                        last++;
                    }
                    else if (a[i] == last) 
                        last++;

                    else if (mystack.Count > 0 && mystack.Peek() < a[i])
                    {
                        check = false;
                        break;
                    }

                    else 
                        mystack.Push(a[i]); 
                }
                if (n != 0)
                {
                    if (check) 
                        {Console.WriteLine("yes");}
                    else
                        {Console.WriteLine("no");}
                }
            } 
        }   
    }          
}
    

