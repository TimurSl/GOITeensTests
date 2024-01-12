namespace GOITeensTests;

public class Test5
{
	public int N2(int[] array)
	{
		int amount = 0;

		foreach(int i in array)
		{
			(int a, int b, int c) = Split(i);

			if (a < b && b < c)
			{
				amount++;
			}
		}

		return amount;


		(int a, int b, int c) Split(int abc)
		{
			return (abc / 100, (abc / 10) % 10, abc % 10);
		}
	}

	public float For24(int X, int N)
	{
		float result = 1;
		for (int i = 0; i < N; i++)
		{
			result += ((float) Math.Pow((-1), N) * (float) Math.Pow(X, 2 * N)) / Factorial(2 * N);
		}

		return result;


		float Factorial(float n)
		{
			if (n == 0)
			{
				return 1;
			}
			else
			{
				return n * Factorial(n - 1);
			}
		}
	}

	public (int a, int b, int c) Sort(int a, int b, int c)
	{
		return (Math.Min(a, Math.Min(b, c)), Math.Max(Math.Min(a, b), Math.Min(Math.Max(a, b), c)),
			Math.Max(a, Math.Max(b, c)));
	}

	public string N7(string time1, string time2)
	{
		TimeSpan t1 = TimeSpan.Parse(time1);
		TimeSpan t2 = TimeSpan.Parse(time2);

		TimeSpan t3 = t1 + t2;
		return t3.ToString();
	}

	public int Minmax23(int N, int[] numbers)
	{
        int extremalNumbersAmount = 0;

        for (int i = 0; i < N; i++)
		{
			if (numbers[i] == numbers.Min() || numbers[i] == numbers.Max())
			{
				extremalNumbersAmount++;
			}
		}

        return extremalNumbersAmount;
	}

	public List<double> Array61(double[] A, int N)
	{
		List<double> result = new List<double>();

		for (int i = 0; i < N; i++)
		{
			var average = A.Skip(i).Take(N).Average();
			result.Add(average);
		}

		return result;
	}

	public bool While21(int N)
	{
		while (N > 0)
		{
			if (N % 2 != 0)
			{
				return true;
			}

			N /= 10;
		}

		return false;
	}

	public bool N3(int x1, int y1, int x2, int y2)
	{
		return (x1 == x2 || y1 == y2) || (Math.Abs(x1 - x2) == Math.Abs(y1 - y2));
	}

}