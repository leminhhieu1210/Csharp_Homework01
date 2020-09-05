#include <stdio.h>
#define amount 100

void input(int *n, int a[]) {
	int i;
	
	printf("Nhap so luong phan tu: ");
	scanf("%d", n);
	for (i = 0; i < *n; ++i)
	{
		printf("a[%d] = ", i);
		scanf("%d", &a[i]);
	}
}

void output(int n, int a[]) {
	int i;
	for (i = 0; i < n; ++i)
	{
		printf("%d\t", a[i]);
	}
}

void sortArray(int n, int a[]) {
	int t, i, j;
	
	for (i = 0; i < n; ++i)
	{
		for (j = i + 1; j < n; ++j)
		{
			if (a[i] > a[j])
			{
				t = a[i];
				a[i] = a[j];
				a[j] = t;
			}
		}
	}
}

int main() {
	int n, i;
	int a[amount];
	
	input(&n, a);
	sortArray(n, a);
	output(n, a);
	
	return 0;
}

