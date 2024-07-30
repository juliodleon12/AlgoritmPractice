namespace AlgoritmPractice
{
	public class Algorithms
	{
		public List<int> FibonacciSequence(int n)
		{
			List<int> f = new List<int>();
			int sumF = 0;

			for (int i = 0; i < n; i++)
			{
				if (i == 0)
				{
					f.Add(i);
				}
				else if (i == 1)
				{
					f.Add(i);
				}
				else
				{
					sumF = ((i - 1) + (i - 2));
					f.Add(sumF);
				}
			}
			return f;
		}

		int polindrome;
		public Task<bool> polindromeCheck(int p)
		{
			var original = p.ToString();
			var reversed = new string(original.Reverse().ToArray());
			var palindrom = original == reversed;

			if (palindrom)
			{
				return Task.FromResult(true);
			}
			return Task.FromResult(false);
		}

		public int factorialCalculation(int n)
		{
			int resultFactorial = 1;	
			for (int i = n; i > 0; i--)
			{
				resultFactorial = resultFactorial * i;
			}
			return resultFactorial;
		}
	}
}