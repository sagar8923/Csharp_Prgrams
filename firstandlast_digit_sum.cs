
// If Give an integer N . Write a program to obtain the sum of the first and last digits of this number.



using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int T = int.Parse(Console.ReadLine());
		
		while(T>0)
		{
		    int N = int.Parse(Console.ReadLine());
		    int rem = N%10;
		    while(N>=10)
		    {
		        N=N/10;
		    }
		    int sum = rem+N;
		    Console.WriteLine(sum);		 
		    T--;
		}
	}
}
