#define LIBEXPORT_API extern "C" __declspec(dllexport)

//���ú���  

LIBEXPORT_API int __stdcall mySum(int a, int b)

{

	return a + b;

}

LIBEXPORT_API int __stdcall mySub(int a, int b)

{

	return a - b;

}