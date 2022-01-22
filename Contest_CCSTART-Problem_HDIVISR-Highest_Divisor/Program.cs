using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int iInputNumber;

		iInputNumber = Convert.ToInt32(Console.ReadLine());

		for (int i = 10; i >= 1; i--)
		{
			if (iInputNumber % i == 0)
			{
				Console.WriteLine(i);
				break;
			}
		}
	}
}
