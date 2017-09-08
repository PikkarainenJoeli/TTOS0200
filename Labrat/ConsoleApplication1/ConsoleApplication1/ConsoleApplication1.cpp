#include <iostream>
#include <ctime>
#include <cstdlib>
#include "stdafx.h"




#define N 100000000
int list[N];
int arr[N];

void display(int arr[], int size)// Voidaan tulostaa jonot tarkistusta varten.
{
	for (int i = 0; i < size; i++)
	{

		std::cout << arr[i] << " ";


	}
	cout << endl;
}


void quickSort(int arr[], int left, int right)
{
	int i = left;
	int j = right;
	//cout << "left:" << left<<"  ";
	//cout << "right:"<<right<<endl;
	int tmp; // swappaamista varten
	int pivot = arr[(left + right) / 2];
	//cout << "pivot:" << pivot << endl;
	while (i <= j)
	{
		while (arr[i] < pivot)
			i++;
		while (arr[j] > pivot)
			j--;
		if (i <= j)
		{
			tmp = arr[i];
			arr[i] = arr[j];
			arr[j] = tmp;
			i++;
			j--;
		}
	}
	if (left < j) // pitääkö sortata vasenta
		quickSort(arr, left, j);
	if (i < right) // pitääkö sortata oikeaa
		quickSort(arr, i, right);
}
int main()
{
	using namespace std;
	const int size = 10
		; //ALKIOT

		  //TILAN VARAAMISEEN, TARVITAAN JOS ALKOIT > 200 000
	int *numbers;
	numbers = (int *)malloc(size * sizeof(int));

	srand(unsigned(time(0)));
	for (int i = 0; i < size; i++)
	{
		numbers[i] = (rand() % 1000) + 1;

	}
	std::cout << "Unsort:" << endl; //TULOSTA ALKUPERÄINEN ARRAY
	display(numbers, size);

	clock_t tStart = clock(); //ALOITA AJASTUS

	quickSort(numbers, 0, size - 1);
	printf("Time taken: %.2fs\n", (double)(clock() - tStart) / CLOCKS_PER_SEC); //NÄYTÄ MENNYT AIKA

	std::cout << "sortattu:" << endl;
	display(numbers, size); //TULOSTA SORTATTU ARRAY

	delete[] numbers;

	std::getchar();
	return 0;
}