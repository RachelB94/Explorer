#include<iostream>
using namespace std;

//Swap Template using Reference
template <typename T> void Swap(T &x, T &y)
{
	int temp = x;
	x = y;
	y = temp;

}

//Swap Template using Address
template <typename T> void Swap2(T *x, T *y)
{
	int temp = *x;
	*x = *y;
	*y = temp;
}

int main()
{

	//Integers
	int x = 10;
	int y = 20;

	cout << "Integers" << endl;
	cout << endl;
	cout << "By Reference " << endl;
	cout << "Before Swap " << endl;
	cout << "X:" << x << endl;
	cout << "Y:" << y << endl;
	cout << endl;
	cout << "After Swap " << endl;
	Swap(x, y);
	cout << "X:" << x << endl;
	cout << "Y:" << y << endl;
	
	cout << endl;

	cout << "By Address" << endl;
	cout << "Before Swap" << endl;
	int a = 30;
	int b = 40;
	cout << "A:" << a << endl;
	cout << "B:" << b << endl;

	cout << endl;
	cout << "After Swap" << endl;
	Swap2(&a, &b);
	cout << "A:" << a << endl;
	cout << "B:" << b << endl;

	cout << endl;

	cout << "Floats" << endl;
	cout << endl;
	cout << "By Reference " << endl;
	cout << "Before Swap" << endl;
	//Floats
	float p = 20.0f;
	float q = 10.0f;
	cout << "P:" << p << endl;
	cout << "Q:" << q << endl;

	cout << endl;
	cout << "After Swap" << endl;
	Swap(p, q);
	cout << "P:" << p << endl;
	cout << "Q:" << q << endl;

	cout << endl;

	cout << "By Address" << endl;

	cout << "Before Swap" << endl;
	float m = 20.5f;
	float n = 55.8f;

	cout << "M:" << m << endl;
	cout << "N:" << n << endl;

	cout << endl;

	cout << "After Swap" << endl;
	Swap2(&m, &n);
	cout << "M:" << m << endl;
	cout << "N:" << n << endl;



	system("pause");
	return 0;
}