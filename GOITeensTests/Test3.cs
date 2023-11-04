namespace GOITeensTests;

public class Test3
{
	public (int x, int y) Begin40(float a1, float b1, float c1, float a2, float b2, float c2)
	{
		float D = a1 * b2 - a2 * b1;

		float x = (c1 * b2 - c2 * b1) / D;
		float y = (a1 * c2 - a2 * c1) / D;

		return ((int) x, (int) y);
	}

	public bool Boolean20(int abc)
	{
		int a = abc / 100;
		int b = abc / 10 % 10;
		int c = abc % 10;

		return a != b && b != c && c != a;
	}

	public bool Boolean33(int a, int b, int c)
	{
		return (a + b) > c && (a + c) > b && (b + c) > a;
	}

	public int If19(int a, int b, int c, int d)
	{
		int n = 0;
		if (a == b && b == c)
			n = 4;

		else if (a == b && a == d)
			n = 3;

		else if (a == c && a == d)
			n = 2;

		else if (b == c && b == d)
			n = 1;

		return n;
	}

	public float For23(float x, int n)
	{
		float result = x;
		float x1 = x;

		for (int i = 1; i < n; ++i)
		{
			x1 *= -1 * x * x;
			result += x1;
		}

		return result;
	}

	public (int a, int b, int c) ShiftRight(int a, int b, int c)
	{
		return (c, a, b);
	}

	public void Proc14()
	{
		for (int i = 0; i <= 1; ++i)
		{
			Console.Write("Enter a b c: ");
			string[]? input = Console.ReadLine ()?.Split(' ');
			int a = int.Parse(input[0]);
			int b = int.Parse(input[1]);
			int c = int.Parse(input[2]);

			(a, b, c) = ShiftRight(a, b, c);
			Console.WriteLine($"{a} {b} {c}");
		}
	}

	public int MinMax17(int[] numbers)
	{
		int max = 0;
		int maxnum = 0;

		for (int i = 1; i <= numbers.Length; ++i)
		{
			if ((numbers[i] >= max) || (i == 1))
			{
				max = numbers[i];
				maxnum = i;
			}
		}

		return numbers.Length - maxnum;
	}

	public float[] Array135(int n1, int n2, float[][] a, float[][] b)
	{
		int amin, bmin;
		float rmin = FindClosestPair(a, b, n1, n2, out amin, out bmin);

		return new[] {rmin, amin, a[amin][0], a[amin][1], bmin, b[bmin][0], b[bmin][1]};


		static float FindClosestPair(float[][] a, float[][] b, int n1, int n2, out int amin, out int bmin)
		{
			float r, rmin = (float) Math.Sqrt(Math.Pow(a[0][0] - b[0][0], 2) + Math.Pow(a[0][1] - b[0][1], 2));
			amin = 0;
			bmin = 0;

			for (int i = 0; i < n1; i++)
			{
				for (int i2 = 0; i2 < n2; i2++)
				{
					r = (float) Math.Sqrt(Math.Pow(a[i][0] - b[i2][0], 2) + Math.Pow(a[i][1] - b[i2][1], 2));
					if (r < rmin)
					{
						rmin = r;
						amin = i;
						bmin = i2;
					}
				}
			}

			return rmin;
		}
	}


	public int[,] Matrix51(int[,] matrix)
	{
		int maxI = 0;
		int maxJ = 0;
		int minI = 0;
		int minJ = 0;

		for (int j = 0; j < matrix.GetLength(0); j++)
		{
			for (int i = 1; i < matrix.GetLength(1); i++)
			{
				if (matrix[i, j] > matrix[maxI, maxJ])
				{
					maxI = i;
					maxJ = j;
				}

				if (matrix[i, j] < matrix[minI, minJ])
				{
					minI = i;
					minJ = j;
				}
			}
		}

		SwapMatrixRow(matrix, maxI, minI, matrix.GetLength(0));

		static void Swap(ref int x, ref int y)
		{
			if (x != y)
			{
				x = x + y;
				y = x - y;
				x = x - y;
			}
		}

		static void SwapMatrixRow(int[,] mat, int x, int y, int n)
		{
			if (x != y)
			{
				for (int j = 0; j < n; j++)
				{
					Swap(ref mat[x, j], ref mat[y, j]);
				}
			}
		}

		return matrix;
	}

	public char[] String4(int n)
	{
		List<char> result = new List<char> ();

		for (char i = 'A'; i < 'A' + n; i++)
		{
			result.Add(i);
		}

		return result.ToArray ();
	}

	public void Task12(int x0, int y0, int r, Point[] points)
	{
		foreach(Point point in points)
		{
			double distance = Math.Sqrt(Math.Pow(point.X - x0, 2) + Math.Pow(point.Y - y0, 2));
			if (distance < r)
			{
				Console.WriteLine($"Точка ({point.X}, {point.Y}) на расстоянии {distance} от точки ({x0}, {y0})");
			}
		}
	}
}