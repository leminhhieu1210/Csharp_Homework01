#include <stdio.h>

struct PhanSo {
	int tu, mau;
};
typedef struct PhanSo ps;

void input(ps &p) {
	printf("\nNhap tu so: "); scanf("%d", &p.tu);
	do
	{
		printf("\nNhap mau so: "); scanf("%d", &p.mau);
		if (!p.mau) printf("\nMau so khong hop le!");
	} while (!p.mau);
}

void output(ps p) {
	printf("%d/%d\n", p.tu, p.mau);
}

ps tong(ps a, ps b) {
	ps c;
	
	c.tu = a.tu * b.mau + a.mau * b.tu;
	c.mau = a.mau * b.mau;
	
	return c;
}

ps hieu(ps a, ps b) {
	ps c;
	
	c.tu = a.tu * b.mau - a.mau * b.tu;
	c.mau = a.mau * b.mau;
	
	return c;
}

ps tich(ps a, ps b) {
	ps c;
	
	c.tu = a.tu * b.tu;
	c.mau = a.mau * b.mau;
	
	return c;
}

ps thuong(ps a, ps b) {
	ps c = tich(a, b);
	int t = c.tu;
	
	c.tu = a.tu * b.mau;
	c.mau = a.mau * b.tu;
	
	return c;
}

int main() {
	ps a, b, c;
	
	input(a);
	output(a);
	input(b);
	output(b);
	
	c = tong(a, b);
	printf("\nTong 2 phan so = ");
	output(c);
	
	c = hieu(a, b);
	printf("\nHieu 2 phan so = ");
	output(c);
	
	c = tich(a, b);
	printf("\nTich 2 phan so = ");
	output(c);
	
	c = thuong(a, b);
	
	if (c.mau) 
	{
		printf("\nThuong 2 phan so = ");
		output(c);
	}
	else printf("\nKhong tinh duoc thuong!");
	
	
	return 0;
}

