#include <iostream>
#include <string>
using namespace std;


template <typename T> void Multiply(T &sum, int n, T x)
{
	for (int i = 1; i <= n; i++)
	{
		sum = sum + (i*x);
	}
}

int main()
{
	int n = 10;
	int x = 2;
	int sum = 0;

	
	Multiply(sum, n, x);
	cout << sum;

	system("pause");
	return 0;

	
}