#include <stdio.h>
#include <string.h>
#define amount 100

struct SinhVien {
	char ma[10], ten[30], queQuan[30];
	int ngaySinh;
	float toan, ly, hoa, tb; 
};
typedef struct SinhVien sv;


void input(int *n, sv a[]) {
	int i;
	printf("Nhap so luong sinh vien:");
	scanf("%d", n);
	for (i = 0; i < *n; ++i)
	{
		printf("Ma sinh vien: ");
		fflush(stdin);
		gets(a[i].ma);
		
		printf("Ho va ten: ");
		fflush(stdin);
		gets(a[i].ten);
		
		printf("Ngay sinh: ");
		scanf("%d", &a[i].ngaySinh);
		
		printf("Que quan: ");
		fflush(stdin);
		gets(a[i].queQuan);
		
		printf("Diem Toan: ");
		scanf("%f", &a[i].toan);
		printf("Diem Ly: ");
		scanf("%f", &a[i].ly);
		printf("Diem Hoa: ");
		scanf("%f", &a[i].hoa);
		printf("Diem TB: ");
		scanf("%f", &a[i].tb);
	}
}

void output(int n, sv a[]) {
	int i;
	printf("\n%25s%15s\n", "", "DANH SACH SINH VIEN");
	printf("%-3s %-9s %-12s %-10s %-9s %-5s %-5s %-5s %-5s\n", "STT", "Ma sv", "Ho va ten", "Ngay sinh", "Que quan", "Toan", "Ly", "Hoa", "TB");
	for (i = 0; i < n; ++i) 
	{
		printf("%-3d %-7s %-17s %-7d %-9s %-5.1f %-5.1f %-5.1f %-5.1f\n", i + 1, a[i].ma, a[i].ten, a[i].ngaySinh, a[i].queQuan, a[i].toan, a[i].ly, a[i].hoa, a[i].tb);
	}
}

void findSV(int n, sv a[]) {
	char id[10];
	int i, check;
	
	printf("\nNhap ma sinh vien can tim: ");
	fflush(stdin);
	gets(id);
	
	check = 0;
	printf("\nSinh vien co ma %s la:\n", id);
	for (i = 0; i < n; ++i)
	{
		if (strcmp(id, a[i].ma) == 0)
		{
			check = 1;
			printf("%-7s %-17s %-7d %-9s %-5.1f %-5.1f %-5.1f %-5.1f\n", a[i].ma, a[i].ten, a[i].ngaySinh, a[i].queQuan, a[i].toan, a[i].ly, a[i].hoa, a[i].tb);
		}
	}
	if (!check) printf("Khong tim thay sinh vien!");
}

void tb7(int n, sv a[]) {
	int i, check;
	
	check = 0;
	printf("\nDanh sach sinh vien co diem trung binh > 7.0 la:\n");
	for (i = 0; i < n; ++i)
	{
		if (a[i].tb > 7)
		{
			check = 1;
			printf("%-7s %-17s %-7d %-9s %-5.1f %-5.1f %-5.1f %-5.1f\n", a[i].ma, a[i].ten, a[i].ngaySinh, a[i].queQuan, a[i].toan, a[i].ly, a[i].hoa, a[i].tb);
		}
	}
	if (!check) printf("Khong co sinh vien thoa man!");
} 

int main() {
	sv a[amount];
	int n;
	
	input(&n, a);
	output(n, a);
	findSV(n, a);
	tb7(n, a);
	
	return 0;
}

