namespace GOITeensTests;

public class Test4
{
	/*
		For14
		For23
		While19
		Series25 зі захистом від дурня
		Minmax24
		Minmax26
		Array17
		Array25
		Array48
		Array66
		Array77
		Array134
		String10*
		String27
	 */

	public int For14(int a)
	{
		int result = 0;
		for (int i = 1; i <= (2 * a - 1); i += 2)
		{
			result += i;
		}

		return result;
	}

	public float For23(float x, int n)
	{
		float result = x;
		float x1 = x;

		for (int i = 1; i < n; i++)
		{
			x1 *= -1 * x * x;
			result += x1;
		}

		return result;
	}

	public int While19(int N)
	{
		int R = 0;
		while (N > 0)
		{
			int M = N % 10;
			R = R * 10 + M;
			N /= 10;
		}

		return R;
	}

	public int Series25(int n, int[] r)
	{
		int sum = 0;
		int tempsum = 0;
		int f = 0;

		int firstZeroIndex = -1;
		int lastZeroIndex = -1;

		for (int i = 0; i < n; i++)
		{
			tempsum += r[i];

			if (r[i] == 0)
			{
				if (firstZeroIndex == -1)
				{
					firstZeroIndex = i;
				}

				lastZeroIndex = i;

				if (f != 0)
				{
					sum += tempsum;
				}
				else
				{
					f = 1;
				}

				tempsum = 0;
			}
		}

		if (firstZeroIndex == lastZeroIndex)
		{
			return 0;
		}

		return sum;
	}

	public int Minmax24(int n, int[] r)
	{
		int maxsum = 0;

		for (int i = 1; i < n; i++)
		{
			int r1 = r[i];
			int r2 = r[i - 1];

			if (i == 2) maxsum = r2 + r1;
			if (r1 + r2 > maxsum) maxsum = r2 + r1;
		}

		return maxsum;
	}

	public int Minmax26(int N, int[] r)
	{
		int num = 0;
		int maxnum = 0;
		for (int i = 0; i < N; i++)
		{
			int ni = r[i];

			if (ni % 2 == 0) ++num;
			else
			{
				if (num > maxnum) maxnum = num;
				num = 0;
			}
		}

		if (num > maxnum) maxnum = num;
		return maxnum;
	}

	public List<int> Array17(int n, int[] a)
	{
		List<int> result = new List<int> ();
		for (int i = 0; i < n / 2 + 1; i += 2)
		{
			if (i < n / 2) result.Add(a[i + 1]);
			if (n - i - 1 > n / 2) result.Add(a[n - i - 2]);
			if (n - i - 2 > n / 2) result.Add(a[n - i - 2]);
		}

		return result;
	}

	public float Array25(float n, float[] a)
	{
		float denominator = a[1] / a[0];
		for (int i = 1; i < n; i++)
		{
			if (Math.Abs(denominator - a[i] / a[i - 1]) > 0.01)
			{
				denominator = 0;
			}
		}

		return denominator;
	}

	public int Array48(int n, int[] a)
	{
		int i2, nummax = 0;
		for (int i = 0; i < n; ++i)
		{
			int num = 1;
			for (i2 = i + 1; i2 < n; ++i2)
			{
				if (a[i] == a[i2])
				{
					++num;
				}
			}

			if (num > nummax)
			{
				nummax = num;
			}
		}

		return nummax;
	}

	public int[] Array66(int n, int[] a)
	{
		int even = 0;
		int i;

		for (i = 0; i < n; i++)
		{
			if (a[i] % 2 == 0)
			{
				even = a[i];
				break;
			}
		}

		for (; i < n; i++)
		{
			if (a[i] % 2 == 0)
			{
				a[i] += even;
			}
		}

		return a;
	}

	public int[] Array77(int n, int[] a)
	{
		int i;

		if (a[0] < a[1])
		{
			i = 2;
			a[0] *= a[0];
		}
		else i = 1;

		for (; i < n - 1; ++i)
		{
			if ((a[i - 1] > a[i]) && (a[i] < a[i + 1]))
			{
				a[i] *= a[i];
				++i;
			}
		}

		if ((i == n - 1) && (a[n - 2] > a[n - 1])) a[n - 1] *= a[n - 1];

		return a;
	}

	public void Array134(int n, Point[] a)
	{
		int a1 = 0;
		int a2 = 0;
		int i2;

		double r;
		double rmax = 0;
		for (int i = 0; i < n; ++i)
		{
			for (i2 = i + 1; i2 < n; ++i2)
			{
				double dY = a[i].Y - a[i2].Y;
				double dX = a[i].X - a[i2].X;

				r = Math.Sqrt(dX * dX + dY * dY);
				if (r > rmax)
				{
					rmax = r;
					a1 = i;
					a2 = i2;
				}
			}
		}

		Console.WriteLine("A  {distance} :\n x: {x}\n y: {y}\n", a1+1, a[a1].X, a[a1].Y);
		Console.WriteLine("A  {distance} :\n x: {x}\n y: {y}\n", a2+1, a[a2].X, a[a2].Y);
	}
}