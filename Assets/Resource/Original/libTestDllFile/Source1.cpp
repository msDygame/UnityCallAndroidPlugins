#include <math.h> 

extern "C"
{
	__declspec(dllexport) float multiply(float x, float y)
	{
		float f = x * y ;
		int i =  ((f+0.0005)*1000);	//�|�ˤ��J��p���I�ĤT��
		return ((float)i/1000) ;
	}
}

extern "C"
{
	__declspec(dllexport) float add(float x, float y)
	{
		float f = x + y ;
		int i =  ((f+0.0005)*1000);	//�|�ˤ��J��p���I�ĤT��
		return ((float)i/1000) ;
	}
}