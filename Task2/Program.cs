﻿void Main()
{
	Console.Write("Введите число m: ");
	int m = int.Parse(Console.ReadLine());

	Console.Write("Введите число n: ");
	int n = int.Parse(Console.ReadLine());

	Console.WriteLine(AckermannFunction(m, n));
}

static int AckermannFunction(int m, int n)
{
	if (m == 0)
	{
		return n + 1;
	}
	else if (n == 0)
	{
		return AckermannFunction(m - 1, 1);
	}
	else
	{
		return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
	}
}

Main();