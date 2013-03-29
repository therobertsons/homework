// CplusString.cpp : main project file.

#include "stdafx.h"
#include <string>
#include <iostream>

using namespace System;
using namespace std;

int main(array<System::String ^> ^args)
{
	string str, str2, line2;
    Console::WriteLine(L"Enter String to be reversed");
	getline(cin,str);
	char *a=new char[str.size()+1];
	a[str.size()]=0;
	memcpy(a,str.c_str(),str.size());
	
	char* reversedstring;
	reversedstring = _strrev(a);
	printf( "The reversed string via _strrev is: %s\n", reversedstring);
	Console::WriteLine(L"Enter Another String to be reversed only this time by non std code");
	getline(cin,str2);
		char *b=new char[str2.size()+1];
	b[str2.size()]=0;
	memcpy(b,str2.c_str(),str2.size());
	ret_str(b);
	cout << endl;
	Console::ReadLine();
    return 0;
}

//Recursive string reversing 
void ret_str(char* s)
{
  if(*s != '\0')
	{
 if(*s == ' ')
 	*s++;

 ret_str(s+1);
 cout<<*(s);
	}
}

//iterative binary search.
int binarySearch(int arr[], int value, int left, int right) {
      while (left <= right) {
            int middle = (left + right) / 2;
            if (arr[middle] == value)
                  return middle;
            else if (arr[middle] > value)
                  right = middle - 1;
            else
                  left = middle + 1;
      }
      return -1;
}

 

