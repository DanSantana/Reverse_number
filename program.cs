using System;
					
public class Program
{
	public static void Main()
	{	//reverse integer
		
		int num =0, r = 0, sum=0;
		Console.WriteLine(" **** Reverse Number **** ");
		Console.WriteLine("Insert the Number:");
		num = int.Parse(Console.ReadLine());
		int input = num;
		
		while( num != 0)
		{
			sum = sum * 10;
			r = (num % 10);
			sum = sum + r;
			num /= 10;
		}
		Console.WriteLine("The reverse of {0} id {1}",input,sum);
	}
}
