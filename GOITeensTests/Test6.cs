namespace GOITeensTests;

public class Test6
{
	public static int Integer26(int K)
	{
		return K % 7 + 1;
	}

	public static bool Boolean14(int a, int b, int c)
	{
		return a > 0 ^ b > 0 ^ c > 0;
	}

	public static bool Boolean31(int a, int b, int c)
	{
		return (a == b && a != c) || (a == c && a != b) || (b == c && a != b);
	}

	public static (int, int) If10(int a, int b)
	{
		if (a != b)
		{
			int sum = a + b;
			a = sum;
			b = sum;
		}

		a = 0;
		b = 0;

		return (a, b);
	}

	public static int If27(int x)
	{
		if (x < 0)
		{
			return 0;
		}
		else if (x % 2 == 0)
		{
			return 1;
		}
		else
		{
			return -1;
		}
	}

	public static (int, int) Case9(int D, int M)
	{
		D++;
		switch (M)
		{
			case 1:
			case 3:
			case 5:
			case 7:
			case 8:
			case 10:
				if (D > 31)
				{
					D = 1;
					M++;
				}
				break;
			case 4:
			case 6:
			case 9:
			case 11:
				if (D > 30)
				{
					D = 1;
					M++;
				}
				break;
			case 2:
				if (D > 28)
				{
					D = 1;
					M++;
				}
				break;
			case 12:
				if (D > 31)
				{
					D = 1;
					M = 1;
				}
				break;
		}

		return (D, M);
	}

	public static float For12(int N)
	{
		float mul = 1;
		for (int i = 0; i <= N; i++)
		{
			mul *= 1 + (float) i / 10;
		}
		return mul;
	}

	public static float For38(int N)
	{
		float result = 0;
		for (int i = 1; i <= N; i++)
		{
			result += (float) Math.Pow(i, N - i + 1);
		}

		return result;
	}

	public static int While25(int N)
	{
		int f1 = 1;
		int f2 = 1;
		int fibbonachi = 0;

		while (fibbonachi < N + 1)
		{
			fibbonachi = f1 + f2;
			f2 = f1;
			f1 = fibbonachi;
		}

		return fibbonachi;
	}

	public static bool IsPower5(int K)
	{
		int i = 1;
		while (i < K)
		{
			i *= 5;
		}

		return i == K;
	}

	public static bool IsPalindrom(int K)
	{
		int reversed = 0;
		int original = K;

		while (K > 0)
		{
			reversed = reversed * 10 + K % 10;
			K /= 10;
		}

		return original == reversed;
	}

	public static float Exp1(float x, float e)
	{
		float result = 0;
		float term = 1;
		float ni = 1;
		float xi = 1;

		int i = 0;
		while (term > e)
		{
			result += term;
			i++;
			term = (xi * x) / (ni * i);
		}

		return result;
	}

	public static float[] Proc40()
	{
		float[] arr = new float[6];
		Random random = new Random();

		for (int i = 0; i < 6; i++)
		{
			arr[i] = Exp1(random.Next (), random.Next ());
		}

		return arr;
	}

	public static string String16(string input)
	{
		char[] result = new char[input.Length];
		for (int i = 0; i < input.Length; i++)
		{
			char c = input[i];
			if (IsLatin(c))
			{
				result[i] = char.ToUpper(c);
				continue;
			}
			result[i] = c;
		}
		return new string(result);

		bool IsLatin(char c)
		{
			return ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));
		}
	}
}
